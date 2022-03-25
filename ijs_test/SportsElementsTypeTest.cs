using ijs;
using Xunit;

namespace ijs_test; 

public class SportsElementsTypeTest {
    [Fact]
    public void ToStringTest() {
        var type = new SportsElementsType(SportsType.Single, ElementsType.Jump);
        Assert.Equal("Jump(Single)", type.ToString());
    }
}
