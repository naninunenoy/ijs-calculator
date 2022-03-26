namespace ijs;

internal readonly struct SportsElementType {
    public readonly SportsType SportsType;
    public readonly ElementType ElementType;
    public SportsElementType(SportsType sportsType, ElementType elementType) {
        SportsType = sportsType;
        ElementType = elementType;
    }

    public override string ToString() {
        return $"{ElementType}({SportsType})";
    }
}
