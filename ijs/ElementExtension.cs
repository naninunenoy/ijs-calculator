using ijs.Internal;

namespace ijs; 

public static class ElementExtension {
    public static IElement AsHalfSecondElement(this IElement element) {
        return element.ElementType == ElementType.Jump ? new SecondHalfElement(element) : element;
    }

    public static (bool, double) IsHalfSecond(this IElement element) {
        return (element is SecondHalfElement, SecondHalfElement.Magnification);
    }
    public static IElement AsCombinationJump(this IEnumerable<IElement> jumps) {
        var continuousJumps = new CombinationJump();
        continuousJumps.Build(jumps.ToArray());
        return continuousJumps;
    }
}
