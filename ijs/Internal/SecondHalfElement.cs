namespace ijs.Internal;

internal class SecondHalfElement : IElement {
    public const double Magnification = 1.1F;
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
    public double BaseValue => element.BaseValue * Magnification;
}
