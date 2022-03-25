namespace ijs; 

public interface IElements : IEquatable<IElements> {
    string Name { get; }
    string FullCode { get; }
    ElementsType ElementsType { get; }
    float BaseValue { get; }
}
