namespace ijs.Internal; 

internal static class ElementTypeList {
    public static readonly SportsElementType SingleJump = new(SportsType.Single, ElementType.Jump);
    public static readonly SportsElementType SingleSpin = new(SportsType.Single, ElementType.Spin);
    public static readonly SportsElementType SingleStepSequence = new(SportsType.Single, ElementType.StepSequence);
    public static readonly SportsElementType PairJump = new(SportsType.Pair, ElementType.Jump);
    public static readonly SportsElementType PairStepSequence = new(SportsType.Pair, ElementType.StepSequence);
    public static readonly SportsElementType PairLift = new(SportsType.Pair, ElementType.Lift);
    public static readonly SportsElementType PairTwistLift = new(SportsType.Pair, ElementType.TwistLift);
    public static readonly SportsElementType PairThrowJump = new(SportsType.Pair, ElementType.ThrowJump);
    public static readonly SportsElementType PairDeathSpiral = new(SportsType.Pair, ElementType.DeathSpiral);
    public static readonly SportsElementType PairSpin = new(SportsType.Pair, ElementType.Spin);
    public static readonly SportsElementType IceDancePatternDance = new(SportsType.IceDance, ElementType.PatternDance);
    public static readonly SportsElementType IceDanceSpin = new(SportsType.IceDance, ElementType.Spin);
    public static readonly SportsElementType IceDanceLift = new(SportsType.IceDance, ElementType.Lift);
    public static readonly SportsElementType IceDanceTwizzle = new(SportsType.IceDance, ElementType.Twizzle);
    public static readonly SportsElementType IceDanceStepSequence = new(SportsType.IceDance, ElementType.StepSequence);
    public static readonly SportsElementType IceDanceChoreographicElement = new(SportsType.IceDance, ElementType.ChoreographicElements);
}
