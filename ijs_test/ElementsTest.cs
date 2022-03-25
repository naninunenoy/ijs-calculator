using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsTest {
    [Fact]
    public void ToStringTest() {
        var type = ElementsTypeList.SingleJump;
        var id = new ElementsId(ElementsCode._1T, ElementsLevel.None);
        var name = new ElementsName("1回転トウループ");
        var baseValue = new BaseValue(0.4F);
        var elm = new Elements(type, id, name, baseValue);
        Assert.Equal("Type=Jump(Single),Id=1T,Name=1回転トウループ,BaseValue=0.4", 
            elm.ToString());
    }
}