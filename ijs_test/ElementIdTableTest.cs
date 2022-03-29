using System.Linq;
using ijs.Internal;
using Xunit;

namespace ijs_test;

public class ElementIdTableTest {
    [Fact]
    public void SingleJumpElementsIdsTest() {
        var ids = ElementIdTable.SingleJumpElementsIds();
        Assert.Equal(25, ids.Count());
    }

    [Fact]
    public void SingleSpinElementsIdsTest() {
        var ids = ElementIdTable.SingleSpinElementsIds();
        Assert.Equal(20*5, ids.Count());
    }

    [Fact]
    public void SingleStepSequenceElementsIdsTest() {
        var ids = ElementIdTable.SingleStepSequenceElementsIds();
        Assert.Equal(5+1, ids.Count());
    }

    [Fact]
    public void PairJumpElementsIdsTest() {
        var ids = ElementIdTable.PairJumpElementsIds();
        Assert.Equal(25, ids.Count());
    }

    [Fact]
    public void PairStepSequenceElementsIdsTest() {
        var ids = ElementIdTable.PairStepSequenceElementsIds();
        Assert.Equal(6, ids.Count());
    }

    [Fact]
    public void PairLiftElementsIdsTest() {
        var ids = ElementIdTable.PairLiftElementsIds();
        Assert.Equal(9*5, ids.Count());
    }

    [Fact]
    public void PairTwistLiftElementsIdsTest() {
        var ids = ElementIdTable.PairTwistLiftElementsIds();
        Assert.Equal(4*5, ids.Count());
    }

    [Fact]
    public void PairThrowJumpElementsIdsTest() {
        var ids = ElementIdTable.PairThrowJumpElementsIds();
        Assert.Equal(23, ids.Count());
    }

    [Fact]
    public void PairDeathSpiralElementsIdsTest() {
        var ids = ElementIdTable.PairDeathSpiralElementsIds();
        Assert.Equal(4*5+1, ids.Count());
    }

    [Fact]
    public void PairSpinElementsIdsTest() {
        var ids = ElementIdTable.PairSpinElementsIds();
        Assert.Equal(2*5, ids.Count());
    }

    [Fact]
    public void IceDancePatternDanceElementsIdsTest() {
        var ids = ElementIdTable.IceDancePatternDanceElementsIds();
        Assert.Equal(3*4, ids.Count());
    }

    [Fact]
    public void IceDanceSpinElementsIdsTest() {
        var ids = ElementIdTable.IceDanceSpinElementsIds();
        Assert.Equal(2*4, ids.Count());
    }

    [Fact]
    public void IceDanceLiftElementsIdsTest() {
        var ids = ElementIdTable.IceDanceLiftElementsIds();
        Assert.Equal(4*4, ids.Count());
    }

    [Fact]
    public void IceDanceTwizzleElementsIdsTest() {
        var ids = ElementIdTable.IceDanceTwizzleElementsIds();
        Assert.Equal(4, ids.Count());
    }

    [Fact]
    public void IceDanceStepSequenceElementsIdsTest() {
        var ids = ElementIdTable.IceDanceStepSequenceElementsIds();
        Assert.Equal(7*5, ids.Count());
    }

    [Fact]
    public void IceDanceChoreographicElementsIdsTest() {
        var ids = ElementIdTable.IceDanceChoreographicElementsIds();
        Assert.Equal(3, ids.Count());
    }
}
