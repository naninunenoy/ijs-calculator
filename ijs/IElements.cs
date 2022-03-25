namespace ijs; 

public interface IElements {
    string Name { get; }
    string FullCode { get; }
    UniqueElementsType ElementsType { get; }
    float BaseValue { get; }
}
