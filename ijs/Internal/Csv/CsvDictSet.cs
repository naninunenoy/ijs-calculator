namespace ijs.Internal;

internal static class CsvDictSet {
    static readonly CsvDict SingleJumpDict;
    static readonly CsvDict SingleSpinDict;
    static readonly CsvDict SingleStepSequenceDict;
    static readonly CsvDict PairJumpDict;
    static readonly CsvDict PairStepSequenceDict;
    static readonly CsvDict PairLiftDict;
    static readonly CsvDict PairTwistLiftDict;
    static readonly CsvDict PairThrowJumpDict;
    static readonly CsvDict PairDeathSpiralDict;
    static readonly CsvDict PairSpinDict;
    static readonly CsvDict IceDancePatternDanceDict;
    static readonly CsvDict IceDanceSpinDict;
    static readonly CsvDict IceDanceLiftDict;
    static readonly CsvDict IceDanceTwizzleDict;
    static readonly CsvDict IceDanceStepSequenceDict;
    static readonly CsvDict IceDanceChoreographicElementsDict;

    static CsvDictSet() {
        SingleJumpDict = new CsvDict("code");
        SingleSpinDict = new CsvDict("code");
        SingleStepSequenceDict = new CsvDict("code");
        PairJumpDict = new CsvDict("code");
        PairStepSequenceDict = new CsvDict("code");
        PairLiftDict = new CsvDict("code");
        PairTwistLiftDict = new CsvDict("code");
        PairThrowJumpDict = new CsvDict("code");
        PairDeathSpiralDict = new CsvDict("code");
        PairSpinDict = new CsvDict("code");
        IceDancePatternDanceDict = new CsvDict("code");
        IceDanceSpinDict = new CsvDict("code");
        IceDanceLiftDict = new CsvDict("code");
        IceDanceTwizzleDict = new CsvDict("code");
        IceDanceStepSequenceDict = new CsvDict("code");
        IceDanceChoreographicElementsDict = new CsvDict("code");
    }
    
    internal static void Build() {
        var errors = new List<string>();
        foreach (var (dict, csv) in DictAsEnumerable()) {
            try {
                dict.Build(csv);
            } catch (Exception e) {
                errors.Add(e.Message);
            }
        }

        if (errors.Any()) {
            throw new Exception($"csv error ({errors.Count}) " +
                                $"{string.Join(",", errors)}");
        }
    }

    internal static bool TryGetValues(SportsType sportsType, string code,
        out BaseValue baseValue) {
        var dictList = sportsType switch {
            SportsType.Single => SingleDictAsEnumerable(),
            SportsType.Pair => PairDictAsEnumerable(),
            SportsType.IceDance => IceDanceDictAsEnumerable(),
            _ => throw new ArgumentOutOfRangeException(nameof(sportsType), sportsType, null)
        };
        baseValue = default;
        var baseValueOk = false;
        foreach (var dict in dictList) {
            if (!baseValueOk) {
                baseValueOk = dict.TryGetBaseValue(code, out baseValue);
            }
            if (baseValueOk) {
                return true;
            }
        }
        return false;
    }
    
    static IEnumerable<(CsvDict dict, string csv)> DictAsEnumerable() {
        yield return (SingleJumpDict, SingleCsvText.JumpCsv);
        yield return (SingleSpinDict, SingleCsvText.SpinCsv);
        yield return (SingleStepSequenceDict, SingleCsvText.StepSequenceCsv);
        yield return (PairJumpDict, PairCsvText.JumpCsv);
        yield return (PairStepSequenceDict, PairCsvText.StepSequenceCsv);
        yield return (PairLiftDict, PairCsvText.LiftCsv);
        yield return (PairTwistLiftDict, PairCsvText.TwistLiftCsv);
        yield return (PairThrowJumpDict, PairCsvText.ThrowJumpCsv);
        yield return (PairDeathSpiralDict, PairCsvText.DeathSpiralLiftCsv);
        yield return (PairSpinDict, PairCsvText.SpinCsv);
        yield return (IceDancePatternDanceDict, IceDanceCsvText.PatternDanceCsv);
        yield return (IceDanceSpinDict, IceDanceCsvText.SpinCsv);
        yield return (IceDanceLiftDict, IceDanceCsvText.LiftCsv);
        yield return (IceDanceTwizzleDict, IceDanceCsvText.TwizzleCsv);
        yield return (IceDanceStepSequenceDict, IceDanceCsvText.StepSequenceCsv);
        yield return (IceDanceChoreographicElementsDict, IceDanceCsvText.ChoreographicElementsCsv);
    }
    
    static IEnumerable<CsvDict> SingleDictAsEnumerable() {
        return DictAsEnumerable().Take(3).Select(x => x.dict);
    }
    
    static IEnumerable<CsvDict> PairDictAsEnumerable() {
        return DictAsEnumerable().Skip(3).Take(7).Select(x => x.dict);
    }
    
    static IEnumerable<CsvDict> IceDanceDictAsEnumerable() {
        return DictAsEnumerable().Skip(10).Take(6).Select(x => x.dict);
    }
}
