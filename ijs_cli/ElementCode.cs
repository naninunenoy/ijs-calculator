namespace ijs_cli; 

public class ElementCode {
    readonly string rawString;
    public ElementCode(string rawString) {
        this.rawString = rawString;
    }

    public bool IsContinuousJump(out ElementCode[] jumps) {
        var codes = rawString.Split("+");
        if (codes.Length == 0) {
            jumps = Array.Empty<ElementCode>();
            return false;
        }

        jumps = codes.Select(x => new ElementCode(x)).ToArray();
        return true;
    }

    public bool IsSecondHalf() {
        return rawString.ToLowerInvariant().LastOrDefault() == 'x';
    }

    public string LowerInvariantCode() => (IsSecondHalf() ? rawString.TrimEnd('x', 'X') : rawString).ToLowerInvariant();
    public string RawCode() => rawString;
}
