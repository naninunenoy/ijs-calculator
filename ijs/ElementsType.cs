namespace ijs;

public readonly struct ElementsType {
    public readonly SportsType sportsType;
    public readonly UniqueElementsType uniqueElementsType;
    public ElementsType(SportsType sportsType, UniqueElementsType uniqueElementsType) {
        this.sportsType = sportsType;
        this.uniqueElementsType = uniqueElementsType;
    }

    public override string ToString() {
        return $"{uniqueElementsType}({sportsType})";
    }
}
