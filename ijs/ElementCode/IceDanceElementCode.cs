namespace ijs;

internal enum IceDanceElementCode {
    Undefined,
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
    static readonly IceDanceElementCode[] allEnums = (IceDanceElementCode[])Enum.GetValues(typeof(IceDanceElementCode));
    public static IEnumerable<IceDanceElementCode> AllEnums() => allEnums;
    public static IEnumerable<ElementId> WithLevelElementLevel(this IceDanceElementCode code, params ElementLevel[] levels) {
        return levels.Select(x => new ElementId(code, x));
    }
    public static bool IsPatternDance(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode._1BL and <= IceDanceElementCode._1MN;
    }
    public static bool IsSpin(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.Sp and <= IceDanceElementCode.CoSp;
    }
    public static bool IsList(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.StaLi and <= IceDanceElementCode.RoLi;
    }
    public static bool IsTwizzle(this IceDanceElementCode code) {
        return code is IceDanceElementCode.STw;
    }
    public static bool IsStepSequence(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.PSt and <= IceDanceElementCode.NtCiSt;
    }
    public static bool IsChoreographic(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.ChLi1 and <= IceDanceElementCode.ChTw1;
    }
}
