using ijs;

namespace ijs_cli;

public class ProgramParser {
    readonly IReadOnlyDictionary<string, UnitElement> lowerCodeDict;

    public ProgramParser(IEnumerable<UnitElement> allElements) {
        lowerCodeDict = allElements.ToDictionary(x => x.Id.ToString().ToLowerInvariant());
    }

    public ElementList Parse(string programArg) {
        // プログラムをコードに分割
        var programCodes = SplitProgramCodes(programArg);
        // コードを解析
        var programElements = new List<IElement>();
        foreach (var code in programCodes) {
            IElement element;
            if (code.IsContinuousJump(out var jumps) && jumps.Length > 1) {
                var jumpElements = new List<UnitElement>();
                foreach (var jump in jumps) {
                    if (lowerCodeDict.TryGetValue(jump.LowerInvariantCode(), out var unitElement)) {
                        if (((IElement)unitElement).ElementType != ElementType.Jump) {
                            throw new ArgumentException($"連続ジャンプにジャンプでない項目がふくまれています {jump.RawCode()}");
                        }
                        jumpElements.Add(unitElement);
                    } else {
                        throw new ArgumentException($"指定した競技に含まれない項目があります {jump.RawCode()}");
                    }
                }

                var continuousJumps = new ContinuousJumps();
                try {
                    continuousJumps.Build(jumpElements.Cast<IElement>().ToArray());
                } catch (Exception e) {
                    throw new ArgumentException($"連続ジャンプの項目が生成できませんでした {code.RawCode()} {e.Message}");
                }
                element = continuousJumps;
            } else {
                if (lowerCodeDict.TryGetValue(code.LowerInvariantCode(), out var unitElement)) {
                    element = unitElement;
                } else {
                    throw new ArgumentException($"指定した競技に含まれない項目があります {code.RawCode()}");
                }
            }

            if (code.IsSecondHalf()) {
                programElements.Add(new SecondHalfElement(element));
            } else {
                programElements.Add(element);
            }
        }

        var ret = new ElementList();
        ret.Build(programElements.ToArray());
        return ret;
    }

    static IEnumerable<ElementCode> SplitProgramCodes(string program) {
        return program.Split("-").Select(x => new ElementCode(x));
    }
}
