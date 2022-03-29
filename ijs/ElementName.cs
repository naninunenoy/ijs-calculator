namespace ijs; 

internal readonly struct ElementName {
    public readonly string jpn;
    //public readonly string eng;

    internal ElementName(string jpn) {
        this.jpn = jpn;
    }

    public override string ToString() {
        return $"{jpn}";
    }
}
