﻿using System.Globalization;

namespace ijs;

/// <summary>
/// 基礎点
/// </summary>
internal readonly struct BaseValue {
    public readonly double value;
    internal BaseValue(double value) {
        this.value = value;
    }

    public override string ToString() {
        return $"value={value.ToString(CultureInfo.InvariantCulture)}";
    }
}
