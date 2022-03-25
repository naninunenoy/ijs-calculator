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
            .Select(x => (x, ElementsIdTable.SingleJumpElementsIds()
                .Concat(ElementsIdTable.SingleSpinElementsIds())
                .Concat(ElementsIdTable.SingleStepSequenceElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        PairElementsDict = ElementsTypeList.Pair()
            .Select(x => (x, ElementsIdTable.PairJumpElementsIds()
                .Concat(ElementsIdTable.PairStepSequenceElementsIds())
                .Concat(ElementsIdTable.PairLiftElementsIds())
                .Concat(ElementsIdTable.PairTwistLiftElementsIds())
                .Concat(ElementsIdTable.PairThrowJumpElementsIds())
                .Concat(ElementsIdTable.PairDeathSpiralElementsIds())
                .Concat(ElementsIdTable.PairSpinElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
        IceDanceElementsDict = ElementsTypeList.IceDance()
            .Select(x => (x, ElementsIdTable.IceDancePatternDanceElementsIds()
                .Concat(ElementsIdTable.IceDanceSpinElementsIds())
                .Concat(ElementsIdTable.IceDanceLiftElementsIds())
                .Concat(ElementsIdTable.IceDanceTwizzleElementsIds())
                .Concat(ElementsIdTable.IceDanceStepSequenceElementsIds())
                .Concat(ElementsIdTable.IceDanceChoreographicElementsIds())))
            .SelectMany(ToElements)
            .ToDictionary(x => x.Id);
    }

    static IEnumerable<Elements> ToElements((ElementsType elementType, IEnumerable<ElementsId> elementsIds) tuple) {
        var (type, ids) = tuple;
        return ids.Select(id => new Elements(
            type, id, ElementsName.FromElementsId(id), BaseValue.FromElementsId(id)));
    }
}
