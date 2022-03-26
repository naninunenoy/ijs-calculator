using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsCodeTest {
    [Fact]
    public void ToEnumStringTest() {
        Assert.Equal("1T", ElementCode._1T.ToEnumString());
    }
}
