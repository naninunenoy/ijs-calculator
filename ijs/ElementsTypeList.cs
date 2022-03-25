namespace ijs; 

public static class ElementsTypeList {
    public static readonly ElementsType SingleJump = new(SportsType.Single, UniqueElementsType.Jump);
    public static readonly ElementsType SingleSpin = new(SportsType.Single, UniqueElementsType.Spin);
    public static readonly ElementsType SingleStepSequence = new(SportsType.Single, UniqueElementsType.StepSequence);
    public static readonly ElementsType PairJump = new(SportsType.Pair, UniqueElementsType.Jump);
    public static readonly ElementsType PairStepSequence = new(SportsType.Pair, UniqueElementsType.StepSequence);
    public static readonly ElementsType PairLift = new(SportsType.Pair, UniqueElementsType.Lift);
    public static readonly ElementsType PairTwistLift = new(SportsType.Pair, UniqueElementsType.TwistLift);
    public static readonly ElementsType PairThrowJump = new(SportsType.Pair, UniqueElementsType.ThrowJump);
    public static readonly ElementsType PairDeathSpiral = new(SportsType.Pair, UniqueElementsType.DeathSpiral);
    public static readonly ElementsType PairSpin = new(SportsType.Pair, UniqueElementsType.Spin);
    public static readonly ElementsType IceDancePatternDance = new(SportsType.IceDance, UniqueElementsType.PatternDance);
    public static readonly ElementsType IceDanceSpin = new(SportsType.IceDance, UniqueElementsType.Spin);
    public static readonly ElementsType IceDanceLift = new(SportsType.IceDance, UniqueElementsType.Lift);
    public static readonly ElementsType IceDanceTwizzle = new(SportsType.IceDance, UniqueElementsType.Twizzle);
    public static readonly ElementsType IceDanceStepSequence = new(SportsType.IceDance, UniqueElementsType.StepSequence);
    public static readonly ElementsType IceDanceChoreographicElements = new(SportsType.IceDance, UniqueElementsType.ChoreographicElements);

    public static IEnumerable<ElementsType> All() {
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

    public static IEnumerable<ElementsType> Single() => All().Where(x => x.sportsType == SportsType.Single);
    public static IEnumerable<ElementsType> Pair() => All().Where(x => x.sportsType == SportsType.Pair);
    public static IEnumerable<ElementsType> IceDance() => All().Where(x => x.sportsType == SportsType.IceDance);
}
