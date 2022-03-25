namespace ijs; 

public class Elements : IEquatable<Elements> {
    public ElementsType Type { get; }
    public ElementsId Id { get; }
    public ElementsName Name { get; }
    public BaseValue BaseValue { get; }
    
    public Elements(ElementsType type, ElementsId id, ElementsName name, BaseValue baseValue) {
        Type = type;
        Id = id;
        Name = name;
        BaseValue = baseValue;
    }

    public bool Equals(Elements? other) {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Elements)obj);
    }

    public override int GetHashCode() {
        return Id.GetHashCode();
    }

    public override string ToString() {
        return $"Type={Type},Id={Id},Name={Name},BaseValue={BaseValue.value}";
    }
}
