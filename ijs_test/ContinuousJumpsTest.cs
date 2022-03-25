using System;
using ijs;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test;

public class ContinuousJumpsTest {
    readonly IElements jump0 = new TestElements("ジャンプ0", "Jump0", ElementsType.Jump, 1F);
    readonly IElements jump1 = new TestElements("ジャンプ1", "Jump1", ElementsType.Jump, 10F);
    readonly IElements jump2 = new TestElements("ジャンプ2", "Jump2", ElementsType.Jump, 100F);
    readonly IElements jump3 = new TestElements("ジャンプ3", "Jump3", ElementsType.Jump, 1000F);
    readonly IElements spin = new TestElements("スピン", "Spin", ElementsType.Spin, 1F);

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
        Assert.Equal(ElementsType.Jump, emptyJumps.ElementsType);
    }
    
    [Fact]
    public void ParamsTest() {
        var jumps = new ContinuousJumps();
        jumps.Build(jump0, jump1, jump2);
        Assert.Equal("ジャンプ0+ジャンプ1+ジャンプ2", jumps.Name);
        Assert.Equal("Jump0+Jump1+Jump2", jumps.FullCode);
        Assert.Equal(111F, jumps.BaseValue);
        Assert.Equal(ElementsType.Jump, jumps.ElementsType);
    }
}
