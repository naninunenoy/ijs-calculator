namespace ijs;

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
public readonly struct ElementId : IEquatable<ElementId> {
    internal readonly ElementCode Code;
    internal readonly ElementLevel Level;
    ElementCodeSet elementCodeSet { get; }

    internal ElementId(ElementCode code, ElementLevel level = ElementLevel.None) {
        Code = code;
        Level = level;
        elementCodeSet = new ElementCodeSet();
    }

    internal ElementId(SingleElementCode code, ElementLevel level = ElementLevel.None) {
        Code = ElementCode._1T; //消す
        Level = level;
        elementCodeSet = new ElementCodeSet(code);
    }

    internal ElementId(PairElementCode code, ElementLevel level = ElementLevel.None) {
        Code = ElementCode._1T; //消す
        Level = level;
        elementCodeSet = new ElementCodeSet(code);
    }

    internal ElementId(IceDanceElementCode code, ElementLevel level = ElementLevel.None) {
        Code = ElementCode._1T; //消す
        Level = level;
        elementCodeSet = new ElementCodeSet(code);
    }

    public bool Equals(ElementId other) {
        return Code == other.Code && Level == other.Level && elementCodeSet.Equals(other.elementCodeSet);
    }

    public override bool Equals(object? obj) {
        return obj is ElementId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Code, (int)Level, elementCodeSet);
    }
    
    public override string ToString() {
        return $"{Code.ToEnumString()}{Level.ToEnumString()}";
    }

    public static bool operator ==(ElementId left, ElementId right) {
        return left.Equals(right);
    }

    public static bool operator !=(ElementId left, ElementId right) {
        return !(left == right);
    }
}
