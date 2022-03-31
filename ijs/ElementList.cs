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
    public (double, string) TotalBaseValue() {
        var sum = list.Select(x => x.BaseValue).Sum();
        // sum は既に掛け算の結果が四捨五入された値の合計である想定
        return (sum, BaseValueRounder.GetRoundF2String(sum));
    }

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
