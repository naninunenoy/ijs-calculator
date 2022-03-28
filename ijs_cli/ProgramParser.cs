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
        foreach (var originalCode in programCodes) {
            IElement element = new UnknownElement(originalCode.RawCode());
            if (originalCode.IsContinuousJump(out var jumps) && jumps.Length > 1) {
                var jumpElements = ToJumpUnitElements(jumps);
                var continuousJumps = new ContinuousJumps();
                try {
                    continuousJumps.Build(jumpElements.Cast<IElement>().ToArray());
                    element = continuousJumps;
                } catch (Exception e) {
                    Console.WriteLine($"<!> 連続ジャンプの解析に失敗しました {e.Message} {originalCode.RawCode()}");
                }
            } else {
                if (lowerCodeDict.TryGetValue(originalCode.LowerInvariantCode(), out var unitElement)) {
                    element = unitElement;
                } else {
                    Console.WriteLine($"<!> 指定した競技に含まれない項目があります {originalCode.RawCode()}");
                }
            }

            if (originalCode.IsSecondHalf()) {
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
        return program.Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => new ElementCode(x));
    }

    IEnumerable<UnitElement> ToJumpUnitElements(IEnumerable<ElementCode> elementCodes) {
        var jumpElements = new List<UnitElement>();
        foreach (var jump in elementCodes) {
            if (lowerCodeDict.TryGetValue(jump.LowerInvariantCode(), out var unitElement)) {
                if (((IElement)unitElement).ElementType != ElementType.Jump) {
                    Console.WriteLine($"<!> 連続ジャンプにジャンプでない項目がふくまれています {jump.RawCode()}");
                    continue;
                }
                jumpElements.Add(unitElement);
            } else {
                Console.WriteLine($"<!> 連続ジャンプに定した競技に含まれない項目があります {jump.RawCode()}");
            }
        }
        return jumpElements;
    }
}
