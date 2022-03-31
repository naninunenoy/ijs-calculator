using System.Globalization;
using ijs;
using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class UnitElementTest {
    [Fact]
    public void ToStringTest() {
        var type = new SportsElementType(SportsType.Single, ElementType.Jump);
        var id = new ElementId(SingleElementCode._1T, ElementLevel.None);
        var name = new ElementName("1回転トウループ", "single toe loop");
        var baseValue = new BaseValue(0.4);
        var elm = new UnitElement(type, id, name, baseValue) { RegionInfo = new RegionInfo("JP") };
        Assert.Equal("1T", elm.FullCode);
        Assert.Equal(0.4, elm.BaseValue);
        Assert.Equal("1回転トウループ", elm.Name);
        Assert.Equal(ElementType.Jump, elm.ElementType);
    }
}
