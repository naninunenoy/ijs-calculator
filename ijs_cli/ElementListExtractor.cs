using System.Globalization;
using System.Text;
using EastAsianWidthDotNet;
using ijs;

namespace ijs_cli;

public class ElementListExtractor {
    readonly ElementList elementList;

    public ElementListExtractor(ElementList elementList) {
        this.elementList = elementList;
    }

    public string Extract() {
        var lines = elementList.List
            .Select((x, i) => new Line(i + 1, x.Name, x.FullCode, x.BaseValue,
                x is SecondHalfElement ? $"後半につき{SecondHalfElement.Magnification:F1}倍加点" : ""))
            .ToArray();
        
        var maxWidth = lines.Max(x => x.GetWidth());
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("==== 内訳 ===============================================================");
        foreach (var line in lines) {
            stringBuilder.AppendLine(line.ToLineString(maxWidth - line.GetWidth()));
        }
        stringBuilder.AppendLine("=========================================================================");
        return stringBuilder.ToString();
    }

    readonly struct Line {
        readonly int no;
        readonly string name;
        readonly string code;
        readonly double score;
        readonly string supplement;

        public Line(int no, string name, string code, double score, string supplement) {
            this.no = no;
            this.name = name;
            this.code = code;
            this.score = score;
            this.supplement = supplement;
        }

        public int GetWidth() =>  name.GetWidth(true) + code.GetWidth(false);

        public string ToLineString(int spaceNumBetweenNameAndCode) {
            return $"{no,2}. {name}{new string(' ', spaceNumBetweenNameAndCode)}({code})" +
                   $": {score.ToString("F2", CultureInfo.InvariantCulture),5} {supplement}";
        }
    }
}
