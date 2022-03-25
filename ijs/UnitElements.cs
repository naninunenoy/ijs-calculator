namespace ijs; 

public class UnitElements : IElements, IEquatable<IElements> {
    public ElementsType Type { get; }
    public ElementsId Id { get; }
    public ElementsName Name { get; }
    public BaseValue BaseValue { get; }
    
    public UnitElements(ElementsType type, ElementsId id, ElementsName name, BaseValue baseValue) {
        Type = type;
        Id = id;
        Name = name;
        BaseValue = baseValue;
    }

    public override string ToString() {
        return $"Type={Type},Id={Id},Name={Name},BaseValue={BaseValue.value}";
    }

    public bool Equals(IElements? other) {
        // code(1AとかFCSp4とか)で同一エレメントかを判定
        var mine = Id.ToString().ToLowerInvariant();
        var his = other?.FullCode.ToLowerInvariant() ?? "";
        return mine.Equals(his);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElements)obj);
    }

    public override int GetHashCode() {
        return Id.GetHashCode();
    }
    
    string IElements.FullCode => Id.Code.ToEnumString();
    float IElements.BaseValue => BaseValue.value;
    string IElements.Name => Name.jpn;
}
