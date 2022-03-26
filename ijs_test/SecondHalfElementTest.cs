using ijs;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test; 

public class SecondHalfElementTest {
    [Fact]
    public void MultipleTest() {
        var jump = new TestElement("ジャンプ", "Jump", ElementType.Jump, 10.0);
        var secondHalf = new SecondHalfElement(jump);
        Assert.Equal(11.0, secondHalf.BaseValue, 5);
    }
}
