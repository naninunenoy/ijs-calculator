using ijs.Internal;

namespace ijs; 

public static class ElementExtension {
    public static IElement ToHalfSecondElement(IElement element) {
        return new SecondHalfElement(element);
    }

    public static (bool, double) IsHalfSecond(this IElement element) {
        return (element is SecondHalfElement, SecondHalfElement.Magnification);
    }
    public static IElement CreateAsContinuousJumps(params IElement[] jumps) {
        var continuousJumps = new ContinuousJumps();
        continuousJumps.Build(jumps);
        return continuousJumps;
    }
}
