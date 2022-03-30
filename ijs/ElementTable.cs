using System.Globalization;
using ijs.Internal;
using ijs.Localizations;

namespace ijs;

public static class ElementTable {
    static IReadOnlyDictionary<ElementId, UnitElement> singleElementsDict = new Dictionary<ElementId, UnitElement>();
    static IReadOnlyDictionary<ElementId, UnitElement> pairElementsDict = new Dictionary<ElementId, UnitElement>();
    static IReadOnlyDictionary<ElementId, UnitElement> iceDanceElementsDict = new Dictionary<ElementId, UnitElement>();
    public static IEnumerable<IElement> SingleElementsList => singleElementsDict.Values;
    public static IEnumerable<IElement> PairElementsList => pairElementsDict.Values;
    public static IEnumerable<IElement> IceDanceElementsList => iceDanceElementsDict.Values;
    
    public static void Build(RegionInfo regionInfo) {
        try {
            CsvDictSet.Build();
            LocalizationsDict.Build();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        singleElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.SingleJump, ElementIdTable.SingleJumpElementsIds(), regionInfo),
                ToElements(ElementTypeList.SingleSpin, ElementIdTable.SingleSpinElementsIds(), regionInfo),
                ToElements(ElementTypeList.SingleStepSequence, ElementIdTable.SingleStepSequenceElementsIds(), regionInfo))
            .ToDictionary(x => x.Id);
        pairElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.PairJump, ElementIdTable.PairJumpElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairStepSequence, ElementIdTable.PairStepSequenceElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairLift, ElementIdTable.PairLiftElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairTwistLift, ElementIdTable.PairTwistLiftElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairThrowJump, ElementIdTable.PairThrowJumpElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairDeathSpiral, ElementIdTable.PairDeathSpiralElementsIds(), regionInfo),
                ToElements(ElementTypeList.PairSpin, ElementIdTable.PairSpinElementsIds(), regionInfo))
            .ToDictionary(x => x.Id);
        iceDanceElementsDict = ConcatUnitElements(
                ToElements(ElementTypeList.IceDancePatternDance, ElementIdTable.IceDancePatternDanceElementsIds(), regionInfo),
                ToElements(ElementTypeList.IceDanceSpin, ElementIdTable.IceDanceSpinElementsIds(), regionInfo),
                ToElements(ElementTypeList.IceDanceLift, ElementIdTable.IceDanceLiftElementsIds(), regionInfo),
                ToElements(ElementTypeList.IceDanceTwizzle, ElementIdTable.IceDanceTwizzleElementsIds(), regionInfo),
                ToElements(ElementTypeList.IceDanceStepSequence, ElementIdTable.IceDanceStepSequenceElementsIds(), regionInfo),
                ToElements(ElementTypeList.IceDanceChoreographicElement, ElementIdTable.IceDanceChoreographicElementsIds(), regionInfo))
            .ToDictionary(x => x.Id);
    }
    
    static IEnumerable<UnitElement> ConcatUnitElements(params IEnumerable<UnitElement>[] unitElements) {
        return unitElements.Aggregate(Enumerable.Empty<UnitElement>(), (total, x) => total.Concat(x));
    }

    static IEnumerable<UnitElement> ToElements(SportsElementType sportsElementType, IEnumerable<ElementId> elementIds, RegionInfo regionInfo) {
        return elementIds.Select(id => {
            CsvDictSet.TryGetValues(sportsElementType.SportsType, id.ToString(), out var baseValue);
            LocalizationsDict.TryGetValues(sportsElementType.SportsType, id.Code.ToString(), out var elementName);
            var element = new UnitElement(sportsElementType, id, elementName, baseValue) {
                RegionInfo = regionInfo
            };
            return element;
        });
    }
}
