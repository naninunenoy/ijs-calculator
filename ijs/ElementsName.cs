namespace ijs; 

public readonly struct ElementsName {
    public readonly string jpn;
    public readonly string eng;

    public ElementsName(string jpn, string eng) {
        this.jpn = jpn;
        this.eng = eng;
    }

    public override string ToString() {
        return $"{jpn}({eng})";
    }
}
