namespace ijs;

internal enum PairElementCode {
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
    StSq,
    ChSq,
    _1Li,
    _2Li,
    _3Li,
    _4Li,
    _5TLi,
    _5SLi,
    _5BLi,
    _5ALi,
    _5RLi,
    _1Tw,
    _2Tw,
    _3Tw,
    _4Tw,
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
    FiDs,
    BiDs,
    FoDs,
    BoDs,
    PiF,
    PSp,
    PCoSp
}

internal static class PairElementCodeExtensions {
    static readonly PairElementCode[] allEnums = (PairElementCode[])Enum.GetValues(typeof(PairElementCode));
    public static IEnumerable<PairElementCode> AllEnums() => allEnums;
    public static IEnumerable<ElementId> WithLevelElementLevel(this PairElementCode code, params ElementLevel[] levels) {
        return levels.Select(x => new ElementId(code, x));
    }
    public static bool IsJump(this PairElementCode code) {
        return code is >= PairElementCode._1T and <= PairElementCode._4A;
    }

    public static bool IsStepSequence(this PairElementCode code) {
        return code is >= PairElementCode.StSq and <= PairElementCode.ChSq;
    }

    public static bool IsLift(this PairElementCode code) {
        return code is >= PairElementCode._1Li and <= PairElementCode._5RLi;
    }

    public static bool IsTwistLift(this PairElementCode code) {
        return code is >= PairElementCode._1Tw and <= PairElementCode._4Tw;
    }


    public static bool IsThrowJump(this PairElementCode code) {
        return code is >= PairElementCode._1TTh and <= PairElementCode._4LzTh;
    }

    public static bool IsDeathSpiral(this PairElementCode code) {
        return code is >= PairElementCode.FiDs and <= PairElementCode.FiDs or PairElementCode.PiF;
    }

    public static bool IsSpin(this PairElementCode code) {
        return code is >= PairElementCode.PSp and <= PairElementCode.PCoSp;
    }
}
