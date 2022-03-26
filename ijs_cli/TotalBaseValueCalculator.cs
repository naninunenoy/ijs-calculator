namespace ijs_cli; 

public class TotalBaseValueCalculator {
    readonly string sportsType;
    readonly string programRawArg;

    public TotalBaseValueCalculator(string sportsType, string programRawArg) {
        this.sportsType = sportsType;
        this.programRawArg = programRawArg;
    }

    public (TotalBaseValue totalBaseValue, string description) Calculate() => throw new NotImplementedException("未実装です");
}
