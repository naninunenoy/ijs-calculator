using ijs.Internal;

namespace ijs; 

public class ElementList {
    readonly List<IElement> list;
    public IReadOnlyList<IElement> List => list;

    public ElementList() {
        list = new List<IElement>();
    }
    
    public void AddElement(IElement element) {
        list.Add(element);
    }
    
    internal void Build(params IElement[] elements) {
        foreach (var element in elements) {
            AddElement(element);
        }
    }

    int CountCombinationJumpCountAt(int index) {
        if (index < 0 || list.Count <= index) {
            return 0;
        }

        var element = list[index];
        if (element is SecondHalfElement secondHalfElement) {
            // 後半演技かつ連続ジャンプの場合両方の要素を取り出す必要がある
            element = secondHalfElement.OriginalElement;
        }
        
        try {
            return ((IJumpSetElement)element).JumpCount;
        } catch {
            return 0;
        }
    }

    public int CombinationJumpCount() => list.Where((_,i) => CountCombinationJumpCountAt(i) > 1).Count();
    public int Combination3JumpsCount() => list.Where((_, i) => CountCombinationJumpCountAt(i) == 3).Count();
    public int Combination2JumpsCount() => list.Where((_, i) => CountCombinationJumpCountAt(i) == 2).Count();
    public double TotalBaseValue() => list.Select(x => x.BaseValue).Sum();
    public int TotalCount() => list.Count;
    public int SecondHalfCount() => list.Count(x => x is SecondHalfElement);
    public int JumpCount() => list.Count(x => x.ElementType is ElementType.Jump);
    public int SpinCount() => list.Count(x => x.ElementType is ElementType.Spin);
    public int StepSequenceCount() => list.Count(x => x.ElementType is ElementType.StepSequence);
    public int LiftCount() => list.Count(x => x.ElementType is ElementType.Lift);
    public int TwistLiftCount() => list.Count(x => x.ElementType is ElementType.TwistLift);
    public int ThrowJumpCount() => list.Count(x => x.ElementType is ElementType.ThrowJump);
    public int DeathSpiralCount() => list.Count(x => x.ElementType is ElementType.DeathSpiral);
    public int PatternDanceCount() => list.Count(x => x.ElementType is ElementType.PatternDance);
    public int TwizzleCount() => list.Count(x => x.ElementType is ElementType.Twizzle);
    public int ChoreographicElementsCount() => list.Count(x => x.ElementType is ElementType.ChoreographicElements);
}