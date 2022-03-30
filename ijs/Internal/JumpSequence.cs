namespace ijs.Internal; 

public class JumpSequence : IElement {
    public const double Magnification = 0.8;
    const int maxJumpCount = 3;
    readonly CombinationJump jumps;
    
    public JumpSequence() {
        jumps = new CombinationJump();
    }

    public void Build(params IElement[] jumpElements) => jumps.Build(jumpElements);
    public bool Equals(IElement? other) => jumps.Equals(other);
    public string Name => jumps.Name;
    public string FullCode => $"{jumps.FullCode}+SEQ";
    public ElementType ElementType => jumps.ElementType;
    public double BaseValue => jumps.BaseValue * Magnification;
}
