using ijs_cli;
using Xunit;

namespace ijs_cli_test;

public class ElementCodeTest {
    [Fact]
    public void IsCombinationTest() {
        var code = new ElementCode("hoge+fuga");
        var ret = code.IsCombination(out var combinationCode);
        Assert.True(ret);
        Assert.Equal(2, combinationCode.Length);
        Assert.Equal("hoge", combinationCode[0].RawCode());
        Assert.Equal("fuga", combinationCode[1].RawCode());
    }

    [Fact]
    public void IsCombinationTest_一つだと空が返却() {
        var code = new ElementCode("hoge");
        var ret = code.IsCombination(out var combinationCode);
        Assert.False(ret);
        Assert.Empty(combinationCode);
    }
    
    [Fact]
    public void IsCombinationTest_末尾にプラスがあってもカウントされない() {
        var code = new ElementCode("hoge+");
        var ret = code.IsCombination(out var combinationCode);
        Assert.False(ret);
        Assert.Empty(combinationCode);
    }
    
    [Fact]
    public void IsSecondHalfTest() {
        var isSecondHalf0 = new ElementCode("hoge").IsSecondHalf();
        Assert.False(isSecondHalf0);
        var isSecondHalf1 = new ElementCode("hogex").IsSecondHalf();
        Assert.True(isSecondHalf1);
    }
    
    [Fact]
    public void IsJumpSequenceCodeTest() {
        var isJumpSequence0 = new ElementCode("hoge").IsJumpSequenceCode();
        Assert.False(isJumpSequence0);
        var isJumpSequence1 = new ElementCode("SEQ").IsJumpSequenceCode();
        Assert.True(isJumpSequence1);
    }
    
    [Fact]
    public void LowerInvariantCodeTest() {
        var lower0 = new ElementCode("Hoge").LowerInvariantCode();
        Assert.Equal("hoge", lower0);
        var lower1 = new ElementCode("Hogex").LowerInvariantCode();
        Assert.Equal("hoge", lower1); // xは無視される
        var lower2 = new ElementCode("HogeX").LowerInvariantCode();
        Assert.Equal("hoge", lower2); // Hは無視される
    }
}
