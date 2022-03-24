namespace ijs;

public static class ElementsIdTable {
    public static IEnumerable<ElementsId> SingleElementsIds() {
        foreach (var code in (ElementsCode[])Enum.GetValues(typeof(ElementsCode))) {
            // ジャンプ
            if (code is >= ElementsCode._1T and <= ElementsCode._4A) {
                yield return new ElementsId(code);
            }
            // スピン
            if (code is >= ElementsCode.USp and <= ElementsCode.FCCoSp) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // ステップシーケンス
            if (code is >= ElementsCode.StSq and <= ElementsCode.ChSq) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
        }
    }

    public static IEnumerable<ElementsId> PairElementsIds() {
        foreach (var code in (ElementsCode[])Enum.GetValues(typeof(ElementsCode))) {
            // ジャンプ
            if (code is >= ElementsCode._1T and <= ElementsCode._4A) {
                yield return new ElementsId(code);
            }
            // ステップシーケンス
            if (code is >= ElementsCode.StSq and <= ElementsCode.ChSq) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // リフト
            if (code is >= ElementsCode._1Li and <= ElementsCode._5RLi) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // ツイストリフト
            if (code is >= ElementsCode._1Tw and <= ElementsCode._4Tw) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // スロージャンプ
            if (code is >= ElementsCode._1TTh and <= ElementsCode._4LzTh) {
                yield return new ElementsId(code);
            }
            // デススパイラル
            if (code is >= ElementsCode.FiDs and <= ElementsCode.PiF) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // スピン
            if (code is >= ElementsCode.PSp and <= ElementsCode.PCoSp) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
        }
    }

    public static IEnumerable<ElementsId> IceDanceElementsIds() {
        foreach (var code in (ElementsCode[])Enum.GetValues(typeof(ElementsCode))) {
            // パターンダンス
            if (code is >= ElementsCode._1BL and <= ElementsCode._1Mn) {
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // スピン
            if (code is >= ElementsCode.Sp and <= ElementsCode.CoSp) {
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // リフト
            if (code is >= ElementsCode.StaLi and <= ElementsCode.RoLi) {
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // ツイズル
            if (code is ElementsCode.STw) {
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // ステップシーケンス
            if (code is >= ElementsCode.PSt and <= ElementsCode.NtCiSt) {
                yield return new ElementsId(code, ElementsLevel.LvB);
                yield return new ElementsId(code, ElementsLevel.Lv1);
                yield return new ElementsId(code, ElementsLevel.Lv2);
                yield return new ElementsId(code, ElementsLevel.Lv3);
                yield return new ElementsId(code, ElementsLevel.Lv4);
            }
            // コレオグラフィックエレメンツ
            if (code is >= ElementsCode.ChLi1 and <= ElementsCode.ChTw1) {
                yield return new ElementsId(code);
            }
        }
    }
}
