using System;
using ijs;

namespace ijs_test.TestDriver;

public class TestElements : IElements {
    public string Name { get; }
    public string FullCode { get; }
    public ElementsType ElementsType { get; }
    public float BaseValue { get; }

    public TestElements(string name, string fullCode, ElementsType elementsType, float baseValue) {
        Name = name;
        FullCode = fullCode;
        ElementsType = elementsType;
        BaseValue = baseValue;
    }

    public bool Equals(IElements? other) {
        return Name == other?.Name && 
               FullCode == other.FullCode && 
               ElementsType == other.ElementsType &&
               BaseValue.Equals(other.BaseValue);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElements)obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine(Name, FullCode, (int)ElementsType, BaseValue);
    }
}
