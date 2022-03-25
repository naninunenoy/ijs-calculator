namespace ijs; 

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
public readonly struct ElementsId : IEquatable<ElementsId> {
    public readonly ElementsCode Code;
    public readonly ElementsLevel Level;

    public ElementsId(ElementsCode code, ElementsLevel level = ElementsLevel.None) {
        Code = code;
        Level = level;
    }

    public bool Equals(ElementsId other) {
        return Code == other.Code && Level == other.Level;
    }

    public override bool Equals(object? obj) {
        return obj is ElementsId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)Code, (int)Level);
    }

    public override string ToString() {
        return $"{Code.ToEnumString()}{Level.ToEnumString()}";
    }

    public static bool operator ==(ElementsId left, ElementsId right) {
        return left.Equals(right);
    }

    public static bool operator !=(ElementsId left, ElementsId right) {
        return !(left == right);
    }
}
