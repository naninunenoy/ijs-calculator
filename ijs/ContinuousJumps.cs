namespace ijs;

public class ContinuousJumps : IElements {
    const int maxJumpCount = 3;
    public IReadOnlyList<IElements> Jumps => jumps;
    List<IElements> jumps;
    public ContinuousJumps() {
        jumps = new List<IElements>();
    }

    public void Build(params IElements[] jumpElements) {
        if (jumpElements.Any(x => x.ElementsType is not ElementsType.Jump)) {
            throw new ArgumentException("ジャンプでないエレメンツが含まれています");
        }
        if (jumpElements.Length > maxJumpCount) {
            throw new ArgumentException($"連続ジャンプは最高{maxJumpCount}回です");
        }
        jumps = jumpElements.ToList();
    }

    public string Name => string.Join("+", jumps.Select(x => x.Name));
    public string FullCode => string.Join("+", jumps.Select(x => x.FullCode));
    public float BaseValue => jumps
        .Select(x => x.BaseValue)
        .Sum();
    public ElementsType ElementsType => ElementsType.Jump;

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
