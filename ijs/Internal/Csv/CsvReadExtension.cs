namespace ijs.Internal; 

internal static class CsvReadExtension {
    public static bool TryGetBaseValue(this CsvDict dict, string code, out BaseValue baseValue) {
        if (dict.TryGetValue(code, "base", out double score)) {
            baseValue = new BaseValue(score);
            return true;
        }
        baseValue = default;
        return false;
    }
}
