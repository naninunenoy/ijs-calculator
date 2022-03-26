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
        var lineNumber = 1;
        var lines = new List<Line>();
        foreach (var x in elementList.List) {
            var header = $"{lineNumber++,3}. {x.Name}({x.FullCode}):";
            var content = x.BaseValue.ToString("F2", CultureInfo.InvariantCulture);
            if (x is SecondHalfElement) {
                content += $" ※後半につき{SecondHalfElement.Magnification:F1}倍加点";
            }
            lines.Add(new Line(header, content));
        }

        var maxHeaderLength = lines.Max(x => x.GetHeaderLength());
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("==== 内訳 ===============================================================");
        foreach (var line in lines) {
            var spaceNum = maxHeaderLength - line.GetHeaderLength();
            stringBuilder.AppendLine(line.ToString(spaceNum));
        }
        stringBuilder.AppendLine("=========================================================================");
        return stringBuilder.ToString();
    }

    readonly struct Line {
        const int tabLength = 8;
        readonly string header;
        readonly string content;
        public Line(string header, string content) {
            this.header = header;
            this.content = content;
        }
        public int GetHeaderLength() {
            return header.GetWidth(true);
        }

        public string ToString(int spaceNum) {
            return $"{header}{new string(' ', spaceNum + 1)}{content}";
        }
    }
}
