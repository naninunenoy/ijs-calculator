using System.Globalization;

namespace ijs_cli; 

public readonly struct TotalBaseValue {
    readonly float value;
    public TotalBaseValue(float value) {
        this.value = value;
    }

    public override string ToString() {
        return value.ToString("F2", CultureInfo.InvariantCulture);
    }
}
