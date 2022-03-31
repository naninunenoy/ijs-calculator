using ijs;
using ijs.Internal;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test; 

public class SecondHalfElementTest {
    [Fact]
    public void JumpBaseValueTest() {
        var jump = new TestElement("ジャンプ", "Jump", ElementType.Jump, 10.0);
        var secondHalf = new SecondHalfElement(jump);
        Assert.Equal(11.0, secondHalf.BaseValue);
    }
    [Fact]
    public void NotJumpBaseValueTest() {
        var jump = new TestElement("スピン", "Spin", ElementType.Spin, 10.0);
        var secondHalf = new SecondHalfElement(jump);
        Assert.Equal(10.0, secondHalf.BaseValue);
    }
}
