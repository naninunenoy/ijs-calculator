namespace ijs; 

public class ElementsList {
    List<IElements> list;
    public IReadOnlyList<IElements> List => list;

    public ElementsList() {
        list = new List<IElements>();
    }
    
    public ElementsList Build(params IElements[] elements) {
        list = elements.ToList();
        return this;
    }

    public float TotalBaseValue() => list.Select(x => x.BaseValue).Sum();
    public int JumpCount() => list.Count(x => x.ElementsType is ElementsType.Jump);
    public int SpinCount() => list.Count(x => x.ElementsType is ElementsType.Spin);
    public int StepSequenceCount() => list.Count(x => x.ElementsType is ElementsType.StepSequence);
    public int LiftCount() => list.Count(x => x.ElementsType is ElementsType.Lift);
    public int TwistLiftCount() => list.Count(x => x.ElementsType is ElementsType.TwistLift);
    public int ThrowJumpCount() => list.Count(x => x.ElementsType is ElementsType.ThrowJump);
    public int DeathSpiralCount() => list.Count(x => x.ElementsType is ElementsType.DeathSpiral);
    public int PatternDanceCount() => list.Count(x => x.ElementsType is ElementsType.PatternDance);
    public int TwizzleCount() => list.Count(x => x.ElementsType is ElementsType.Twizzle);
    public int ChoreographicElementsCount() => list.Count(x => x.ElementsType is ElementsType.ChoreographicElements);
}
