using ijs;
using ijs.Internal;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test;

public class ElementListTest {
    readonly IElement jump = new TestElement("ジャンプ", "Jump", ElementType.Jump, 1);
    readonly IElement spin = new TestElement("スピン", "Spin", ElementType.Spin, 10F);
    readonly IElement stepSequence = new TestElement("ステップシーケンス", "StepSequence", ElementType.StepSequence, 100F);
    readonly IElement lift = new TestElement("リフト", "Lift", ElementType.Lift, 1000F);
    readonly IElement twistLift = new TestElement("ツイストリフト", "TwistLift", ElementType.TwistLift, 10000F);
    readonly IElement throwJump = new TestElement("スロージャンプ", "ThrowJump", ElementType.ThrowJump, 100000F);
    readonly IElement deathSpiral = new TestElement("デススパイラル", "DeathSpiral", ElementType.DeathSpiral, 1000000F);
    readonly IElement patternDance = new TestElement("パターンダンス", "PatternDance", ElementType.PatternDance, 10000000F);
    readonly IElement twizzle = new TestElement("ツイズル", "Twizzle", ElementType.Twizzle, 100000000F);
    readonly IElement choreographicElement = new TestElement("コレオグラフィックエレメンツ", "ChoreographicElements", ElementType.ChoreographicElements, 1000000000F);
    
    [Fact]
    public void BuildTest() {
        var list = new ElementList();
        list.Build(jump, spin, stepSequence, lift, twistLift, throwJump, deathSpiral, patternDance, twizzle,
            choreographicElement);
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
        Assert.Equal(choreographicElement, list.List[9]);
    }

    [Fact]
    public void TotalCountTest() {
        var list = new ElementList();
        list.Build(jump, spin, stepSequence, lift, twistLift, throwJump, deathSpiral, patternDance, twizzle,
            choreographicElement);
        Assert.Equal(10, list.TotalCount());
    }
    
    [Fact]
    public void SecondHalfCountTest() {
        var list = new ElementList();
        var secondHalfJump = new SecondHalfElement(jump);
        list.Build(jump, secondHalfJump);
        Assert.Equal(1, list.SecondHalfCount());
    }
    
    [Fact]
    public void TotalBaseValueTest() {
        var list = new ElementList();
        list.Build(jump, spin, stepSequence, lift, twistLift, throwJump, deathSpiral, patternDance, twizzle,
            choreographicElement);
        var (value, str) = list.TotalBaseValue();
        Assert.Equal(1111111111.0, value);
        Assert.Equal("1111111111.00", str);
    }

    [Fact]
    public void JumpCountTest() {
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
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
        var list = new ElementList();
        list.Build(choreographicElement);
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

    [Fact]
    public void CombinationJumpCountTest() {
        var list = new ElementList();
        var combinationJump = new CombinationJump();
        combinationJump.Build(jump, jump);
        var jumpSequence = new JumpSequence();
        jumpSequence.Build(jump, jump);
        list.AddElement(combinationJump);
        list.AddElement(jumpSequence);
        Assert.Equal(2, list.CombinationJumpCount());
    }
    
    [Fact]
    public void CombinationJumpsCountTest() {
        var list = new ElementList();
        var combinationJump2 = new CombinationJump();
        combinationJump2.Build(jump, jump);
        var combinationJump3 = new CombinationJump();
        combinationJump3.Build(jump, jump, jump);
        list.AddElement(combinationJump2);
        list.AddElement(combinationJump3);
        Assert.Equal(1, list.Combination2JumpsCount());
        Assert.Equal(1, list.Combination3JumpsCount());
    }
}

internal static class ElementListTestExtension {
    public static void Build(this ElementList elementList, params IElement[] elements) {
        foreach (var element in elements) {
            elementList.AddElement(element);
        }
    }
}