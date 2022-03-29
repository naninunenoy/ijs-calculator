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
            var secondHalfCount = elementList.SecondHalfCount();
            stringBuilder.AppendLine($"{header}ジャンプ: {jumpCount}個 (その内後半が{secondHalfCount}個)");
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