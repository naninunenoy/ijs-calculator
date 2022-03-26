using System.Globalization;

namespace ijs_cli; 

public readonly struct TotalBaseValue {
    readonly double value;
    public TotalBaseValue(double value) {
        this.value = Math.Round(value, 3);
    }

    public override string ToString() {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }
}
