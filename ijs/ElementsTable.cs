namespace ijs; 

public static class ElementsTable {
    public static readonly Elements[] SingleElements;
    public static readonly Elements[] PairElements;
    public static readonly Elements[] IceDanceElements;

    static ElementsTable() {
        SingleElements = ElementsTypeList.Single()
            .Select(x => (x, ElementsIdTable.SingleJumpElementsIds()
                    .Concat(ElementsIdTable.SingleSpinElementsIds())
                    .Concat(ElementsIdTable.SingleStepSequenceElementsIds())))
            .SelectMany(ToElements)
            .ToArray();
        PairElements = ElementsTypeList.Pair()
            .Select(x => (x, ElementsIdTable.PairJumpElementsIds()
                    .Concat(ElementsIdTable.PairStepSequenceElementsIds())
                    .Concat(ElementsIdTable.PairLiftElementsIds())
                    .Concat(ElementsIdTable.PairTwistLiftElementsIds())
                    .Concat(ElementsIdTable.PairThrowJumpElementsIds())
                    .Concat(ElementsIdTable.PairDeathSpiralElementsIds())
                    .Concat(ElementsIdTable.PairSpinElementsIds())))
            .SelectMany(ToElements)
            .ToArray();
        IceDanceElements = ElementsTypeList.IceDance()
            .Select(x => (x, ElementsIdTable.IceDancePatternDanceElementsIds()
                    .Concat(ElementsIdTable.IceDanceSpinElementsIds())
                    .Concat(ElementsIdTable.IceDanceLiftElementsIds())
                    .Concat(ElementsIdTable.IceDanceTwizzleElementsIds())
                    .Concat(ElementsIdTable.IceDanceStepSequenceElementsIds())
                    .Concat(ElementsIdTable.IceDanceChoreographicElementsIds())))
            .SelectMany(ToElements)
            .ToArray();
    }
    
    static IEnumerable<Elements> ToElements((ElementType elementType, IEnumerable<ElementsId> elementsIds) tuple) {
        var (type, ids) = tuple;
        return ids.Select(id => new Elements(
            type, id, ElementsName.FromElementsId(id), BaseValue.FromElementsId(id).value));
    }
}
