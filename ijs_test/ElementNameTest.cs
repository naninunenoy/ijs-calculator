using System.Globalization;
using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class ElementNameTest {
    [Fact]
    public void GetNameOfTest() {
        var name = new ElementName("あいうえお", "ABCDE");
       Assert.Equal("あいうえお", name.GetNameOf(new RegionInfo("JP")));
       Assert.Equal("ABCDE", name.GetNameOf(new RegionInfo("US")));
       Assert.Equal("ABCDE", name.GetNameOf(new RegionInfo("CN")));
    }
}
