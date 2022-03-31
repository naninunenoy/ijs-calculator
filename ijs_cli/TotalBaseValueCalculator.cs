using ijs;

namespace ijs_cli; 

public class TotalBaseValueCalculator {
    readonly string sportsType;
    readonly string programRawArg;

    public TotalBaseValueCalculator(string sportsType, string programRawArg) {
        this.sportsType = sportsType;
        this.programRawArg = programRawArg;
    }

    public (string totalBaseValueStr, string description) Calculate() {
        var allElements = sportsType.ToLowerInvariant() switch {
            "single" => ElementTable.SingleElementsList,
            "pair" => ElementTable.PairElementsList,
            "icedance" => ElementTable.IceDanceElementsList,
            _ => throw new ArgumentException(
                $"種目の指定が正しくありません={sportsType} 有効なのは single/pair/icedance のいずれか1つです")
        };
        var parser = new ProgramParser(allElements.ToArray());
        var elementList = parser.Parse(programRawArg);

        var extractor = new ElementListExtractor(elementList);
        // 全て不明の場合のみ失敗表示にする
        if (elementList.List.All(x => x is UnknownElement)) {
            throw new ArgumentException($"得点を計算可能なエレメントがありませんでした\n{extractor.Extract()}");
        }
        return (elementList.TotalBaseValue().Item2, extractor.Extract());
    }
}
