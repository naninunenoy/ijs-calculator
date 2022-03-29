namespace ijs.Internal;

internal static class ElementIdTable {
    static readonly ElementLevel[] LevelAll = ((ElementLevel[])Enum.GetValues(typeof(ElementLevel)))
        .Where(lv => lv is not ElementLevel.None)
        .ToArray();
    
    static readonly ElementLevel[] Level1234 = LevelAll
        .Where(lv => lv is not ElementLevel.LvB)
        .ToArray();

    public static IEnumerable<ElementId> SingleJumpElementsIds() {
        return SingleElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsJump())
            .Select(code => new ElementId(code));
    }
    
    public static IEnumerable<ElementId> SingleSpinElementsIds() {
        return SingleElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsSpin())
            .SelectMany(code => code.WithLevelElementLevel(LevelAll));
    }

    public static IEnumerable<ElementId> SingleStepSequenceElementsIds() {
        return SingleElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsStepSequence())
            .SelectMany(code => {
                // StSq の場合はレベル分けがあるが ChSq にはない
                return code is SingleElementCode.StSq
                    ? SingleElementCode.StSq.WithLevelElementLevel(LevelAll)
                    : new[] { new ElementId(SingleElementCode.ChSq) };
            });
    }

    public static IEnumerable<ElementId> PairJumpElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsJump())
            .Select(code => new ElementId(code));
    }
    
    public static IEnumerable<ElementId> PairStepSequenceElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsStepSequence())
            .SelectMany(code => {
                // StSq の場合はレベル分けがあるが ChSq にはない
                return code is PairElementCode.StSq
                    ? PairElementCode.StSq.WithLevelElementLevel(LevelAll)
                    : new[] { new ElementId(PairElementCode.ChSq) };
            });
    }

    public static IEnumerable<ElementId> PairLiftElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsLift())
            .SelectMany(code => code.WithLevelElementLevel(LevelAll));
    }
    
    public static IEnumerable<ElementId> PairTwistLiftElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsTwistLift())
            .SelectMany(code => code.WithLevelElementLevel(LevelAll));
    }

    public static IEnumerable<ElementId> PairThrowJumpElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsThrowJump())
            .Select(code => new ElementId(code));
    }

    public static IEnumerable<ElementId> PairDeathSpiralElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsDeathSpiral())
            .SelectMany(code => {
                // PiF のみレベル分けがない
                return code is PairElementCode.PiF
                    ? new[] { new ElementId(PairElementCode.PiF) }
                    : code.WithLevelElementLevel(LevelAll);
            });
    }

    public static IEnumerable<ElementId> PairSpinElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsSpin())
            .SelectMany(code => code.WithLevelElementLevel(LevelAll));
    }

    public static IEnumerable<ElementId> IceDancePatternDanceElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsPatternDance())
            .SelectMany(code => code.WithLevelElementLevel(Level1234));
    }
    
    public static IEnumerable<ElementId> IceDanceSpinElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsSpin())
            .SelectMany(code => code.WithLevelElementLevel(Level1234));
    }
    
    public static IEnumerable<ElementId> IceDanceLiftElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsList())
            .SelectMany(code => code.WithLevelElementLevel(Level1234));
    }
    
    public static IEnumerable<ElementId> IceDanceTwizzleElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsTwizzle())
            .SelectMany(code => code.WithLevelElementLevel(Level1234));
    }

    public static IEnumerable<ElementId> IceDanceStepSequenceElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsStepSequence())
            .SelectMany(code => code.WithLevelElementLevel(LevelAll));
    }

    public static IEnumerable<ElementId> IceDanceChoreographicElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsChoreographicElements())
            .Select(code => new ElementId(code));
    }
}
