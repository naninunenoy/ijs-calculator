using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class BaseValueRounderTest {
    [Fact]
    public void MultipleBaseValueTest() {
        // 0.015が小数第三位四捨五入で0.02になる
        Assert.Equal(0.02, BaseValueRounder.MultipleBaseValue(15, 0.001));
    }
    [Fact]
    public void GetRoundF2StringTest() {
        // 0.015が小数第三位四捨五入で0.02になる
        Assert.Equal("0.02", BaseValueRounder.GetRoundF2String(0.015));
    }
}
