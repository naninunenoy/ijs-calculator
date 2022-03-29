using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class ElementLevelTest {
    [Fact]
    public void ToEnumStringTest() {
        Assert.Equal("B", ElementLevel.LvB.ToLevelString());
        Assert.Equal("1", ElementLevel.Lv1.ToLevelString());
        Assert.Equal("2", ElementLevel.Lv2.ToLevelString());
        Assert.Equal("3", ElementLevel.Lv3.ToLevelString());
        Assert.Equal("4", ElementLevel.Lv4.ToLevelString());
        Assert.Equal("", ElementLevel.None.ToLevelString());
    }
}
