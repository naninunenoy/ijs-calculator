namespace ijs_cli; 

public class ElementCode {
    readonly string rawString;
    public ElementCode(string rawString) {
        this.rawString = rawString;
    }

    public bool IsCombination(out ElementCode[] elementCodes) {
        var codes = rawString.Split("+", StringSplitOptions.RemoveEmptyEntries);
        // 「連続」ジャンプとは2回以上
        if (codes.Length < 2) {
            elementCodes = Array.Empty<ElementCode>();
            return false;
        }
        elementCodes = codes.Select(x => new ElementCode(x)).ToArray();
        return true;
    }

    public bool IsSecondHalf() {
        return rawString.ToLowerInvariant().LastOrDefault() == 'x';
    }

    public string LowerInvariantCode() => (IsSecondHalf() ? rawString.TrimEnd('x', 'X') : rawString).ToLowerInvariant();
    public string RawCode() => rawString;
}
