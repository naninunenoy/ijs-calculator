namespace ijs;

public readonly struct ElementType {
    public readonly SportsType sportsType;
    public readonly UniqueElementsType uniqueElementsType;
    public ElementType(SportsType sportsType, UniqueElementsType uniqueElementsType) {
        this.sportsType = sportsType;
        this.uniqueElementsType = uniqueElementsType;
    }

    public override string ToString() {
        return $"{uniqueElementsType}({sportsType})";
    }
}
