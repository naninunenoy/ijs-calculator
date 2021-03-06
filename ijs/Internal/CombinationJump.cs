namespace ijs.Internal;

internal class CombinationJump : IJumpSetElement {
    const int maxJumpCount = 3;
    List<IElement> jumps;
    public CombinationJump() {
        jumps = new List<IElement>();
    }

    public void Build(params IElement[] jumpElements) {
        if (jumpElements.Length < 1) {
            throw new ArgumentException("ジャンプの数が足りていません");
        }
        if (jumpElements.Any(x => x.ElementType is not ElementType.Jump)) {
            throw new ArgumentException("ジャンプでないエレメンツが含まれています");
        }
        if (jumpElements.Length > maxJumpCount) {
            throw new ArgumentException($"連続ジャンプは最高{maxJumpCount}回です");
        }
        jumps = jumpElements.ToList();
    }

    public string Name => string.Join(" + ", jumps.Select(x => x.Name));
    public string FullCode => string.Join("+", jumps.Select(x => x.FullCode));
    public double BaseValue => jumps.Sum(x => x.BaseValue);
    public ElementType ElementType => ElementType.Jump;
    public int JumpCount => jumps.Count;

    public bool Equals(IElement? other) {
        // code(1AとかFCSp4とか)で同一エレメントかを判定
        var mine = FullCode;
        var his = other?.FullCode.ToLowerInvariant() ?? "";
        return mine.Equals(his);
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((IElement)obj);
    }

    public override int GetHashCode() {
        return FullCode.GetHashCode();
    }
}
