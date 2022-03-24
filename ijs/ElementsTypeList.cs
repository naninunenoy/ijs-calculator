namespace ijs; 

public static class ElementsTypeList {
    public static readonly ElementType SingleJump = new(SportsType.Single, UniqueElementsType.Jump);
    public static readonly ElementType SingleSpin = new(SportsType.Single, UniqueElementsType.Spin);
    public static readonly ElementType SingleStepSequence = new(SportsType.Single, UniqueElementsType.StepSequence);
    public static readonly ElementType PairJump = new(SportsType.Pair, UniqueElementsType.Jump);
    public static readonly ElementType PairStepSequence = new(SportsType.Pair, UniqueElementsType.StepSequence);
    public static readonly ElementType PairLift = new(SportsType.Pair, UniqueElementsType.Lift);
    public static readonly ElementType PairTwistLift = new(SportsType.Pair, UniqueElementsType.TwistLift);
    public static readonly ElementType PairThrowJump = new(SportsType.Pair, UniqueElementsType.ThrowJump);
    public static readonly ElementType PairDeathSpiral = new(SportsType.Pair, UniqueElementsType.DeathSpiral);
    public static readonly ElementType PairSpin = new(SportsType.Pair, UniqueElementsType.Spin);
    public static readonly ElementType IceDancePatternDance = new(SportsType.IceDance, UniqueElementsType.PatternDance);
    public static readonly ElementType IceDanceSpin = new(SportsType.IceDance, UniqueElementsType.Spin);
    public static readonly ElementType IceDanceLift = new(SportsType.IceDance, UniqueElementsType.Lift);
    public static readonly ElementType IceDanceTwizzle = new(SportsType.IceDance, UniqueElementsType.Twizzle);
    public static readonly ElementType IceDanceStepSequence = new(SportsType.IceDance, UniqueElementsType.StepSequence);
    public static readonly ElementType IceDanceChoreographicElements = new(SportsType.IceDance, UniqueElementsType.ChoreographicElements);

    public static IEnumerable<ElementType> All() {
        yield return SingleJump;
        yield return SingleSpin;
        yield return SingleStepSequence;
        yield return PairJump;
        yield return PairStepSequence;
        yield return PairLift;
        yield return PairTwistLift;
        yield return PairThrowJump;
        yield return PairDeathSpiral;
        yield return PairSpin;
        yield return IceDancePatternDance;
        yield return IceDanceSpin;
        yield return IceDanceLift;
        yield return IceDanceTwizzle;
        yield return IceDanceStepSequence;
        yield return IceDanceChoreographicElements;
    }

    public static IEnumerable<ElementType> Single() => All().Where(x => x.sportsType == SportsType.Single);
    public static IEnumerable<ElementType> Pair() => All().Where(x => x.sportsType == SportsType.Pair);
    public static IEnumerable<ElementType> IceDance() => All().Where(x => x.sportsType == SportsType.IceDance);
}
