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
            .Select((x, i) => {
                var (isSecondHalf, magnitude) = x.IsHalfSecond();
                return new Line(i + 1, x.Name, x.FullCode,
                    x is UnknownElement ? "????" : x.BaseValue.ToString("F2", CultureInfo.InvariantCulture),
                    isSecondHalf ? $"後半につき{magnitude:F1}倍加点" : "");
            })
            .ToArray();
        
        var maxWidth = lines.Max(x => x.GetTotalWidth());
        var maxNameWidth = lines.Max(x => x.GetNameAndCodeWidth());
        var stringBuilder = new StringBuilder();
        const string header = "==== 内訳 ";
        stringBuilder.AppendLine($"{header}{new string('=', maxWidth - header.GetWidth(true))}");
        foreach (var line in lines) {
            stringBuilder.AppendLine(line.ToLineString(maxNameWidth - line.GetNameAndCodeWidth()));
        }
        stringBuilder.AppendLine(new string('-', maxWidth));
        stringBuilder.Append($"{elementList.ToElementsCountDescription()}");
        stringBuilder.AppendLine(new string('=', maxWidth));
        return stringBuilder.ToString();
    }

    readonly struct Line {
        readonly int no;
        readonly string name;
        readonly string code;
        readonly string score;
        readonly string supplement;

        public Line(int no, string name, string code, string score, string supplement) {
            this.no = no;
            this.name = name;
            this.code = code;
            this.score = score;
            this.supplement = supplement;
        }

        public int GetNameAndCodeWidth() =>  name.GetWidth(true) + code.GetWidth(false);

        public int GetTotalWidth() => name.GetWidth(true) + code.GetWidth(false) +
                                      2 + ". ".Length + " ()".Length + ": ".Length + 5;

        public string ToLineString(int spaceNumBetweenNameAndCode) {
            return $"{no,2}. {name}{new string(' ', spaceNumBetweenNameAndCode)} ({code})" +
                   $": {score,5} {supplement}";
        }
    }
}
