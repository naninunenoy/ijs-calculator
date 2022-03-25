using ijs;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test; 

public class ElementsListTest {
    readonly IElements jump = new TestElements("ジャンプ", "Jump", ElementsType.Jump, 1F);
    readonly IElements spin = new TestElements("スピン", "Spin", ElementsType.Spin, 10F);
    readonly IElements stepSequence = new TestElements("ステップシーケンス", "StepSequence", ElementsType.StepSequence, 100F);
    readonly IElements lift = new TestElements("リフト", "Lift", ElementsType.Lift, 1000F);
    readonly IElements twistLift = new TestElements("ツイストリフト", "TwistLift", ElementsType.TwistLift, 10000F);
    readonly IElements throwJump = new TestElements("スロージャンプ", "ThrowJump", ElementsType.ThrowJump, 100000F);
    readonly IElements deathSpiral = new TestElements("デススパイラル", "DeathSpiral", ElementsType.DeathSpiral, 1000000F);
    readonly IElements patternDance = new TestElements("パターンダンス", "PatternDance", ElementsType.PatternDance, 10000000F);
    readonly IElements twizzle = new TestElements("ツイズル", "Twizzle", ElementsType.Twizzle, 100000000F);
    readonly IElements choreographicElements = new TestElements("コレオグラフィックエレメンツ", "ChoreographicElements", ElementsType.ChoreographicElements, 1000000000F);
    
    [Fact]
    public void BuildTest() {
        var list = new ElementsList();
        list.Build(jump, spin, stepSequence, lift, twistLift, throwJump, deathSpiral, patternDance, twizzle,
            choreographicElements);
        Assert.Equal(10, list.List.Count);
        Assert.Equal(jump, list.List[0]);
        Assert.Equal(spin, list.List[1]);
        Assert.Equal(stepSequence, list.List[2]);
        Assert.Equal(lift, list.List[3]);
        Assert.Equal(twistLift, list.List[4]);
        Assert.Equal(throwJump, list.List[5]);
        Assert.Equal(deathSpiral, list.List[6]);
        Assert.Equal(patternDance, list.List[7]);
        Assert.Equal(twizzle, list.List[8]);
        Assert.Equal(choreographicElements, list.List[9]);
    }

    [Fact]
    public void TotalBaseValueTest() {
        var list = new ElementsList();
        list.Build(jump, spin, stepSequence, lift, twistLift, throwJump, deathSpiral, patternDance, twizzle,
            choreographicElements);
        Assert.Equal(1111111111F, list.TotalBaseValue());
    }

    [Fact]
    public void JumpCountTest() {
        var list = new ElementsList();
        list.Build(jump);
        Assert.Equal(1, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void SpinCountTest() {
        var list = new ElementsList();
        list.Build(spin);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(1, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void StepSequenceCountTest() {
        var list = new ElementsList();
        list.Build(stepSequence);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(1, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void LiftCountTest() {
        var list = new ElementsList();
        list.Build(lift);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(1, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void TwistLiftCountTest() {
        var list = new ElementsList();
        list.Build(twistLift);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(1, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void ThrowJumpCountTest() {
        var list = new ElementsList();
        list.Build(throwJump);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(1, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void DeathSpiralCountTest() {
        var list = new ElementsList();
        list.Build(deathSpiral);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(1, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void PatternDanceCountTest() {
        var list = new ElementsList();
        list.Build(patternDance);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(1, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void TwizzleCountTest() {
        var list = new ElementsList();
        list.Build(twizzle);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(1, list.TwizzleCount());
        Assert.Equal(0, list.ChoreographicElementsCount());
    }
    
    [Fact]
    public void ChoreographicElementsCountTest() {
        var list = new ElementsList();
        list.Build(choreographicElements);
        Assert.Equal(0, list.JumpCount());
        Assert.Equal(0, list.SpinCount());
        Assert.Equal(0, list.StepSequenceCount());
        Assert.Equal(0, list.LiftCount());
        Assert.Equal(0, list.TwistLiftCount());
        Assert.Equal(0, list.ThrowJumpCount());
        Assert.Equal(0, list.DeathSpiralCount());
        Assert.Equal(0, list.PatternDanceCount());
        Assert.Equal(0, list.TwizzleCount());
        Assert.Equal(1, list.ChoreographicElementsCount());
    }
}
