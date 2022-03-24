namespace ijs; 

public readonly struct ElementsName {
    public readonly string jpn;
    //public readonly string eng;

    public ElementsName(string jpn) {
        this.jpn = jpn;
    }

    public override string ToString() {
        return $"{jpn}";
    }
}
