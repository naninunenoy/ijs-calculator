using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class ElementCodeSetTest {
    [Fact]
    public void SingleElementCodeToStringTest() {
        var x = new ElementCodeSet(SingleElementCode._1T);
        Assert.Equal("1T", x.ToString());
    }
    [Fact]
    public void PairElementCodeToStringTest() {
        var x = new ElementCodeSet(PairElementCode._1T);
        Assert.Equal("1T", x.ToString());
    }
    [Fact]
    public void IceDanceCodeToStringTest() {
        var x = new ElementCodeSet(IceDanceElementCode._1BL);
        Assert.Equal("1BL", x.ToString());
    }
}
