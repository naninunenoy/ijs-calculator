using ijs_cli;
using Xunit;

namespace ijs_cli_test;

public class TotalBaseValueTest {
    [Fact]
    public void 合計点が小数点第3位四捨五入で表示されるか() {
        var s0 = new TotalBaseValue(1.114F);
        Assert.Equal("1.11", s0.ToString());
        var s1 = new TotalBaseValue(1.115F);
        Assert.Equal("1.12", s1.ToString());
    }
}
