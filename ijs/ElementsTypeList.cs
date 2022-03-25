namespace ijs; 

internal static class ElementsTypeList {
    static readonly ElementsType SingleJump = new(SportsType.Single, UniqueElementsType.Jump);
    static readonly ElementsType SingleSpin = new(SportsType.Single, UniqueElementsType.Spin);
    static readonly ElementsType SingleStepSequence = new(SportsType.Single, UniqueElementsType.StepSequence);
    static readonly ElementsType PairJump = new(SportsType.Pair, UniqueElementsType.Jump);
    static readonly ElementsType PairStepSequence = new(SportsType.Pair, UniqueElementsType.StepSequence);
    static readonly ElementsType PairLift = new(SportsType.Pair, UniqueElementsType.Lift);
    static readonly ElementsType PairTwistLift = new(SportsType.Pair, UniqueElementsType.TwistLift);
    static readonly ElementsType PairThrowJump = new(SportsType.Pair, UniqueElementsType.ThrowJump);
    static readonly ElementsType PairDeathSpiral = new(SportsType.Pair, UniqueElementsType.DeathSpiral);
    static readonly ElementsType PairSpin = new(SportsType.Pair, UniqueElementsType.Spin);
    static readonly ElementsType IceDancePatternDance = new(SportsType.IceDance, UniqueElementsType.PatternDance);
    static readonly ElementsType IceDanceSpin = new(SportsType.IceDance, UniqueElementsType.Spin);
    static readonly ElementsType IceDanceLift = new(SportsType.IceDance, UniqueElementsType.Lift);
    static readonly ElementsType IceDanceTwizzle = new(SportsType.IceDance, UniqueElementsType.Twizzle);
    static readonly ElementsType IceDanceStepSequence = new(SportsType.IceDance, UniqueElementsType.StepSequence);
    static readonly ElementsType IceDanceChoreographicElements = new(SportsType.IceDance, UniqueElementsType.ChoreographicElements);

    static IEnumerable<ElementsType> All() {
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

    public static IEnumerable<ElementsType> Single() => All().Where(x => x.SportsType == SportsType.Single);
    public static IEnumerable<ElementsType> Pair() => All().Where(x => x.SportsType == SportsType.Pair);
    public static IEnumerable<ElementsType> IceDance() => All().Where(x => x.SportsType == SportsType.IceDance);
}
