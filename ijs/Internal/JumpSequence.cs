namespace ijs.Internal; 

public class JumpSequence : IElement {
    public const double Magnification = 0.8;
    const int maxJumpCount = 3;
    readonly CombinationJump jumps;
    
    public JumpSequence() {
        jumps = new CombinationJump();
    }

    public void Build(params IElement[] jumpElements) {
        if (jumpElements.Length < 1) {
            throw new ArgumentException("ジャンプの数が足りていません");
        }
        if (jumpElements.Any(x => x.ElementType is not ElementType.Jump)) {
            throw new ArgumentException("ジャンプでないエレメンツが含まれています");
        }
        if (jumpElements.Length > maxJumpCount) {
            throw new ArgumentException($"ジャンプシークエンスは最高{maxJumpCount}回です");
        }
        jumps.Build(jumpElements);
    }

    public bool Equals(IElement? other) {
        return jumps.Equals(other);
    }

    public string Name => jumps.Name;
    public string FullCode => $"{jumps.FullCode}+SEQ";
    public ElementType ElementType => jumps.ElementType;
    public double BaseValue => jumps.BaseValue * Magnification;
}
