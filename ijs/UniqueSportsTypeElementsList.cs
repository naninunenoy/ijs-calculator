namespace ijs; 

public class UniqueSportsTypeElementsList {
    List<IElements> list;
    public IReadOnlyList<IElements> List => list;

    public UniqueSportsTypeElementsList() {
        list = new List<IElements>();
    }
    
    public UniqueSportsTypeElementsList Build(params IElements[] elements) {
        list = elements.ToList();
        return this;
    }

    public float TotalBaseValue() => list.Select(x => x.BaseValue).Sum();
    public int JumpCount() => list.Count(x => x.ElementsType is UniqueElementsType.Jump);
    public int SpinCount() => list.Count(x => x.ElementsType is UniqueElementsType.Spin);
    public int StepSequenceCount() => list.Count(x => x.ElementsType is UniqueElementsType.StepSequence);
    public int LiftCount() => list.Count(x => x.ElementsType is UniqueElementsType.Lift);
    public int TwistLiftCount() => list.Count(x => x.ElementsType is UniqueElementsType.TwistLift);
    public int ThrowJumpCount() => list.Count(x => x.ElementsType is UniqueElementsType.ThrowJump);
    public int DeathSpiralCount() => list.Count(x => x.ElementsType is UniqueElementsType.DeathSpiral);
    public int PatternDanceCount() => list.Count(x => x.ElementsType is UniqueElementsType.PatternDance);
    public int TwizzleCount() => list.Count(x => x.ElementsType is UniqueElementsType.Twizzle);
    public int ChoreographicElementsCount() => list.Count(x => x.ElementsType is UniqueElementsType.ChoreographicElements);
}
