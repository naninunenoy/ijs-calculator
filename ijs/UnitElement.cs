﻿namespace ijs; 

internal class UnitElement : IElement {
    internal ElementId Id { get; }
    readonly SportsElementType innerType;
    readonly ElementName innerName;
    readonly BaseValue innerBaseValue;
    
    internal UnitElement(SportsElementType type, ElementId id, ElementName name, BaseValue baseValue) {
        innerType = type;
        Id = id;
        innerName = name;
        innerBaseValue = baseValue;
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
    
    public string FullCode => Id.ToString();
    public double BaseValue => innerBaseValue.value;
    public string Name => Id.Level is ElementLevel.None ? innerName.jpn : $"{innerName.jpn}レベル{Id.Level.ToEnumString()}";
    public ElementType ElementType => innerType.ElementType;
}
