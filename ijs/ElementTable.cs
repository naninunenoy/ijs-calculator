namespace ijs;

public static class ElementTable {
    public static readonly IReadOnlyDictionary<ElementId, UnitElement> SingleElementsDict;
    public static readonly IReadOnlyDictionary<ElementId, UnitElement> PairElementsDict;
    public static readonly IReadOnlyDictionary<ElementId, UnitElement> IceDanceElementsDict;
    public static IEnumerable<UnitElement> SingleElementsList => SingleElementsDict.Values;
    public static IEnumerable<UnitElement> PairElementsList => PairElementsDict.Values;
    public static IEnumerable<UnitElement> IceDanceElementsList => IceDanceElementsDict.Values;
    
    static ElementTable() {
        SingleElementsDict = ElementTypeList.Single()
            .Select(x => (x, ConcatIds(
                ElementIdTable.SingleJumpElementsIds(),
                ElementIdTable.SingleSpinElementsIds(),
                ElementIdTable.SingleStepSequenceElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        PairElementsDict = ElementTypeList.Pair()
            .Select(x => (x, ConcatIds(
                ElementIdTable.PairJumpElementsIds(),
                ElementIdTable.PairStepSequenceElementsIds(),
                ElementIdTable.PairLiftElementsIds(),
                ElementIdTable.PairTwistLiftElementsIds(),
                ElementIdTable.PairThrowJumpElementsIds(),
                ElementIdTable.PairDeathSpiralElementsIds(),
                ElementIdTable.PairSpinElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        IceDanceElementsDict = ElementTypeList.IceDance()
            .Select(x => (x, ConcatIds(
                ElementIdTable.IceDancePatternDanceElementsIds(),
                ElementIdTable.IceDanceSpinElementsIds(),
                ElementIdTable.IceDanceLiftElementsIds(),
                ElementIdTable.IceDanceTwizzleElementsIds(),
                ElementIdTable.IceDanceStepSequenceElementsIds(),
                ElementIdTable.IceDanceChoreographicElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
    }
    
    static IEnumerable<ElementId> ConcatIds(params IEnumerable<ElementId>[] ids) {
        return ids.Aggregate(Enumerable.Empty<ElementId>(), (total, x) => total.Concat(x));
    }
    
    static IEnumerable<UnitElement> ToElements((SportsElementType elementType, IEnumerable<ElementId> elementsIds) tuple) {
        var (type, ids) = tuple;
        return ids.Select(id => new UnitElement(
            type, id, ElementName.FromElementsId(id), BaseValue.FromElementsId(id)));
    }
}
