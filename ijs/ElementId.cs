namespace ijs; 

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
public readonly struct ElementId : IEquatable<ElementId> {
    public readonly ElementCode Code;
    public readonly ElementLevel Level;

    public ElementId(ElementCode code, ElementLevel level = ElementLevel.None) {
        Code = code;
        Level = level;
    }

    public bool Equals(ElementId other) {
        return Code == other.Code && Level == other.Level;
    }

    public override bool Equals(object? obj) {
        return obj is ElementId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Code, (int)Level);
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
