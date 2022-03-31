namespace ijs.Internal;

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
internal readonly struct ElementId : IEquatable<ElementId> {
    internal ElementCodeSet Code { get; }
    internal readonly ElementLevel Level;

    internal ElementId(SingleElementCode code, ElementLevel level = ElementLevel.None) {
        Level = level;
        Code = new ElementCodeSet(code);
    }

    internal ElementId(PairElementCode code, ElementLevel level = ElementLevel.None) {
        Level = level;
        Code = new ElementCodeSet(code);
    }

    internal ElementId(IceDanceElementCode code, ElementLevel level = ElementLevel.None) {
        Level = level;
        Code = new ElementCodeSet(code);
    }
    
    public bool Equals(ElementId other) {
        return Level == other.Level && Code.Equals(other.Code);
    }

    public override bool Equals(object? obj) {
        return obj is ElementId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Level, Code);
    }
    
    public override string ToString() {
        return $"{Code}{Level.ToEnumString()}";
    }

    public static bool operator ==(ElementId left, ElementId right) {
        return left.Equals(right);
    }

    public static bool operator !=(ElementId left, ElementId right) {
        return !(left == right);
    }
}
