namespace ijs;

public static class ElementsTable {
    public static readonly IReadOnlyDictionary<ElementsId, Elements> SingleElementsDict;
    public static readonly IReadOnlyDictionary<ElementsId, Elements> PairElementsDict;
    public static readonly IReadOnlyDictionary<ElementsId, Elements> IceDanceElementsDict;
    public static IEnumerable<Elements> SingleElementsList => SingleElementsDict.Values;
    public static IEnumerable<Elements> PairElementsList => PairElementsDict.Values;
    public static IEnumerable<Elements> IceDanceElementsList => IceDanceElementsDict.Values;
    
    static ElementsTable() {
        SingleElementsDict = ElementsTypeList.Single()
            .Select(x => (x, ConcatIds(
                ElementsIdTable.SingleJumpElementsIds(),
                ElementsIdTable.SingleSpinElementsIds(),
                ElementsIdTable.SingleStepSequenceElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        PairElementsDict = ElementsTypeList.Pair()
            .Select(x => (x, ConcatIds(
                ElementsIdTable.PairJumpElementsIds(),
                ElementsIdTable.PairStepSequenceElementsIds(),
                ElementsIdTable.PairLiftElementsIds(),
                ElementsIdTable.PairTwistLiftElementsIds(),
                ElementsIdTable.PairThrowJumpElementsIds(),
                ElementsIdTable.PairDeathSpiralElementsIds(),
                ElementsIdTable.PairSpinElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        IceDanceElementsDict = ElementsTypeList.IceDance()
            .Select(x => (x, ConcatIds(
                ElementsIdTable.IceDancePatternDanceElementsIds(),
                ElementsIdTable.IceDanceSpinElementsIds(),
                ElementsIdTable.IceDanceLiftElementsIds(),
                ElementsIdTable.IceDanceTwizzleElementsIds(),
                ElementsIdTable.IceDanceStepSequenceElementsIds(),
                ElementsIdTable.IceDanceChoreographicElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
    }
    
    static IEnumerable<ElementsId> ConcatIds(params IEnumerable<ElementsId>[] ids) {
        return ids.Aggregate(Enumerable.Empty<ElementsId>(), (total, x) => total.Concat(x));
    }
    
    static IEnumerable<Elements> ToElements((ElementsType elementType, IEnumerable<ElementsId> elementsIds) tuple) {
        var (type, ids) = tuple;
        return ids.Select(id => new Elements(
            type, id, ElementsName.FromElementsId(id), BaseValue.FromElementsId(id)));
    }
}
