using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsTest {
    [Fact]
    public void ToStringTest() {
        var id = new ElementsId(ElementsCode._1T, ElementsLevel.None);
        var name = new ElementsName("1回転トウループ", "Single Toe loop jump");
        var elm = new Elements(ElementsType.Jump, id, name, 0.40F);
        Assert.Equal("Type=Jump,Id=1T,Name=1回転トウループ(Single Toe loop jump),BaseValue=0.4", 
            elm.ToString());
    }
}