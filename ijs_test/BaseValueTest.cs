using ijs.Internal;
using Xunit;

namespace ijs_test;

public class BaseValueTest {
    [Fact]
    public void ConstructorTest() {
        var x = new BaseValue(11);
        Assert.Equal("value=11", x.ToString());
    }
}
