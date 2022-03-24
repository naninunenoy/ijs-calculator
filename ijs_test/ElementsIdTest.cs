using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsIdTest {
    [Fact]
    public void ToStringTest() {
        var id = new ElementsId(ElementsCode._1T, ElementsLevel.Lv1);
        Assert.Equal("1T1", id.ToString());
    }
}
