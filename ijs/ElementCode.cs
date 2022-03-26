namespace ijs;

/// <summary>
/// エレメンツの記号
/// </summary>
/// <remarks>
/// 言語使用で数字を先頭にできないので
/// 共通して `_` を先頭に置いている
/// </remarks>
public enum ElementCode {
    // ジャンプ(シングル・ペア)
    _1T,
    _1S,
    _1Lo,
    _1Eu,
    _1F,
    _1Lz,
    _1A,
    _2T,
    _2S,
    _2Lo,
    _2F,
    _2Lz,
    _2A,
    _3T,
    _3S,
    _3Lo,
    _3F,
    _3Lz,
    _3A,
    _4T,
    _4S,
    _4Lo,
    _4F,
    _4Lz,
    _4A,
    // スピン(シングル)
    USp,
    LSp,
    CSp,
    SSp,
    FUSp,
    FLSp,
    FCSp,
    FSSp,
    CUSp,
    FCUSp,
    CLSp,
    FCLSp,
    CCSp,
    FCCSp,
    CSSp,
    FCSSp,
    CoSp,
    FCoSp,
    CCoSp,
    FCCoSp,
    // ステップシークエンス(シングル・ペア)
    StSq,
    ChSq,
    // リフト(ペア)
    _1Li,	
    _2Li,	
    _3Li,
    _4Li,	
    _5TLi,
    _5SLi,	
    _5BLi,	
    _5ALi,
    _5RLi,
    // ツイストリフト(ペア)
    _1Tw,	
    _2Tw,	
    _3Tw,	
    _4Tw,	
    // スロージャンプ(ペア)
    _1TTh,
    _1STh,
    _1LoTh,
    _1FTh,
    _1LzTh,
    _1ATh,
    _2TTh,
    _2STh,
    _2LoTh,
    _2FTh,
    _2LzTh,
    _2ATh,
    _3TTh,
    _3STh,
    _3LoTh,
    _3FTh,
    _3LzTh,
    _3ATh,
    _4TTh,
    _4STh,
    _4LoTh,
    _4FTh,
    _4LzTh,
    // デススパイラル
    FiDs,
    BiDs,
    FoDs,
    BoDs,
    PiF,
    // スピン(ペア)
    PSp,
    PCoSp,
    // パターンダンス(アイスダンス)
    _1BL,
    _2BL,
    _1MN,
    // スピン(アイスダンス)
    Sp,
    _CoSp, // シングルのコンビネーションスピンと区別するために先頭に `_` をつける(苦肉の策)
    // リフト(アイスダンス)
    StaLi,
    SlLi,
    CuLi,
    RoLi,
    // ツイズル(アイスダンス)
    STw,
    // ステップシークエンス(アイスダンス)
    PSt,
    MiSt,
    CiSt,
    SeSt,
    NtMiSt,
    NtDiSt,
    NtCiSt,
    // コレオグラフィックエレメンツ(アイスダンス)
    ChLi1,
    ChSp1,
    ChTw1
}

internal static partial class ElementExtension {
    public static string ToEnumString(this ElementCode elementCode) {
        return elementCode.ToString().TrimStart('_');
    }
}
