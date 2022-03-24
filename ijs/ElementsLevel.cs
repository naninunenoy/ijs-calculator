namespace ijs; 

/// <summary>
/// エレメンツのレベル
/// </summary>
public enum ElementsLevel {
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
    public static string ToEnumString(this ElementsLevel elementsLevel) {
        return elementsLevel switch {
            ElementsLevel.LvB => "B",
            ElementsLevel.Lv1 => "1",
            ElementsLevel.Lv2 => "2",
            ElementsLevel.Lv3 => "3",
            ElementsLevel.Lv4 => "4",
            _ => ""
        };
    }
}
