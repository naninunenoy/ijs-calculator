namespace ijs; 

/// <summary>
/// エレメンツを一意に決定できる情報
/// 記号とレベルからなる
/// </summary>
public readonly struct ElementsId : IEquatable<ElementsId> {
    public readonly ElementsCode code;
    public readonly ElementsLevel level;

    public ElementsId(ElementsCode code, ElementsLevel level) {
        this.code = code;
        this.level = level;
    }

    public bool Equals(ElementsId other) {
        return code == other.code && level == other.level;
    }

    public override bool Equals(object? obj) {
        return obj is ElementsId other && Equals(other);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)code, (int)level);
    }

    public override string ToString() {
        return $"{code.ToEnumString()}{level.ToEnumString()}";
    }
}
