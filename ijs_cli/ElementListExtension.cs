using System.Text;
using ijs;

namespace ijs_cli; 

public static class ElementListExtension {
    public static string ToElementsCountDescription(this ElementList elementList) {
        var stringBuilder = new StringBuilder();
        var jumpCount = elementList.JumpCount();
        var spinCount = elementList.SpinCount();
        var stepSequenceCount = elementList.StepSequenceCount();
        var liftCount = elementList.LiftCount();
        var twistLiftCount = elementList.TwistLiftCount();
        var throwJumpCount = elementList.ThrowJumpCount();
        var deathSpiralCount = elementList.DeathSpiralCount();
        var patternDanceCount = elementList.PatternDanceCount();
        var twizzleCount = elementList.TwizzleCount();
        var choreographicElementsCount = elementList.ChoreographicElementsCount();

        const string header = " *  ";
        if (jumpCount > 0) {
            stringBuilder.AppendLine($"{header }ジャンプ: {jumpCount}個");
            const string header2 = "    ";
            // 後半演技のカウント
            var secondHalfCount = elementList.SecondHalfCount();
            if (secondHalfCount > 0) {
                stringBuilder.AppendLine($"{header2}- 後半: {secondHalfCount}個");
            }
            // 連続ジャンプのカウント
            var combinationJumpCount = elementList.CombinationJumpCount();
            if (combinationJumpCount > 0) {
                stringBuilder.AppendLine($"{header2}- 連続ジャンプ: {combinationJumpCount}個");
                var combination2JumpsCount = elementList.Combination2JumpsCount();
                if (combination2JumpsCount > 0) {
                    stringBuilder.AppendLine($"{header2}  - 2連続: {combination2JumpsCount}個");
                }
                var combination3JumpsCount = elementList.Combination3JumpsCount();
                if (combination3JumpsCount > 0) {
                    stringBuilder.AppendLine($"{header2}  - 3連続: {combination3JumpsCount}個");
                }
            }
        }
        if (spinCount > 0) {
            stringBuilder.AppendLine($"{header}スピン: {spinCount}個");
        }
        if (stepSequenceCount > 0) {
            stringBuilder.AppendLine($"{header}ステップシークエンス: {stepSequenceCount}個");
        }
        if (liftCount > 0) {
            stringBuilder.AppendLine($"{header}ツイストリフト: {liftCount}個");
        }
        if (twistLiftCount > 0) {
            stringBuilder.AppendLine($"{header}ツイストリフト: {twistLiftCount}個");
        }
        if (throwJumpCount > 0) {
            stringBuilder.AppendLine($"{header}スロージャンプ: {throwJumpCount}個");
        }
        if (deathSpiralCount > 0) {
            stringBuilder.AppendLine($"{header}デススパイラル: {deathSpiralCount}個");
        }
        if (patternDanceCount > 0) {
            stringBuilder.AppendLine($"{header}パターンダンス: {patternDanceCount}個");
        }
        if (twizzleCount > 0) {
            stringBuilder.AppendLine($"{header}ツイズル: {twizzleCount}個");
        }
        if (choreographicElementsCount > 0) {
            stringBuilder.AppendLine($"{header}コレオグラフィックエレメンツ: {choreographicElementsCount}個");
        }

        return stringBuilder.ToString();
    }
}