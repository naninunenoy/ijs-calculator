using System.Globalization;

namespace ijs_cli; 

public readonly struct TotalBaseValue {
    readonly decimal value;
    public TotalBaseValue(float value) {
        this.value = Math.Round((decimal)value, 3);
    }

    public override string ToString() {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }
}
