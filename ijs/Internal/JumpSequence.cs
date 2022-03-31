namespace ijs.Internal; 

public class JumpSequence : IJumpSetElement {
    const double magnification = 0.8;
    readonly CombinationJump jumps;
    
    public JumpSequence() {
        jumps = new CombinationJump();
    }

    public void Build(params IElement[] jumpElements) => jumps.Build(jumpElements);
    public bool Equals(IElement? other) => jumps.Equals(other);
    public string Name => jumps.Name;
    public string FullCode => $"{jumps.FullCode}+SEQ";
    public ElementType ElementType => jumps.ElementType;
    public double BaseValue => BaseValueRounder.MultipleBaseValue(jumps.BaseValue, magnification);
    public int JumpCount => jumps.JumpCount;
}
