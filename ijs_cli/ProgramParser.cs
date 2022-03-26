using ijs;

namespace ijs_cli;

public class ProgramParser {
    readonly IReadOnlyDictionary<ElementId, UnitElement> allElements;

    public ProgramParser(IReadOnlyDictionary<ElementId, UnitElement> allElements) {
        this.allElements = allElements;
    }

    public ElementList Parse(string programArg) {
        //TODO
        throw new NotImplementedException();
    }
}
