namespace ijs; 

public class ElementList {
    List<IElement> list;
    public IReadOnlyList<IElement> List => list;

    public ElementList() {
        list = new List<IElement>();
    }
    
    public void Build(params IElement[] elements) {
        list = elements.ToList();
    }

    public double TotalBaseValue() => list.Select(x => x.BaseValue).Sum();
    public int TotalCount() => list.Count;
    public int SecondHalfCount() => list.Count(x => x is SecondHalfElement);
    public int JumpCount() => list.Count(x => x.ElementType is ElementType.Jump);
    public int SpinCount() => list.Count(x => x.ElementType is ElementType.Spin);
    public int StepSequenceCount() => list.Count(x => x.ElementType is ElementType.StepSequence);
    public int LiftCount() => list.Count(x => x.ElementType is ElementType.Lift);
    public int TwistLiftCount() => list.Count(x => x.ElementType is ElementType.TwistLift);
    public int ThrowJumpCount() => list.Count(x => x.ElementType is ElementType.ThrowJump);
    public int DeathSpiralCount() => list.Count(x => x.ElementType is ElementType.DeathSpiral);
    public int PatternDanceCount() => list.Count(x => x.ElementType is ElementType.PatternDance);
    public int TwizzleCount() => list.Count(x => x.ElementType is ElementType.Twizzle);
    public int ChoreographicElementsCount() => list.Count(x => x.ElementType is ElementType.ChoreographicElements);
}
