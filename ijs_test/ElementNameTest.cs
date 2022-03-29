using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class ElementNameTest {
    [Fact]
    public void ToStringTest() {
        var name = new ElementName("1回転トウループ");
        Assert.Equal("1回転トウループ", name.ToString());
    }
}
