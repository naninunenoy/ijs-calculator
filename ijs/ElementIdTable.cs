namespace ijs;

internal static class ElementIdTable {
    static readonly ElementCode[] AllCode = (ElementCode[])Enum.GetValues(typeof(ElementCode));
    static readonly ElementLevel[] AllLevel = ((ElementLevel[])Enum.GetValues(typeof(ElementLevel)))
        .Where(lv => lv is not ElementLevel.None)
        .ToArray();

    static IEnumerable<ElementId> ToLevelElementIds((ElementCode code, IEnumerable<ElementLevel> levels) tuple) {
        var (code, levels) = tuple;
        return levels.Select(level => new ElementId(code, level));
    }
    
    static IEnumerable<ElementId> ToLevelElementIds((ElementCode code, ElementLevel[] levels) tuple) {
        var (code, levels) = tuple;
        return levels.Select(level => new ElementId(code, level));
    }

    public static IEnumerable<ElementId> SingleJumpElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode._1T and <= ElementCode._4A)
            .Select(code => new ElementId(code));
    }
    
    public static IEnumerable<ElementId> SingleSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.USp and <= ElementCode.FCCoSp)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementId> SingleStepSequenceElementsIds() {
        return AllCode
            .Where(code => code is ElementCode.StSq)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds)
            .Concat(new[] { new ElementId(ElementCode.ChSq) });
    }

    public static IEnumerable<ElementId> PairJumpElementsIds() {
        return SingleJumpElementsIds();
    }
    
    public static IEnumerable<ElementId> PairStepSequenceElementsIds() {
        return SingleStepSequenceElementsIds();
    }

    public static IEnumerable<ElementId> PairLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode._1Li and <= ElementCode._5RLi)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementId> PairTwistLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode._1Tw and <= ElementCode._4Tw)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementId> PairThrowJumpElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode._1TTh and <= ElementCode._4LzTh)
            .Select(code => new ElementId(code));
    }

    public static IEnumerable<ElementId> PairDeathSpiralElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.FiDs and <= ElementCode.BoDs)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds)
            .Concat(new[] { new ElementId(ElementCode.PiF) });
    }

    public static IEnumerable<ElementId> PairSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.PSp and <= ElementCode.PCoSp)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementId> IceDancePatternDanceElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode._1BL and <= ElementCode._1MN)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementId> IceDanceSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.Sp and <= ElementCode._CoSp)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementId> IceDanceLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.StaLi and <= ElementCode.RoLi)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementId> IceDanceTwizzleElementsIds() {
        return AllCode
            .Where(code => code is ElementCode.STw)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementId> IceDanceStepSequenceElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.PSt and <= ElementCode.NtCiSt)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementId> IceDanceChoreographicElementsIds() {
        return AllCode
            .Where(code => code is >= ElementCode.ChLi1 and <= ElementCode.ChTw1)
            .Select(code => new ElementId(code));
    }
}
