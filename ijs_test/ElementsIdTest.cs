using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsIdTest {
    [Fact]
    public void ToStringTest() {
        var id = new ElementId(ElementCode._1T, ElementLevel.Lv1);
        Assert.Equal("1T1", id.ToString());
    }
}
