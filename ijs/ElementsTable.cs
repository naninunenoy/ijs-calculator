namespace ijs; 

public static class ElementsTable {
    public static readonly Elements[] SingleElements;
    public static readonly Elements[] PairElements;
    public static readonly Elements[] IceDanceElements;

    static ElementsTable() {
        SingleElements = ElementsTypeList.Single()
            .Select(x => (x, ElementsIdTable.SingleElementsIds()))
            .SelectMany(ToElements)
            .ToArray();
        PairElements = ElementsTypeList.Pair()
            .Select(x => (x, ElementsIdTable.PairElementsIds()))
            .SelectMany(ToElements)
            .ToArray();
        IceDanceElements = ElementsTypeList.IceDance()
            .Select(x => (x, ElementsIdTable.IceDanceElementsIds()))
            .SelectMany(ToElements)
            .ToArray();
    }
    
    static IEnumerable<Elements> ToElements((ElementType elementType, IEnumerable<ElementsId> elementsIds) tuple) {
        var (type, ids) = tuple;
        return ids.Select(id => new Elements(
            type, id, ElementsName.FromElementsId(id), BaseValue.FromElementsId(id).value));
    }
}
