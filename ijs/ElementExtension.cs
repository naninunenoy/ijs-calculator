using ijs.Internal;

namespace ijs; 

public static class ElementExtension {
    public static IElement AsHalfSecondElement(this IElement element) {
        return new SecondHalfElement(element);
    }

    public static (bool, double) IsHalfSecond(this IElement element) {
        return (element is SecondHalfElement, SecondHalfElement.Magnification);
    }
    public static IElement AsContinuousJumps(this IEnumerable<IElement> jumps) {
        var continuousJumps = new ContinuousJumps();
        continuousJumps.Build(jumps.ToArray());
        return continuousJumps;
    }
}
