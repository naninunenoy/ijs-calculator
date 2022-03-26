using ijs;

namespace ijs_cli; 

public class TotalBaseValueCalculator {
    readonly string sportsType;
    readonly string programRawArg;

    public TotalBaseValueCalculator(string sportsType, string programRawArg) {
        this.sportsType = sportsType;
        this.programRawArg = programRawArg;
    }

    public (TotalBaseValue totalBaseValue, string description) Calculate() {
        var allElements = sportsType.ToLowerInvariant() switch {
            "single" => ElementTable.SingleElementsList,
            "pair" => ElementTable.PairElementsList,
            "icedance" => ElementTable.IceDanceElementsList,
            _ => throw new ArgumentException(
                $"種目の指定が正しくありません={sportsType} 有効なのは single/pair/icedance のいずれか1つです")
        };
        ElementList elementList;
        var parser = new ProgramParser(allElements.ToArray());
        try {
            elementList = parser.Parse(programRawArg);
        } catch (Exception e) {
            return (default, e.Message);
        }

        var extractor = new ElementListExtractor(elementList);
        return (new TotalBaseValue(elementList.TotalBaseValue()), extractor.Extract());
    }
}
