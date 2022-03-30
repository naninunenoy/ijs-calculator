using ijs.Internal;

namespace ijs; 

public static class ElementExtension {
    public static IElement ToSecondHalfElement(this IElement element) {
        return element.ElementType == ElementType.Jump ? new SecondHalfElement(element) : element;
    }

    public static (bool, double) IsSecondHalf(this IElement element) {
        return (element is SecondHalfElement, SecondHalfElement.Magnification);
    }
    
    public static IElement ToCombinationJump(this IEnumerable<IElement> jumps) {
        var combinationJump = new CombinationJump();
        combinationJump.Build(jumps.ToArray());
        return combinationJump;
    }
    
    public static IElement ToJumpSequence(this IEnumerable<IElement> jumps) {
        var jumpSequence = new JumpSequence();
        jumpSequence.Build(jumps.ToArray());
        return jumpSequence;
    }
}
