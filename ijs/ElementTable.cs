using ijs.Internal;
using ijs.Localizations;

namespace ijs;

public static class ElementTable {
    static readonly IReadOnlyDictionary<ElementId, UnitElement> SingleElementsDict;
    static readonly IReadOnlyDictionary<ElementId, UnitElement> PairElementsDict;
    static readonly IReadOnlyDictionary<ElementId, UnitElement> IceDanceElementsDict;
    public static IEnumerable<IElement> SingleElementsList => SingleElementsDict.Values;
    public static IEnumerable<IElement> PairElementsList => PairElementsDict.Values;
    public static IEnumerable<IElement> IceDanceElementsList => IceDanceElementsDict.Values;
    
    static ElementTable() {
        try {
            CsvDictSet.Build();
            LocalizationsDict.Build();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        
        SingleElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.SingleJump, ElementIdTable.SingleJumpElementsIds()),
                ToElements(ElementTypeList.SingleSpin, ElementIdTable.SingleSpinElementsIds()),
                ToElements(ElementTypeList.SingleStepSequence, ElementIdTable.SingleStepSequenceElementsIds()))
            .ToDictionary(x => x.Id);
        PairElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.PairJump, ElementIdTable.PairJumpElementsIds()),
                ToElements(ElementTypeList.PairStepSequence, ElementIdTable.PairStepSequenceElementsIds()),
                ToElements(ElementTypeList.PairLift, ElementIdTable.PairLiftElementsIds()),
                ToElements(ElementTypeList.PairTwistLift, ElementIdTable.PairTwistLiftElementsIds()),
                ToElements(ElementTypeList.PairThrowJump, ElementIdTable.PairThrowJumpElementsIds()),
                ToElements(ElementTypeList.PairDeathSpiral, ElementIdTable.PairDeathSpiralElementsIds()),
                ToElements(ElementTypeList.PairSpin, ElementIdTable.PairSpinElementsIds()))
            .ToDictionary(x => x.Id);
        IceDanceElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.IceDancePatternDance, ElementIdTable.IceDancePatternDanceElementsIds()),
                ToElements(ElementTypeList.IceDanceSpin, ElementIdTable.IceDanceSpinElementsIds()),
                ToElements(ElementTypeList.IceDanceLift, ElementIdTable.IceDanceLiftElementsIds()),
                ToElements(ElementTypeList.IceDanceTwizzle, ElementIdTable.IceDanceTwizzleElementsIds()),
                ToElements(ElementTypeList.IceDanceStepSequence, ElementIdTable.IceDanceStepSequenceElementsIds()),
                ToElements(ElementTypeList.IceDanceChoreographicElement, ElementIdTable.IceDanceChoreographicElementsIds()))
            .ToDictionary(x => x.Id);
    }
    
    static IEnumerable<UnitElement> ConcatUnitElements(params IEnumerable<UnitElement>[] unitElements) {
        return unitElements.Aggregate(Enumerable.Empty<UnitElement>(), (total, x) => total.Concat(x));
    }

    static IEnumerable<UnitElement> ToElements(SportsElementType sportsElementType, IEnumerable<ElementId> elementIds) {
        return elementIds.Select(id => {
            CsvDictSet.TryGetValues(sportsElementType.SportsType, id.ToString(), out var baseValue);
            LocalizationsDict.TryGetValues(sportsElementType.SportsType, id.Code.ToString(), out var elementName);
            return new UnitElement(sportsElementType, id, elementName, baseValue);
        });
    }
}
