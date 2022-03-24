using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsLevelTest {
    [Fact]
    public void ToEnumStringTest() {
        Assert.Equal("B", ElementsLevel.LvB.ToEnumString());
        Assert.Equal("1", ElementsLevel.Lv1.ToEnumString());
        Assert.Equal("2", ElementsLevel.Lv2.ToEnumString());
        Assert.Equal("3", ElementsLevel.Lv3.ToEnumString());
        Assert.Equal("4", ElementsLevel.Lv4.ToEnumString());
        Assert.Equal("", ElementsLevel.None.ToEnumString());
    }
}
