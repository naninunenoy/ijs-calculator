using ijs;

namespace ijs_cli; 

public class UnknownElement : IElement {
    public UnknownElement(string rawCode) {
        FullCode = rawCode;
    }
    public string Name => "<!> 不明なエレメントです";
    public string FullCode { get; }
    public ElementType ElementType => ElementType.Jump; // Unknownが無いのでJumpにしとく
    public double BaseValue => 0;

    public bool Equals(IElement? other) {
        return FullCode == other?.FullCode;
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((UnknownElement)obj);
    }

    public override int GetHashCode() {
        return FullCode.GetHashCode();
    }
}
