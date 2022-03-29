using System.Globalization;

namespace ijs.Internal; 

internal readonly struct ElementName {
    readonly string ja;
    readonly string en;

    internal ElementName(string ja, string en) {
        this.ja = ja;
        this.en = en;
    }

    public string GetNameOf(RegionInfo regionInfo) {
        return regionInfo.Name is "JP" or "JPN" ? ja : en;
    }
}
