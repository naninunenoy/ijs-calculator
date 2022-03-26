namespace ijs; 

public class UnitElement : IElement {
    SportsElementType Type { get; }
    public ElementId Id { get; }
    public ElementName Name { get; }
    public BaseValue BaseValue { get; }
    
    internal UnitElement(SportsElementType type, ElementId id, ElementName name, BaseValue baseValue) {
        Type = type;
        Id = id;
        Name = name;
        BaseValue = baseValue;
    }

    public override string ToString() {
        return $"Type={Type},Id={Id},Name={Name},BaseValue={BaseValue.value}";
    }

    public bool Equals(IElement? other) {
        // code(1AとかFCSp4とか)で同一エレメントかを判定
        var mine = Id.ToString().ToLowerInvariant();
        var his = other?.FullCode.ToLowerInvariant() ?? "";
        return mine.Equals(his);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElement)obj);
    }

    public override int GetHashCode() {
        return Id.GetHashCode();
    }
    
    string IElement.FullCode => Id.Code.ToEnumString();
    double IElement.BaseValue => BaseValue.value;
    string IElement.Name => Name.jpn;
    ElementType IElement.ElementType => Type.ElementType;
}
