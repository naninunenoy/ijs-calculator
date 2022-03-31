namespace ijs.Internal;

internal static class ElementIdTable {
    static readonly ElementLevel[] LevelB1234 = ((ElementLevel[])Enum.GetValues(typeof(ElementLevel)))
        .Where(lv => lv is not ElementLevel.None)
        .ToArray();
    
    static readonly ElementLevel[] LevelB1 = LevelB1234
        .Where(lv => lv is not ElementLevel.Lv3 or ElementLevel.Lv4)
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
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }

    public static IEnumerable<ElementId> SingleStepSequenceElementsIds() {
        return SingleElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsStepSequence())
            .SelectMany(code => {
                // StSq の場合はレベル分けがあるが ChSq にはない
                return code is SingleElementCode.StSq
                    ? SingleElementCode.StSq.WithLevelElementLevel(LevelB1234)
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
                    ? PairElementCode.StSq.WithLevelElementLevel(LevelB1234)
                    : new[] { new ElementId(PairElementCode.ChSq) };
            });
    }

    public static IEnumerable<ElementId> PairLiftElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsLift())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }
    
    public static IEnumerable<ElementId> PairTwistLiftElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsTwistLift())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
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
                    : code.WithLevelElementLevel(LevelB1234);
            });
    }

    public static IEnumerable<ElementId> PairSpinElementsIds() {
        return PairElementCodeExtensions
            .AllEnums()
            .Where(x => x.IsSpin())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }
    
    public static IEnumerable<ElementId> IceDancePatternDanceElementsIds() {
        var withoutKp = IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsPatternDance(false))
            .SelectMany(code => code.WithLevelElementLevel(LevelB1));
        var others = IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsPatternDance(null))
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
        return withoutKp.Concat(others);
    }
    
    public static IEnumerable<ElementId> IceDancePatternDanceWithKeyPointElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsPatternDance(true))
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }
    
    public static IEnumerable<ElementId> IceDanceSpinElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsSpin())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }
    
    public static IEnumerable<ElementId> IceDanceLiftElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsLift())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }
    
    public static IEnumerable<ElementId> IceDanceTwizzleElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsTwizzle())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }

    public static IEnumerable<ElementId> IceDanceStepSequenceElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsStepSequence())
            .SelectMany(code => code.WithLevelElementLevel(LevelB1234));
    }

    public static IEnumerable<ElementId> IceDanceChoreographicElementsIds() {
        return IceDanceElementsCodeExtensions
            .AllEnums()
            .Where(x => x.IsChoreographicElements())
            .Select(code => new ElementId(code));
    }
}
