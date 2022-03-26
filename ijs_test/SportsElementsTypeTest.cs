using ijs;
using Xunit;

namespace ijs_test; 

public class SportsElementsTypeTest {
    [Fact]
    public void ToStringTest() {
        var type = new SportsElementType(SportsType.Single, ElementType.Jump);
        Assert.Equal("Jump(Single)", type.ToString());
    }
}
