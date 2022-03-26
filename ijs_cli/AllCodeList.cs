using System.Text;
using ijs;

namespace ijs_cli; 

public static class AllCodeList {
    public static string Text() {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("シングル");
        foreach (var x in ElementTable.SingleElementsList) {
            stringBuilder.AppendLine($"  {x.Name}: {x.Id.ToString()}");
        }
        stringBuilder.AppendLine("ペア");
        foreach (var x in ElementTable.PairElementsList) {
            stringBuilder.AppendLine($"  {x.Name}: {x.Id.ToString()}");
        }
        stringBuilder.AppendLine("アイスダンス");
        foreach (var x in ElementTable.IceDanceElementsList) {
            stringBuilder.AppendLine($"  {x.Name}: {x.Id.ToString()}");
        }
        return stringBuilder.ToString();
    }
}
