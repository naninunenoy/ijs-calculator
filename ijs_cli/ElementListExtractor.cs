using System.Globalization;
using System.Text;
using ijs;

namespace ijs_cli;

public class ElementListExtractor {
    readonly ElementList elementList;

    public ElementListExtractor(ElementList elementList) {
        this.elementList = elementList;
    }

    public string Extract() {
        var stringBuilder = new StringBuilder();
        var index = 1;
        stringBuilder.AppendLine("=================== 内訳 ===================");
        foreach (var x in elementList.List) {
            var score = x.BaseValue.ToString("F2", CultureInfo.InvariantCulture);
            var line = $"{index}. {x.Name}({x.FullCode}): {score}点";
            if (x is SecondHalfElement) {
                line += $" ※後半につき{SecondHalfElement.Magnification:F1}倍加点";
            }
            stringBuilder.AppendLine(line);
            index++;
        }
        stringBuilder.AppendLine("===========================================");
        return stringBuilder.ToString();
    }
}
