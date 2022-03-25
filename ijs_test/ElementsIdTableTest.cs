using System.Linq;
using ijs;
using Xunit;

namespace ijs_test;

public class ElementsIdTableTest {
    [Fact]
    public void SingleJumpElementsIdsTest() {
        var ids = ElementsIdTable.SingleJumpElementsIds();
        Assert.Equal(25, ids.Count());
    }

    [Fact]
    public void SingleSpinElementsIdsTest() {
        var ids = ElementsIdTable.SingleSpinElementsIds();
        Assert.Equal(14*5, ids.Count());
    }

    [Fact]
    public void SingleStepSequenceElementsIdsTest() {
        var ids = ElementsIdTable.SingleStepSequenceElementsIds();
        Assert.Equal(5+1, ids.Count());
    }

    [Fact]
    public void PairJumpElementsIdsTest() {
        var ids = ElementsIdTable.PairJumpElementsIds();
        Assert.Equal(25, ids.Count());
    }

    [Fact]
    public void PairStepSequenceElementsIdsTest() {
        var ids = ElementsIdTable.PairStepSequenceElementsIds();
        Assert.Equal(6, ids.Count());
    }

    [Fact]
    public void PairLiftElementsIdsTest() {
        var ids = ElementsIdTable.PairLiftElementsIds();
        Assert.Equal(9*5, ids.Count());
    }

    [Fact]
    public void PairTwistLiftElementsIdsTest() {
        var ids = ElementsIdTable.PairTwistLiftElementsIds();
        Assert.Equal(4*5, ids.Count());
    }

    [Fact]
    public void PairThrowJumpElementsIdsTest() {
        var ids = ElementsIdTable.PairThrowJumpElementsIds();
        Assert.Equal(23, ids.Count());
    }

    [Fact]
    public void PairDeathSpiralElementsIdsTest() {
        var ids = ElementsIdTable.PairDeathSpiralElementsIds();
        Assert.Equal(4*5+1, ids.Count());
    }

    [Fact]
    public void PairSpinElementsIdsTest() {
        var ids = ElementsIdTable.PairSpinElementsIds();
        Assert.Equal(2*5, ids.Count());
    }

    [Fact]
    public void IceDancePatternDanceElementsIdsTest() {
        var ids = ElementsIdTable.IceDancePatternDanceElementsIds();
        Assert.Equal(3*4, ids.Count());
    }

    [Fact]
    public void IceDanceSpinElementsIdsTest() {
        var ids = ElementsIdTable.IceDanceSpinElementsIds();
        Assert.Equal(2*4, ids.Count());
    }

    [Fact]
    public void IceDanceLiftElementsIdsTest() {
        var ids = ElementsIdTable.IceDanceLiftElementsIds();
        Assert.Equal(4*4, ids.Count());
    }

    [Fact]
    public void IceDanceTwizzleElementsIdsTest() {
        var ids = ElementsIdTable.IceDanceTwizzleElementsIds();
        Assert.Equal(4, ids.Count());
    }

    [Fact]
    public void IceDanceStepSequenceElementsIdsTest() {
        var ids = ElementsIdTable.IceDanceStepSequenceElementsIds();
        Assert.Equal(7*5, ids.Count());
    }

    [Fact]
    public void IceDanceChoreographicElementsIdsTest() {
        var ids = ElementsIdTable.IceDanceChoreographicElementsIds();
        Assert.Equal(3, ids.Count());
    }
}
