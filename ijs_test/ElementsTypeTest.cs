using ijs;
using Xunit;

namespace ijs_test;

public class ElementsTypeTest {
    [Fact]
    public void ToStringTest() {
        Assert.Equal("Jump(Single)", ElementsTypeList.SingleJump.ToString());
    }
}
