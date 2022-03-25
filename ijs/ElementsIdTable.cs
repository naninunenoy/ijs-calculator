namespace ijs;

public static class ElementsIdTable {
    static readonly ElementsCode[] AllCode = (ElementsCode[])Enum.GetValues(typeof(ElementsCode));
    static readonly ElementsLevel[] AllLevel = ((ElementsLevel[])Enum.GetValues(typeof(ElementsLevel)))
        .Where(lv => lv is not ElementsLevel.None)
        .ToArray();

    static IEnumerable<ElementsId> ToLevelElementIds((ElementsCode code, IEnumerable<ElementsLevel> levels) tuple) {
        var (code, levels) = tuple;
        return levels.Select(level => new ElementsId(code, level));
    }
    
    static IEnumerable<ElementsId> ToLevelElementIds((ElementsCode code, ElementsLevel[] levels) tuple) {
        var (code, levels) = tuple;
        return levels.Select(level => new ElementsId(code, level));
    }

    public static IEnumerable<ElementsId> SingleJumpElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode._1T and <= ElementsCode._4A)
            .Select(code => new ElementsId(code));
    }
    
    public static IEnumerable<ElementsId> SingleSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.USp and <= ElementsCode.FCCoSp)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementsId> SingleStepSequenceElementsIds() {
        return AllCode
            .Where(code => code is ElementsCode.StSq)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds)
            .Concat(new[] { new ElementsId(ElementsCode.ChSq) });
    }

    public static IEnumerable<ElementsId> PairJumpElementsIds() {
        return SingleJumpElementsIds();
    }
    
    public static IEnumerable<ElementsId> PairStepSequenceElementsIds() {
        return SingleStepSequenceElementsIds();
    }

    public static IEnumerable<ElementsId> PairLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode._1Li and <= ElementsCode._5RLi)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementsId> PairTwistLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode._1Tw and <= ElementsCode._4Tw)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementsId> PairThrowJumpElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode._1TTh and <= ElementsCode._4LzTh)
            .Select(code => new ElementsId(code));
    }

    public static IEnumerable<ElementsId> PairDeathSpiralElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.FiDs and <= ElementsCode.BoDs)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds)
            .Concat(new[] { new ElementsId(ElementsCode.PiF) });
    }

    public static IEnumerable<ElementsId> PairSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.PSp and <= ElementsCode.PCoSp)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementsId> IceDancePatternDanceElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode._1BL and <= ElementsCode._1MN)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementsLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementsId> IceDanceSpinElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.Sp and <= ElementsCode.CoSp)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementsLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementsId> IceDanceLiftElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.StaLi and <= ElementsCode.RoLi)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementsLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }
    
    public static IEnumerable<ElementsId> IceDanceTwizzleElementsIds() {
        return AllCode
            .Where(code => code is ElementsCode.STw)
            .Select(code => (code, AllLevel.Where(lv => lv is not ElementsLevel.LvB)))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementsId> IceDanceStepSequenceElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.PSt and <= ElementsCode.NtCiSt)
            .Select(code => (code, AllLevel))
            .SelectMany(ToLevelElementIds);
    }

    public static IEnumerable<ElementsId> IceDanceChoreographicElementsIds() {
        return AllCode
            .Where(code => code is >= ElementsCode.ChLi1 and <= ElementsCode.ChTw1)
            .Select(code => new ElementsId(code));
    }
}
