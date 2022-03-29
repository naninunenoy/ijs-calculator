namespace ijs.Csv; 

internal static class CsvReadExtension {
    public static bool TryGetBaseValue(this CsvDict dict, string code, out BaseValue baseValue) {
        if (dict.TryGetValue(code, "baseValue", out double score)) {
            baseValue = new BaseValue(score);
            return true;
        }
        baseValue = default;
        return false;
    }
    public static bool TryGetElementName(this CsvDict dict, string code, out ElementName elementName) {
        if (dict.TryGetValue(code, "name", out string name)) {
            elementName = new ElementName(name);
            return true;
        }
        elementName = default;
        return false;
    }
}
