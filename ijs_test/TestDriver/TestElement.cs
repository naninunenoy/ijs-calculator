using System;
using ijs;

namespace ijs_test.TestDriver;

public class TestElement : IElement {
    public string Name { get; }
    public string FullCode { get; }
    public ElementType ElementType { get; }
    public double BaseValue { get; }

    public TestElement(string name, string fullCode, ElementType elementType, float baseValue) {
        Name = name;
        FullCode = fullCode;
        ElementType = elementType;
        BaseValue = baseValue;
    }

    public bool Equals(IElement? other) {
        return Name == other?.Name && 
               FullCode == other.FullCode && 
               ElementType == other.ElementType &&
               BaseValue.Equals(other.BaseValue);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElement)obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine(Name, FullCode, (int)ElementType, BaseValue);
    }
}
