namespace ijs; 

internal enum SingleElementCode {
    Undefined,
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
    StSq,
    ChSq,
}

internal static class SingleElementCodeExtensions {
    public static bool IsJump(this SingleElementCode code) {
        return code is >= SingleElementCode._1T and <= SingleElementCode._4A;
    }
    
    public static bool IsSpin(this SingleElementCode code) {
        return code is >= SingleElementCode.USp and <= SingleElementCode.FCCoSp;
    }
    
    public static bool IsStepSequence(this SingleElementCode code) {
        return code is >= SingleElementCode.StSq and <= SingleElementCode.ChSq;
    }
}
