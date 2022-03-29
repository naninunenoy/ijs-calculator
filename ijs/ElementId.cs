namespace ijs;

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
internal readonly struct ElementId : IEquatable<ElementId> {
    ElementCodeSet Code { get; }
    readonly ElementLevel level;

    internal ElementId(SingleElementCode code, ElementLevel level = ElementLevel.None) {
        this.level = level;
        Code = new ElementCodeSet(code);
    }

    internal ElementId(PairElementCode code, ElementLevel level = ElementLevel.None) {
        this.level = level;
        Code = new ElementCodeSet(code);
    }

    internal ElementId(IceDanceElementCode code, ElementLevel level = ElementLevel.None) {
        this.level = level;
        Code = new ElementCodeSet(code);
    }
    
    public bool Equals(ElementId other) {
        return level == other.level && Code.Equals(other.Code);
    }

    public override bool Equals(object? obj) {
        return obj is ElementId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)level, Code);
    }
    
    public override string ToString() {
        return $"{Code}{level.ToEnumString()}";
    }

    public static bool operator ==(ElementId left, ElementId right) {
        return left.Equals(right);
    }

    public static bool operator !=(ElementId left, ElementId right) {
        return !(left == right);
    }
}
