using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsTest {
    [Fact]
    public void ToStringTest() {
        var id = new ElementsId(ElementsCode._1T, ElementsLevel.None);
        var name = new ElementsName("1回転トウループ");
        var elm = new Elements(ElementsType000.Jump, id, name, 0.40F);
        Assert.Equal("Type=Jump,Id=1T,Name=1回転トウループ,BaseValue=0.4", 
            elm.ToString());
    }
}