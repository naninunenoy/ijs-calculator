using ijs;

namespace ijs_cli;

public class ProgramParser {
    readonly IReadOnlyDictionary<string, IElement> lowerCodeDict;

    public ProgramParser(IEnumerable<IElement> allElements) {
        lowerCodeDict = allElements.ToDictionary(x => x.FullCode.ToLowerInvariant());
    }

    public ElementList Parse(string programArg) {
        // プログラムをコードに分割
        var elementCodes = SplitProgramCodes(programArg);
        // コードを解析
        var elements = new List<IElement>();
        foreach (var code in elementCodes) {
            IElement element = new UnknownElement(code.RawCode());
            if (code.IsContinuousJump(out var jumpElementCodes)) {
                // 連続ジャンプへの変換
                try {
                    var jumps = ToJumpUnitElements(jumpElementCodes).ToArray();
                    element = ElementExtension.CreateAsContinuousJumps(jumps);
                } catch (Exception e) {
                    Console.WriteLine($"<!> 連続ジャンプの解析に失敗しました {e.Message} {code.RawCode()}");
                }
            } else {
                // 単独のエレメントとみなしてピックアップ
                if (lowerCodeDict.TryGetValue(code.LowerInvariantCode(), out var unitElement)) {
                    element = unitElement;
                } else {
                    Console.WriteLine($"<!> 指定した競技に含まれない項目があります {code.RawCode()}");
                }
            }
            // 後半のエレメントを判定
            elements.Add(code.IsSecondHalf() ? ElementExtension.ToHalfSecondElement(element) : element);
        }

        var elementList = new ElementList();
        elementList.Build(elements.ToArray());
        return elementList;
    }

    static IEnumerable<ElementCode> SplitProgramCodes(string program) {
        return program.Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => new ElementCode(x));
    }

    IEnumerable<IElement> ToJumpUnitElements(IEnumerable<ElementCode> elementCodes) {
        var jumpElements = new List<IElement>();
        var errors = new List<string>();
        foreach (var jump in elementCodes) {
            if (lowerCodeDict.TryGetValue(jump.LowerInvariantCode(), out var element)) {
                if (element.ElementType != ElementType.Jump) {
                    errors.Add($"<!> 連続ジャンプにジャンプでない項目がふくまれています {jump.RawCode()}");
                    continue;
                }
                jumpElements.Add(element);
            } else {
                errors.Add($"<!> 連続ジャンプに定した競技に含まれない項目があります {jump.RawCode()}");
            }
        }
        // 全てのコードが連続ジャンプとして正しく解析された場合のみ連続ジャンプとして返す
        if (errors.Any()) {
            throw new ArgumentException(string.Join("\n", errors));
        }
        return jumpElements;
    }
}
