using System.Globalization;

namespace ijs_cli; 

public readonly struct TotalBaseValue {
    readonly decimal value;
    public TotalBaseValue(double value) {
        this.value = Math.Round((decimal)value, 3, MidpointRounding.AwayFromZero);
    }

    public override string ToString() {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }
}
