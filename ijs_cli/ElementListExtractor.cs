using System.Globalization;
using System.Text;
using ijs;
using Microsoft.VisualBasic;

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
            var header = $"{lineNumber++}. {x.Name}({x.FullCode}):";
            var content = x.BaseValue.ToString("F2", CultureInfo.InvariantCulture);
            if (x is SecondHalfElement) {
                content += $" ※後半につき{SecondHalfElement.Magnification:F1}倍加点";
            }
            lines.Add(new Line(header, content));
        }

        var maxHeaderLength = lines.Max(x => x.GetHeaderLength());
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("=================== 内訳 ===================");
        foreach (var line in lines) {
            var spaceNum = maxHeaderLength - line.GetHeaderLength();
            stringBuilder.AppendLine(line.ToString(spaceNum));
        }
        stringBuilder.AppendLine("===========================================");
        return stringBuilder.ToString();
    }

    readonly struct Line {
        const int TabLength = 8;
        public readonly string Header;
        public readonly string Content;
        public Line(string header, string content) {
            Header = header;
            Content = content;
        }
        public int GetHeaderLength() {
            return Encoding.Unicode.GetBytes(Header).Length;
        }
        public string ToString(int spaceNum) {
            var tabNum = spaceNum / TabLength;
            return $"{Header}{new string('\t', tabNum < 1 ? 1 : tabNum)}{Content}";
        }
    }
}
