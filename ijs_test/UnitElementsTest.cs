using ijs;
using Xunit;

namespace ijs_test; 

public class UnitElementsTest {
    [Fact]
    public void ToStringTest() {
        var type = new SportsElementsType(SportsType.Single, ElementsType.Jump);
        var id = new ElementsId(ElementsCode._1T, ElementsLevel.None);
        var name = new ElementsName("1回転トウループ");
        var baseValue = new BaseValue(0.4F);
        var elm = new UnitElements(type, id, name, baseValue);
        Assert.Equal("Type=Jump(Single),Id=1T,Name=1回転トウループ,BaseValue=0.4", 
            elm.ToString());
    }
}
