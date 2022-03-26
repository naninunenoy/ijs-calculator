using System;
using ijs;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test;

public class ContinuousJumpsTest {
    readonly IElement jump0 = new TestElement("ジャンプ0", "Jump0", ElementType.Jump, 1F);
    readonly IElement jump1 = new TestElement("ジャンプ1", "Jump1", ElementType.Jump, 10F);
    readonly IElement jump2 = new TestElement("ジャンプ2", "Jump2", ElementType.Jump, 100F);
    readonly IElement jump3 = new TestElement("ジャンプ3", "Jump3", ElementType.Jump, 1000F);
    readonly IElement spin = new TestElement("スピン", "Spin", ElementType.Spin, 1F);

    [Fact]
    public void BuildTest_ジャンプでないエレメンツが含まれています() {
        var jumps = new ContinuousJumps();
        var ex = Assert.Throws<ArgumentException>(() => { jumps.Build(spin); });
        Assert.Equal("ジャンプでないエレメンツが含まれています", ex.Message);
    }

    [Fact]
    public void BuildTest_連続ジャンプは最高3回です() {
        var jumps = new ContinuousJumps();
        var ex = Assert.Throws<ArgumentException>(() => { jumps.Build(jump0, jump1, jump2, jump3); });
        Assert.Equal("連続ジャンプは最高3回です", ex.Message);
    }
    
    [Fact]
    public void EmptyTest() {
        var emptyJumps = new ContinuousJumps();
        Assert.Equal("", emptyJumps.Name);
        Assert.Equal("", emptyJumps.FullCode);
        Assert.Equal(0F, emptyJumps.BaseValue);
        Assert.Equal(ElementType.Jump, emptyJumps.ElementType);
    }
    
    [Fact]
    public void ParamsTest() {
        var jumps = new ContinuousJumps();
        jumps.Build(jump0, jump1, jump2);
        Assert.Equal("ジャンプ0+ジャンプ1+ジャンプ2", jumps.Name);
        Assert.Equal("Jump0+Jump1+Jump2", jumps.FullCode);
        Assert.Equal(111F, jumps.BaseValue);
        Assert.Equal(ElementType.Jump, jumps.ElementType);
    }
}
