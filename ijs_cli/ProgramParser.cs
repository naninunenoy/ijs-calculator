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
        var elementList = new ElementList();
        foreach (var code in elementCodes) {
            IElement element = new UnknownElement(code.RawCode());
            if (code.IsCombination(out var jumpElementCodes)) {
                // 連続ジャンプへの変換
                try {
                    var (jumpElements, isJumpSequence) = ToJumpElements(jumpElementCodes);
                    element = isJumpSequence ? jumpElements.ToJumpSequence() : jumpElements.ToCombinationJump();
                } catch (Exception e) {
                    Console.WriteLine($"<!> 連続ジャンプの解析に失敗しました {code.RawCode()} {e.Message}");
                }
            } else {
                // 単独のエレメントとみなしてピックアップ
                if (lowerCodeDict.TryGetValue(code.LowerInvariantCode(), out var unitElement)) {
                    element = unitElement;
                } else {
                    Console.WriteLine($"<!> 指定した競技に含まれない項目があります {code.RawCode()}");
                }
            }
            // 後半のエレメントか判定して追加
            elementList.AddElement(code.IsSecondHalf() ? element.ToSecondHalfElement() : element);
        }
        return elementList;
    }

    static IEnumerable<ElementCode> SplitProgramCodes(string program) {
        return program.Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => new ElementCode(x));
    }

    (IEnumerable<IElement>, bool) ToJumpElements(IEnumerable<ElementCode> elementCodes) {
        var jumpElements = new List<IElement>();
        var errors = new List<string>();
        var isJumpSequence = false;
        foreach (var code in elementCodes) {
            if (lowerCodeDict.TryGetValue(code.LowerInvariantCode(), out var element)) {
                if (element.ElementType == ElementType.Jump) {
                    jumpElements.Add(element);
                } else {
                    errors.Add($"<!> 連続ジャンプにジャンプでない項目がふくまれています {code.RawCode()}");
                }
            } else if (code.IsJumpSequenceCode()) {
                isJumpSequence = true;
            } else {
                errors.Add($"<!> 連続ジャンプに指定した競技に含まれない項目があります {code.RawCode()}");
            }
        }
        // 全てのコードが連続ジャンプとして正しく解析された場合のみ連続ジャンプとして返す
        if (errors.Any()) {
            throw new ArgumentException($"\n{string.Join("\n", errors)}");
        }
        return (jumpElements, isJumpSequence);
    }
}
