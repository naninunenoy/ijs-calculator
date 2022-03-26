﻿namespace ijs; 

public readonly struct ElementName {
    public readonly string jpn;
    //public readonly string eng;

    public ElementName(string jpn) {
        this.jpn = jpn;
    }

    public override string ToString() {
        return $"{jpn}";
    }

    public static ElementName FromElementsId(ElementId elementId) {
        var lv = $"レベル{elementId.Level.ToEnumString()}";
        return elementId.Code switch {
            ElementCode._1T => new ElementName("1回転トウループ"),
            ElementCode._1S => new ElementName("1回転サルコウ"),
            ElementCode._1Lo => new ElementName("1回転ループ"),
            ElementCode._1Eu => new ElementName("オイラー"),
            ElementCode._1F => new ElementName("1回転フリップ"),
            ElementCode._1Lz => new ElementName("1回転ルッツ"),
            ElementCode._1A => new ElementName("1回転アクセル"),
            ElementCode._2T => new ElementName("2回転トウループ"),
            ElementCode._2S => new ElementName("2回転サルコウ"),
            ElementCode._2Lo => new ElementName("2回転ループ"),
            ElementCode._2F => new ElementName("2回転フリップ"),
            ElementCode._2Lz => new ElementName("2回転ルッツ"),
            ElementCode._2A => new ElementName("2回転アクセル"),
            ElementCode._3T => new ElementName("3回転トウループ"),
            ElementCode._3S => new ElementName("3回転サルコウ"),
            ElementCode._3Lo => new ElementName("3回転ループ"),
            ElementCode._3F => new ElementName("3回転フリップ"),
            ElementCode._3Lz => new ElementName("3回転ルッツ"),
            ElementCode._3A => new ElementName("3回転アクセル"),
            ElementCode._4T => new ElementName("4回転トウループ"),
            ElementCode._4S => new ElementName("4回転サルコウ"),
            ElementCode._4Lo => new ElementName("4回転ループ"),
            ElementCode._4F => new ElementName("4回転フリップ"),
            ElementCode._4Lz => new ElementName("4回転ルッツ"),
            ElementCode._4A => new ElementName("4回転アクセル"),
            ElementCode.USp => new ElementName($"アップライト{lv}"),
            ElementCode.LSp => new ElementName($"レイバック{lv}"),
            ElementCode.CSp => new ElementName($"キャメル{lv}"),
            ElementCode.SSp => new ElementName($"シット{lv}"),
            ElementCode.FUSp => new ElementName($"フライングアップライト{lv}"),
            ElementCode.FLSp => new ElementName($"フライングレイバック{lv}"),
            ElementCode.FCSp => new ElementName($"フライングキャメル{lv}"),
            ElementCode.FSSp => new ElementName($"フライングシット{lv}"),
            ElementCode.CUSp => new ElementName($"足替えアップライト{lv}"),
            ElementCode.FCUSp => new ElementName($"フライング足替えアップライト{lv}"),
            ElementCode.CLSp => new ElementName($"足替えレイバック{lv}"),
            ElementCode.FCLSp => new ElementName($"フライング足替えレイバック{lv}"),
            ElementCode.CCSp => new ElementName($"足替えキャメル{lv}"),
            ElementCode.FCCSp => new ElementName($"フライング足替えキャメル{lv}"),
            ElementCode.CSSp => new ElementName($"足替えシット{lv}"),
            ElementCode.FCSSp => new ElementName($"フライング足替えシット{lv}"),
            ElementCode.CoSp => new ElementName($"コンビネーション{lv}"),
            ElementCode.FCoSp => new ElementName($"フライングコンビネーション{lv}"),
            ElementCode.CCoSp => new ElementName($"足換えコンビネーション{lv}"),
            ElementCode.FCCoSp => new ElementName($"フライング足換えコンビネーション{lv}"),
            ElementCode.StSq => new ElementName($"ステップシークエンス{lv}"),
            ElementCode.ChSq => new ElementName($"コレオグラフィックシークエンス{lv}"),
            ElementCode._1Li => new ElementName($"グループ1{lv}"),
            ElementCode._2Li => new ElementName($"グループ2{lv}"),
            ElementCode._3Li => new ElementName($"グループ3{lv}"),
            ElementCode._4Li => new ElementName($"グループ4{lv}"),
            ElementCode._5TLi => new ElementName($"グループ5 トゥラッソー{lv}"),
            ElementCode._5SLi => new ElementName($"グループ5 ステップインラッソー{lv}"),
            ElementCode._5BLi => new ElementName($"グループ5 バックワードラッソー{lv}"),
            ElementCode._5ALi => new ElementName($"グループ5 アクセルラッソー{lv}"),
            ElementCode._5RLi => new ElementName($"グループ5 リバースラッソー{lv}"),
            ElementCode._1Tw => new ElementName($"1回転ツイストリフト{lv}"),
            ElementCode._2Tw => new ElementName($"2回転ツイストリフト{lv}"),
            ElementCode._3Tw => new ElementName($"3回転ツイストリフト{lv}"),
            ElementCode._4Tw => new ElementName($"4回転ツイストリフト{lv}"),
            ElementCode._1TTh => new ElementName("1回転トウループ"),
            ElementCode._1STh => new ElementName("1回転サルコウ"),
            ElementCode._1LoTh => new ElementName("1回転ループ"),
            ElementCode._1FTh => new ElementName("1回転フリップ"),
            ElementCode._1LzTh => new ElementName("1回転ルッツ"),
            ElementCode._1ATh => new ElementName("1回転アクセル"),
            ElementCode._2TTh => new ElementName("2回転トウループ"),
            ElementCode._2STh => new ElementName("2回転サルコウ"),
            ElementCode._2LoTh => new ElementName("2回転ループ"),
            ElementCode._2FTh => new ElementName("2回転フリップ"),
            ElementCode._2LzTh => new ElementName("2回転ルッツ"),
            ElementCode._2ATh => new ElementName("2回転アクセル"),
            ElementCode._3TTh => new ElementName("3回転トウループ"),
            ElementCode._3STh => new ElementName("3回転サルコウ"),
            ElementCode._3LoTh => new ElementName("3回転ループ"),
            ElementCode._3FTh => new ElementName("3回転フリップ"),
            ElementCode._3LzTh => new ElementName("3回転ルッツ"),
            ElementCode._3ATh => new ElementName("3回転アクセル"),
            ElementCode._4TTh => new ElementName("4回転トウループ"),
            ElementCode._4STh => new ElementName("4回転サルコウ"),
            ElementCode._4LoTh => new ElementName("4回転ループ"),
            ElementCode._4FTh => new ElementName("4回転フリップ"),
            ElementCode._4LzTh => new ElementName("4回転ルッツ"),
            ElementCode.FiDs => new ElementName($"フォアイン{lv}"),
            ElementCode.BiDs => new ElementName($"バックイン{lv}"),
            ElementCode.FoDs => new ElementName($"フォアアウト{lv}"),
            ElementCode.BoDs => new ElementName($"バックアウト{lv}"),
            ElementCode.PiF => new ElementName("ピボットフィギュア"),
            ElementCode.PSp => new ElementName($"ペア{lv}"),
            ElementCode.PCoSp => new ElementName($"ペアコンビネーション{lv}"),
            ElementCode._1BL => new ElementName($"ブルース第1シークエンス{lv}"),
            ElementCode._2BL => new ElementName($"ブルース第2シークエンス{lv}"),
            ElementCode._1MN => new ElementName($"ミッドナイトブルース第1シークエンス{lv}"),
            ElementCode.Sp => new ElementName($"スピン{lv}"),
            ElementCode._CoSp => new ElementName($"コンビネーションスピン{lv}"),
            ElementCode.StaLi => new ElementName($"ステーショナリーリフト{lv}"),
            ElementCode.SlLi => new ElementName($"ストレートラインリフト{lv}"),
            ElementCode.CuLi => new ElementName($"カーブリフト{lv}"),
            ElementCode.RoLi => new ElementName($"ローテーショナルリフト{lv}"),
            ElementCode.STw => new ElementName($"ツイズル・セット{lv}"),
            ElementCode.PSt => new ElementName($"パーシャルステップシークエンス{lv}"),
            ElementCode.MiSt => new ElementName($"ミッドライン{lv}"),
            ElementCode.CiSt => new ElementName($"サーキュラー{lv}"),
            ElementCode.SeSt => new ElementName($"サーペンタイン{lv}"),
            ElementCode.NtMiSt => new ElementName($"非接触ミッドライン{lv}"),
            ElementCode.NtDiSt => new ElementName($"非接触ダイアゴナル{lv}"),
            ElementCode.NtCiSt => new ElementName($"非接触サーキュラー{lv}"),
            ElementCode.ChLi1 => new ElementName("コレオグラフィックダンスリフト"),
            ElementCode.ChSp1 => new ElementName("コレオグラフィックスピニングムーブメント"),
            ElementCode.ChTw1 => new ElementName("コレオグラフィックツイズリングムーブメント"),
            _ => throw new ArgumentOutOfRangeException(nameof(elementId.Code), elementId.Code, null)
        };
    }
}
