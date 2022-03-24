using System.Globalization;

namespace ijs;

/// <summary>
/// 基礎点
/// </summary>
public readonly struct BaseValue {
    public readonly float value;
    public BaseValue(float value) {
        this.value = value;
    }

    public override string ToString() {
        return $"value={value.ToString(CultureInfo.InvariantCulture)}";
    }
}
