using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsNameTest {
    [Fact]
    public void ToStringTest() {
        var name = new ElementsName("1回転トウループ", "Single Toe loop jump");
        Assert.Equal("1回転トウループ(Single Toe loop jump)", name.ToString());
    }
}
