namespace ijs; 

internal static class ElementsTypeList {
    static readonly SportsElementsType SingleJump = new(SportsType.Single, ElementsType.Jump);
    static readonly SportsElementsType SingleSpin = new(SportsType.Single, ElementsType.Spin);
    static readonly SportsElementsType SingleStepSequence = new(SportsType.Single, ElementsType.StepSequence);
    static readonly SportsElementsType PairJump = new(SportsType.Pair, ElementsType.Jump);
    static readonly SportsElementsType PairStepSequence = new(SportsType.Pair, ElementsType.StepSequence);
    static readonly SportsElementsType PairLift = new(SportsType.Pair, ElementsType.Lift);
    static readonly SportsElementsType PairTwistLift = new(SportsType.Pair, ElementsType.TwistLift);
    static readonly SportsElementsType PairThrowJump = new(SportsType.Pair, ElementsType.ThrowJump);
    static readonly SportsElementsType PairDeathSpiral = new(SportsType.Pair, ElementsType.DeathSpiral);
    static readonly SportsElementsType PairSpin = new(SportsType.Pair, ElementsType.Spin);
    static readonly SportsElementsType IceDancePatternDance = new(SportsType.IceDance, ElementsType.PatternDance);
    static readonly SportsElementsType IceDanceSpin = new(SportsType.IceDance, ElementsType.Spin);
    static readonly SportsElementsType IceDanceLift = new(SportsType.IceDance, ElementsType.Lift);
    static readonly SportsElementsType IceDanceTwizzle = new(SportsType.IceDance, ElementsType.Twizzle);
    static readonly SportsElementsType IceDanceStepSequence = new(SportsType.IceDance, ElementsType.StepSequence);
    static readonly SportsElementsType IceDanceChoreographicElements = new(SportsType.IceDance, ElementsType.ChoreographicElements);

    static IEnumerable<SportsElementsType> All() {
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

    public static IEnumerable<SportsElementsType> Single() => All().Where(x => x.SportsType == SportsType.Single);
    public static IEnumerable<SportsElementsType> Pair() => All().Where(x => x.SportsType == SportsType.Pair);
    public static IEnumerable<SportsElementsType> IceDance() => All().Where(x => x.SportsType == SportsType.IceDance);
}
