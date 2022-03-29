namespace ijs.Internal; 

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

internal static class ElementLevelExtension {
    public static string ToLevelString(this ElementLevel elementLevel) {
        return elementLevel switch {
            ElementLevel.LvB => "Lv.B",
            ElementLevel.Lv1 => "Lv.1",
            ElementLevel.Lv2 => "Lv.2",
            ElementLevel.Lv3 => "Lv.3",
            ElementLevel.Lv4 => "Lv.4",
            _ => ""
        };
    }
}
