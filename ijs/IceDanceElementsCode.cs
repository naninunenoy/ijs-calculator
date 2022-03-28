namespace ijs;

internal enum IceDanceElementsCode {
    _1BL,
    _2BL,
    _1MN,
    Sp,
    CoSp,
    StaLi,
    SlLi,
    CuLi,
    RoLi,
    STw,
    PSt,
    MiSt,
    CiSt,
    SeSt,
    NtMiSt,
    NtDiSt,
    NtCiSt,
    ChLi1,
    ChSp1,
    ChTw1
}

internal static class IceDanceElementsCodeExtensions {
    public static bool IsPatternDance(this IceDanceElementsCode code) {
        return code is >= IceDanceElementsCode._1BL and <= IceDanceElementsCode._1MN;
    }
    public static bool IsSpin(this IceDanceElementsCode code) {
        return code is >= IceDanceElementsCode.Sp and <= IceDanceElementsCode.CoSp;
    }
    public static bool IsList(this IceDanceElementsCode code) {
        return code is >= IceDanceElementsCode.StaLi and <= IceDanceElementsCode.RoLi;
    }
    public static bool IsTwizzle(this IceDanceElementsCode code) {
        return code is IceDanceElementsCode.STw;
    }
    public static bool IsStepSequence(this IceDanceElementsCode code) {
        return code is >= IceDanceElementsCode.PSt and <= IceDanceElementsCode.NtCiSt;
    }
    public static bool IsChoreographic(this IceDanceElementsCode code) {
        return code is >= IceDanceElementsCode.ChLi1 and <= IceDanceElementsCode.ChTw1;
    }
}
