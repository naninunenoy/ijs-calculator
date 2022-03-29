using ijs.Internal;

namespace ijs.Localizations; 

public static class LocalizationsDict {
    static readonly CsvDict SingleDict;
    static readonly CsvDict PairDict;
    static readonly CsvDict IceDanceDict;

    static LocalizationsDict() {
        SingleDict = new CsvDict("code");
        PairDict = new CsvDict("code");
        IceDanceDict = new CsvDict("code");
    }
    
    internal static void Build() {
        SingleDict.Build(LocalizationsCsv.Single);
        PairDict.Build(LocalizationsCsv.Pair);
        IceDanceDict.Build(LocalizationsCsv.IceDance);
    }

    internal static bool TryGetValues(SportsType sportsType, string code, out ElementName elementName) {
        var dict = sportsType switch {
            SportsType.Single => SingleDict,
            SportsType.Pair => PairDict,
            SportsType.IceDance => IceDanceDict,
            _ => throw new ArgumentOutOfRangeException(nameof(sportsType), sportsType, null)
        };

        var ja = "";
        var en = "";
        foreach (var langCode in LocalizationsCsv.LangCodes()) {
            if (dict.TryGetValue(code, langCode, out string name)) {
                switch (langCode) {
                case "ja":
                    ja = name;
                    break;
                case "en":
                    en = name;
                    break;
                }
            }
        }
        elementName = new ElementName(ja, en);
        return true;
    }
}
