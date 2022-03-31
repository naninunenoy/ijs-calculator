using ijs;
using ijs.Internal;
using ijs_test.TestDriver;
using Xunit;

namespace ijs_test; 

public class JumpSequenceTest {
    readonly IElement jump0 = new TestElement("ジャンプ0", "Jump0", ElementType.Jump, 1);
    readonly IElement jump1 = new TestElement("ジャンプ1", "Jump1", ElementType.Jump, 10);

    [Fact]
    public void BuildTest() {
        var jumps = new JumpSequence();
        jumps.Build(jump0, jump1);
        Assert.Equal("ジャンプ0 + ジャンプ1", jumps.Name);
        Assert.Equal("Jump0+Jump1+SEQ", jumps.FullCode);
        Assert.Equal(11*0.8, jumps.BaseValue);
        Assert.Equal(ElementType.Jump, jumps.ElementType);
    }
}
