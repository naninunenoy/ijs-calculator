namespace ijs;

public readonly struct ElementsType {
    public readonly SportsType SportsType;
    public readonly UniqueElementsType UniqueElementsType;
    public ElementsType(SportsType sportsType, UniqueElementsType uniqueElementsType) {
        SportsType = sportsType;
        UniqueElementsType = uniqueElementsType;
    }

    public override string ToString() {
        return $"{UniqueElementsType}({SportsType})";
    }
}
