using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsNameTest {
    [Fact]
    public void ToStringTest() {
        var name = new ElementName("1回転トウループ");
        Assert.Equal("1回転トウループ", name.ToString());
    }
}
