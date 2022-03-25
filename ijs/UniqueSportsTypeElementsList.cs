namespace ijs; 

public class UniqueSportsTypeElementsList {
    List<UnitElements> list;
    public IReadOnlyList<UnitElements> List => list;

    public UniqueSportsTypeElementsList() {
        list = new List<UnitElements>();
    }

    public UniqueSportsTypeElementsList Build(params UnitElements[] elements) {
        // 異なる種別のエレメンツが入っていた場合(シングルとアイスダンスが混ざっているなど)例外
        var sportsTypeHash = new HashSet<SportsType>(elements.Select(x => x.Type.SportsType));
        if (sportsTypeHash.Count != 1) {
            throw new ArgumentException("異なる競技種別のエレメンツが含まれています");
        }

        list = elements.ToList();
        return this;
    }

    public float TotalBaseValue() => list.Select(x => x.BaseValue.value).Sum();
    public int JumpCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.Jump);
    public int SpinCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.Spin);
    public int StepSequenceCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.StepSequence);
    public int LiftCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.Lift);
    public int TwistLiftCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.TwistLift);
    public int ThrowJumpCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.ThrowJump);
    public int DeathSpiralCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.DeathSpiral);
    public int PatternDanceCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.PatternDance);
    public int TwizzleCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.Twizzle);
    public int ChoreographicElementsCount() => list.Count(x => x.Type.UniqueElementsType is UniqueElementsType.ChoreographicElements);
}
