using ijs;
using Xunit;

namespace ijs_test; 

public class UnitElementTest {
    [Fact]
    public void ToStringTest() {
        var type = new SportsElementType(SportsType.Single, ElementType.Jump);
        var id = new ElementId(ElementCode._1T, ElementLevel.None);
        var name = new ElementName("1回転トウループ");
        var baseValue = new BaseValue(0.4);
        var elm = new UnitElement(type, id, name, baseValue);
        Assert.Equal("Type=Jump(Single),Id=1T,Name=1回転トウループ,BaseValue=0.4", 
            elm.ToString());
    }
}
