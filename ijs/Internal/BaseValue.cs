using System.Globalization;

namespace ijs.Internal;

/// <summary>
/// 基礎点
/// </summary>
internal readonly struct BaseValue {
    public readonly double value;
    internal BaseValue(double value) {
        this.value = value;
    }
}
