namespace ijs.Internal;

internal class SecondHalfElement : IElement {
    public const double Magnification = 1.1;

    public SecondHalfElement(IElement element) {
        OriginalElement = element;
    }

    public bool Equals(IElement? other) {
        return OriginalElement.Equals(other);
    }

    public string Name => OriginalElement.Name;
    public string FullCode => OriginalElement.FullCode;
    public ElementType ElementType => OriginalElement.ElementType;
    public double BaseValue => OriginalElement.ElementType == ElementType.Jump
        ? BaseValueRounder.MultipleBaseValue(OriginalElement.BaseValue, Magnification)
        : OriginalElement.BaseValue;
    public IElement OriginalElement { get; }
}
