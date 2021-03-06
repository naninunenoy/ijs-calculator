namespace ijs.Internal; 

internal enum  IceDanceElementCode {
    Undefined,
    kpFO1Sq,
    kpFO2Sq,
    kpFO3Sq,
    kpFO4Sq,
    kpFT1Sq,
    kpFT2Sq,
    kpFT3Sq,
    kpFT4Sq,
    kpRF1Sq,
    kpRF2Sq,
    kpRF3Sq,
    kpRF4Sq,
    kpTTF1Sq,
    kpTTF2Sq,
    kpEW1Sq,
    kpEW2Sq,
    kpAW1Sq,
    kpAW2Sq,
    kpSW1Sq1Se,
    kpSW1Sq2Se,
    kpSW2Sq1Se,
    kpSW2Sq2Se,
    kpKI1Sq,
    kpKI2Sq,
    kpKI3Sq,
    kpKI4Sq,
    kpKI5Sq,
    kpKI6Sq,
    kpQS1Sq,
    kpQS2Sq,
    kpQS3Sq,
    kpQS4Sq,
    kpFS1Sq,
    kpFS2Sq,
    kpTA1Sq,
    kpTA2Sq,
    kpAT1Sq,
    kpAT2Sq,
    kpBL1Sq,
    kpBL2Sq,
    kpBL3Sq,
    FO1Sq,
    FO2Sq,
    FO3Sq,
    FO4Sq,
    FT1Sq,
    FT2Sq,
    FT3Sq,
    FT4Sq,
    RF1Sq,
    RF2Sq,
    RF3Sq,
    RF4Sq,
    TTF1Sq1Se,
    TTF1Sq2Se,
    TTF2Sq1Se,
    TTF2Sq2Se,
    SD1Sq,
    SD2Sq,
    DW1Sq,
    DW2Sq,
    WiW1Sq,
    WiW2Sq,
    EW1Sq,
    EW2Sq,
    AW1Sq,
    AW2Sq,
    WW1Sq1Se,
    WW1Sq2Se,
    WW2Sq1Se,
    WW2Sq2Se,
    VW1Sq,
    VW2Sq,
    VW3Sq,
    OW1Sq1Se,
    OW1Sq2Se,
    OW2Sq1Se,
    OW2Sq2Se,
    SW1Sq1Se,
    SW1Sq2Se,
    SW2Sq1Se,
    SW2Sq2Se,
    RW1Sq1Se,
    RW1Sq2Se,
    RW2Sq1Se,
    RW2Sq2Se,
    GW1Sq1Se,
    GW1Sq2Se,
    GW2Sq1Se,
    GW2Sq2Se,
    KI1Sq,
    KI2Sq,
    KI3Sq,
    KI4Sq,
    KI5Sq,
    KI6Sq,
    YP1Sq1Se,
    YP1Sq2Se,
    YP2Sq1Se,
    YP2Sq2Se,
    QS1Sq,
    QS2Sq,
    QS3Sq,
    QS4Sq,
    FS1Sq1Se,
    FS1Sq2Se,
    FS2Sq1Se,
    FS2Sq2Se,
    PD1Sq,
    PD2Sq,
    PD3Sq,
    RH1Sq,
    RH2Sq,
    RH3Sq,
    RH4Sq,
    CC1Sq,
    CC2Sq,
    SS1Sq1Se,
    SS1Sq2Se,
    SS2Sq1Se,
    SS2Sq2Se,
    TF1Sq,
    TF2Sq,
    TF3Sq,
    TC1Sq,
    TC2Sq,
    TC3Sq,
    TA1Sq,
    TA2Sq,
    AT1Sq1Se,
    AT1Sq2Se,
    AT2Sq1Se,
    AT2Sq2Se,
    TR1Sq1Se,
    TR1Sq2Se,
    TR2Sq1Se,
    TR2Sq2Se,
    RB1Sq,
    RB2Sq,
    RB3Sq,
    BL1Sq,
    BL2Sq,
    BL3Sq,
    MB1Sq1Se,
    MB1Sq2Se,
    MB2Sq1Se,
    MB2Sq2Se,
    _1TTF,
    _2TTF,
    _1FS,
    PStL,
    PStM,
    Sp,
    CoSp,
    StaLi,
    SlLi,
    CuLi,
    RoLi,
    SqTwL,
    SqTwM,
    SyTwL,
    SyTwM,
    OFStL,
    OFStM,
    DiSt,
    MiSt,
    CiSt,
    SeSt,
    ChLi1,
    ChSp1,
    ChTw1,
    ChSl1,
    ChSt1
}

internal static class IceDanceElementsCodeExtensions {
    static readonly IceDanceElementCode[] allEnums = (IceDanceElementCode[])Enum.GetValues(typeof(IceDanceElementCode));
    public static IEnumerable<IceDanceElementCode> AllEnums() => allEnums;
    public static IEnumerable<ElementId> WithLevelElementLevel(this IceDanceElementCode code, params ElementLevel[] levels) {
        return levels.Select(x => new ElementId(code, x));
    }
    public static bool IsPatternDance(this IceDanceElementCode code) {
        return code.IsPatternDanceWithKeyPoint() ||
               code.IsPatternDanceWithoutKeyPoint() ||
               code.IsRequiredElement();
    }
    public static bool IsPatternDanceWithKeyPoint(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.kpFO1Sq and <= IceDanceElementCode.kpBL3Sq;
    }
    public static bool IsPatternDanceWithoutKeyPoint(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.FO1Sq and <= IceDanceElementCode.MB2Sq2Se;
    }
    public static bool IsRequiredElement(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode._1TTF and <= IceDanceElementCode.PStM;
    }
    public static bool IsSpin(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.Sp and <= IceDanceElementCode.CoSp;
    }
    public static bool IsLift(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.StaLi and <= IceDanceElementCode.RoLi;
    }
    public static bool IsTwizzle(this IceDanceElementCode code) {
        return code.IsSequentialTwizzle() || code.IsSynchronizedTwizzle();
    }
    public static bool IsSequentialTwizzle(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.SqTwL and <= IceDanceElementCode.SqTwM;
    }
    public static bool IsSynchronizedTwizzle(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.SyTwL and <= IceDanceElementCode.SyTwM;
    }
    public static bool IsStepSequence(this IceDanceElementCode code) {
        return code.IsOneFootStepSequence() || code.IsStepSequenceHoldOrNotTouchingStyleB();
    }
    public static bool IsOneFootStepSequence(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.OFStL and <= IceDanceElementCode.OFStM;
    }
    public static bool IsStepSequenceHoldOrNotTouchingStyleB(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.DiSt and <= IceDanceElementCode.SeSt;
    }
    public static bool IsChoreographicElements(this IceDanceElementCode code) {
        return code is >= IceDanceElementCode.ChLi1 and <= IceDanceElementCode.ChSt1;
    }
}
