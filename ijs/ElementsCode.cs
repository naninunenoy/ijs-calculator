namespace ijs; 

/// <summary>
/// エレメンツの記号
/// </summary>
/// <remarks>
/// 言語使用で数字を先頭にできないので
/// 共通して `_` を先頭に置いている
/// </remarks>
public enum ElementsCode {
    _1T,
    //TODO
}

internal static partial class ElementExtension {
    public static string ToEnumString(this ElementsCode elementsCode) {
        return elementsCode.ToString().TrimStart('_');
    }
}
