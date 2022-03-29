using ijs;

namespace ijs_cli;

public class ProgramParser {
    readonly IReadOnlyDictionary<string, IElement> lowerCodeDict;

    public ProgramParser(IEnumerable<IElement> allElements) {
        lowerCodeDict = allElements.ToDictionary(x => x.FullCode.ToLowerInvariant());
    }

    public ElementList Parse(string programArg) {
        // プログラムをコードに分割
        var programCodes = SplitProgramCodes(programArg);
        // コードを解析
        var programElements = new List<IElement>();
        foreach (var originalCode in programCodes) {
            IElement element = new UnknownElement(originalCode.RawCode());
            if (originalCode.IsContinuousJump(out var jumps) && jumps.Length > 1) {
                var jumpElements = ToJumpUnitElements(jumps).ToArray();
                try {
                    element = ElementExtension.CreateAsContinuousJumps(jumpElements);
                } catch (Exception e) {
                    Console.WriteLine($"<!> 連続ジャンプの解析に失敗しました {e.Message} {originalCode.RawCode()}");
                }
            } else {
                if (!lowerCodeDict.TryGetValue(originalCode.LowerInvariantCode(), out element!)) {
                    Console.WriteLine($"<!> 指定した競技に含まれない項目があります {originalCode.RawCode()}");
                }
            }

            if (originalCode.IsSecondHalf()) {
                programElements.Add(ElementExtension.ToHalfSecondElement(element));
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

    IEnumerable<IElement> ToJumpUnitElements(IEnumerable<ElementCode> elementCodes) {
        var jumpElements = new List<IElement>();
        foreach (var jump in elementCodes) {
            if (lowerCodeDict.TryGetValue(jump.LowerInvariantCode(), out var element)) {
                if (element.ElementType != ElementType.Jump) {
                    Console.WriteLine($"<!> 連続ジャンプにジャンプでない項目がふくまれています {jump.RawCode()}");
                    continue;
                }
                jumpElements.Add(element);
            } else {
                Console.WriteLine($"<!> 連続ジャンプに定した競技に含まれない項目があります {jump.RawCode()}");
            }
        }
        return jumpElements;
    }
}
