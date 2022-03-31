using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class ElementIdTest {
    [Fact]
    public void ToStringWithoutLevelTest() {
        var id = new ElementId(SingleElementCode._1T, ElementLevel.None);
        Assert.Equal("1T", id.ToString());
    }
    [Fact]
    public void ToStringWithLevelTest() {
        var id = new ElementId(SingleElementCode._1T, ElementLevel.Lv1);
        Assert.Equal("1T1", id.ToString());
    }
}
