namespace ijs; 

/// <summary>
/// エレメンツのレベル
/// </summary>
internal enum ElementLevel {
    /// <summary>
    /// NON(レベル無し)
    /// </summary>
    None,
    /// <summary>
    /// レベルベーシック
    /// </summary>
    LvB,
    /// <summary>
    /// レベル1
    /// </summary>
    Lv1,
    /// <summary>
    /// レベル2
    /// </summary>
    Lv2,
    /// <summary>
    /// レベル3
    /// </summary>
    Lv3,
    /// <summary>
    /// レベル4
    /// </summary>
    Lv4
}

internal static partial class ElementExtension {
    public static string ToEnumString(this ElementLevel elementLevel) {
        return elementLevel switch {
            ElementLevel.LvB => "B",
            ElementLevel.Lv1 => "1",
            ElementLevel.Lv2 => "2",
            ElementLevel.Lv3 => "3",
            ElementLevel.Lv4 => "4",
            _ => ""
        };
    }
}
