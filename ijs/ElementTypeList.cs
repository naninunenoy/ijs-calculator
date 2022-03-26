namespace ijs; 

internal static class ElementTypeList {
    static readonly SportsElementType SingleJump = new(SportsType.Single, ElementType.Jump);
    static readonly SportsElementType SingleSpin = new(SportsType.Single, ElementType.Spin);
    static readonly SportsElementType SingleStepSequence = new(SportsType.Single, ElementType.StepSequence);
    static readonly SportsElementType PairJump = new(SportsType.Pair, ElementType.Jump);
    static readonly SportsElementType PairStepSequence = new(SportsType.Pair, ElementType.StepSequence);
    static readonly SportsElementType PairLift = new(SportsType.Pair, ElementType.Lift);
    static readonly SportsElementType PairTwistLift = new(SportsType.Pair, ElementType.TwistLift);
    static readonly SportsElementType PairThrowJump = new(SportsType.Pair, ElementType.ThrowJump);
    static readonly SportsElementType PairDeathSpiral = new(SportsType.Pair, ElementType.DeathSpiral);
    static readonly SportsElementType PairSpin = new(SportsType.Pair, ElementType.Spin);
    static readonly SportsElementType IceDancePatternDance = new(SportsType.IceDance, ElementType.PatternDance);
    static readonly SportsElementType IceDanceSpin = new(SportsType.IceDance, ElementType.Spin);
    static readonly SportsElementType IceDanceLift = new(SportsType.IceDance, ElementType.Lift);
    static readonly SportsElementType IceDanceTwizzle = new(SportsType.IceDance, ElementType.Twizzle);
    static readonly SportsElementType IceDanceStepSequence = new(SportsType.IceDance, ElementType.StepSequence);
    static readonly SportsElementType IceDanceChoreographicElement = new(SportsType.IceDance, ElementType.ChoreographicElements);

    static IEnumerable<SportsElementType> All() {
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
        yield return IceDanceChoreographicElement;
    }

    public static IEnumerable<SportsElementType> Single() => All().Where(x => x.SportsType == SportsType.Single);
    public static IEnumerable<SportsElementType> Pair() => All().Where(x => x.SportsType == SportsType.Pair);
    public static IEnumerable<SportsElementType> IceDance() => All().Where(x => x.SportsType == SportsType.IceDance);
}
