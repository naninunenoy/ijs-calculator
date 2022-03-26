using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsLevelTest {
    [Fact]
    public void ToEnumStringTest() {
        Assert.Equal("B", ElementLevel.LvB.ToEnumString());
        Assert.Equal("1", ElementLevel.Lv1.ToEnumString());
        Assert.Equal("2", ElementLevel.Lv2.ToEnumString());
        Assert.Equal("3", ElementLevel.Lv3.ToEnumString());
        Assert.Equal("4", ElementLevel.Lv4.ToEnumString());
        Assert.Equal("", ElementLevel.None.ToEnumString());
    }
}
