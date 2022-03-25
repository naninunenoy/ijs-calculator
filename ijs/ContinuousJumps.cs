namespace ijs;

public class ContinuousJumps : IElements, IEquatable<IElements> {
    const int maxJumpCount = 3;
    public IReadOnlyList<IElements> Jumps => jumps;
    List<UnitElements> jumps;
    public ContinuousJumps() {
        jumps = new List<UnitElements>();
    }

    public ContinuousJumps Build(params UnitElements[] jumpElements) {
        if (jumpElements.Length == 0) {
            throw new ArgumentException("0回の連続ジャンプは作れません");
        }
        if (jumpElements.Any(x => x.Type.UniqueElementsType is not UniqueElementsType.Jump)) {
            throw new ArgumentException("ジャンプでないエレメンツが含まれています");
        }
        if (jumpElements.Length > maxJumpCount) {
            throw new ArgumentException($"連続ジャンプは最高{maxJumpCount}回です");
        }
        jumps = jumpElements.ToList();
        return this;
    }

    public string Name => jumps
        .Select(x => x.Name)
        .Aggregate("", (total, next) => $"{total}+{next}");
    public string FullCode => jumps
        .Select(x => x.Id.Code)
        .Aggregate("", (total, next) => $"{total}+{next}");
    public float BaseValue => jumps
        .Select(x => x.BaseValue.value)
        .Sum();

    public bool Equals(IElements? other) {
        // code(1AとかFCSp4とか)で同一エレメントかを判定
        var mine = FullCode;
        var his = other?.FullCode.ToLowerInvariant() ?? "";
        return mine.Equals(his);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElements)obj);
    }

    public override int GetHashCode() {
        return FullCode.GetHashCode();
    }
}
