namespace ijs;

public class SecondHalfElement : IElement {
    public const float MultipleValue = 1.1F;
    readonly IElement element;

    public SecondHalfElement(IElement element) {
        this.element = element;
    }

    public bool Equals(IElement? other) {
        return element.Equals(other);
    }

    public string Name => element.Name;
    public string FullCode => element.FullCode;
    public ElementType ElementType => element.ElementType;
    public float BaseValue => element.BaseValue * MultipleValue;
}
