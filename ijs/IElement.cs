namespace ijs; 

public interface IElement : IEquatable<IElement> {
    string Name { get; }
    string FullCode { get; }
    ElementType ElementType { get; }
    float BaseValue { get; }
}
