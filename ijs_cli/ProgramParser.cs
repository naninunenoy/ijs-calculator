﻿using ijs;

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
                    element = ElementExtension.CreateAsContinuousJumps(ToJumpElements(jumpElementCodes).ToArray());
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
            elements.Add(code.IsSecondHalf() ? ElementExtension.ToHalfSecondElement(element) : element);
        }

        var elementList = new ElementList();
        elementList.Build(elements.ToArray());
        return elementList;
    }

    static IEnumerable<ElementCode> SplitProgramCodes(string program) {
        return program.Split("-", StringSplitOptions.RemoveEmptyEntries).Select(x => new ElementCode(x));
    }

    IEnumerable<IElement> ToJumpElements(IEnumerable<ElementCode> elementCodes) {
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
                errors.Add($"<!> 連続ジャンプに指定した競技に含まれない項目があります {jump.RawCode()}");
            }
        }
        // 全てのコードが連続ジャンプとして正しく解析された場合のみ連続ジャンプとして返す
        if (errors.Any()) {
            throw new ArgumentException($"\n{string.Join("\n", errors)}");
        }
        return jumpElements;
    }
}
