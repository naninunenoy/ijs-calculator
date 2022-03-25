namespace ijs;

public readonly struct SportsElementsType {
    public readonly SportsType SportsType;
    public readonly ElementsType ElementsType;
    public SportsElementsType(SportsType sportsType, ElementsType elementsType) {
        SportsType = sportsType;
        ElementsType = elementsType;
    }

    public override string ToString() {
        return $"{ElementsType}({SportsType})";
    }
}
