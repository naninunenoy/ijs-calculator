﻿using System.Globalization;

namespace ijs;

/// <summary>
/// 基礎点
/// </summary>
internal readonly struct BaseValue {
    public readonly double value;
    internal BaseValue(double value) {
        this.value = value;
    }

    public override string ToString() {
        return $"value={value.ToString(CultureInfo.InvariantCulture)}";
    }

    public static BaseValue FromElementsId(ElementId elementId) {
        return new BaseValue(0);//TODO
        /*
        var lv = elementId.Level;
        var value = elementId.Code switch {
            ElementCode._1T => 0.4,
            ElementCode._1S => 0.4,
            ElementCode._1Lo => 0.5,
            ElementCode._1Eu => 0.5,
            ElementCode._1F => 0.5,
            ElementCode._1Lz => 0.6,
            ElementCode._1A => 1.1,
            ElementCode._2T => 1.3,
            ElementCode._2S => 1.3,
            ElementCode._2Lo => 1.7,
            ElementCode._2F => 1.8,
            ElementCode._2Lz => 2.1,
            ElementCode._2A => 3.3,
            ElementCode._3T => 4.2,
            ElementCode._3S => 4.3,
            ElementCode._3Lo => 4.9,
            ElementCode._3F => 5.3,
            ElementCode._3Lz => 5.9,
            ElementCode._3A => 8.0,
            ElementCode._4T => 9.5,
            ElementCode._4S => 9.7,
            ElementCode._4Lo => 10.5,
            ElementCode._4F => 11.0,
            ElementCode._4Lz => 11.5,
            ElementCode._4A => 12.5,
            ElementCode.USp when lv is ElementLevel.LvB => 1.0,
            ElementCode.USp when lv is ElementLevel.Lv1 => 1.2,
            ElementCode.USp when lv is ElementLevel.Lv2 => 1.5,
            ElementCode.USp when lv is ElementLevel.Lv3 => 1.9,
            ElementCode.USp when lv is ElementLevel.Lv4 => 2.4,
            ElementCode.LSp when lv is ElementLevel.LvB => 1.2,
            ElementCode.LSp when lv is ElementLevel.Lv1 => 1.5,
            ElementCode.LSp when lv is ElementLevel.Lv2 => 1.9,
            ElementCode.LSp when lv is ElementLevel.Lv3 => 2.4,
            ElementCode.LSp when lv is ElementLevel.Lv4 => 2.7,
            ElementCode.CSp when lv is ElementLevel.LvB => 1.1,
            ElementCode.CSp when lv is ElementLevel.Lv1 => 1.4,
            ElementCode.CSp when lv is ElementLevel.Lv2 => 1.8,
            ElementCode.CSp when lv is ElementLevel.Lv3 => 2.3,
            ElementCode.CSp when lv is ElementLevel.Lv4 => 2.6,
            ElementCode.SSp when lv is ElementLevel.LvB => 1.1,
            ElementCode.SSp when lv is ElementLevel.Lv1 => 1.3,
            ElementCode.SSp when lv is ElementLevel.Lv2 => 1.6,
            ElementCode.SSp when lv is ElementLevel.Lv3 => 2.1,
            ElementCode.SSp when lv is ElementLevel.Lv4 => 2.5,
            ElementCode.FUSp when lv is ElementLevel.LvB => 1.5,
            ElementCode.FUSp when lv is ElementLevel.Lv1 => 1.7,
            ElementCode.FUSp when lv is ElementLevel.Lv2 => 2.0,
            ElementCode.FUSp when lv is ElementLevel.Lv3 => 2.4,
            ElementCode.FUSp when lv is ElementLevel.Lv4 => 2.9,
            ElementCode.FLSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.FLSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.FLSp when lv is ElementLevel.Lv2 => 2.4,
            ElementCode.FLSp when lv is ElementLevel.Lv3 => 2.9,
            ElementCode.FLSp when lv is ElementLevel.Lv4 => 3.2,
            ElementCode.FCSp when lv is ElementLevel.LvB => 1.6,
            ElementCode.FCSp when lv is ElementLevel.Lv1 => 1.9,
            ElementCode.FCSp when lv is ElementLevel.Lv2 => 2.3,
            ElementCode.FCSp when lv is ElementLevel.Lv3 => 2.8,
            ElementCode.FCSp when lv is ElementLevel.Lv4 => 3.2,
            ElementCode.FSSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.FSSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.FSSp when lv is ElementLevel.Lv2 => 2.3,
            ElementCode.FSSp when lv is ElementLevel.Lv3 => 2.6,
            ElementCode.FSSp when lv is ElementLevel.Lv4 => 3.0,
            ElementCode.CUSp or ElementCode.FCUSp when lv is ElementLevel.LvB => 1.5,
            ElementCode.CUSp or ElementCode.FCUSp when lv is ElementLevel.Lv1 => 1.7,
            ElementCode.CUSp or ElementCode.FCUSp when lv is ElementLevel.Lv2 => 2.0,
            ElementCode.CUSp or ElementCode.FCUSp when lv is ElementLevel.Lv3 => 2.4,
            ElementCode.CUSp or ElementCode.FCUSp when lv is ElementLevel.Lv4 => 2.9,
            ElementCode.CLSp or ElementCode.FCLSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.CLSp or ElementCode.FCLSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.CLSp or ElementCode.FCLSp when lv is ElementLevel.Lv2 => 2.4,
            ElementCode.CLSp or ElementCode.FCLSp when lv is ElementLevel.Lv3 => 2.9,
            ElementCode.CLSp or ElementCode.FCLSp when lv is ElementLevel.Lv4 => 3.2,
            ElementCode.CCSp or ElementCode.FCCSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.CCSp or ElementCode.FCCSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.CCSp or ElementCode.FCCSp when lv is ElementLevel.Lv2 => 2.3,
            ElementCode.CCSp or ElementCode.FCCSp when lv is ElementLevel.Lv3 => 2.8,
            ElementCode.CCSp or ElementCode.FCCSp when lv is ElementLevel.Lv4 => 3.2,
            ElementCode.CSSp or ElementCode.FCSSp when lv is ElementLevel.LvB => 1.6,
            ElementCode.CSSp or ElementCode.FCSSp when lv is ElementLevel.Lv1 => 1.9,
            ElementCode.CSSp or ElementCode.FCSSp when lv is ElementLevel.Lv2 => 2.3,
            ElementCode.CSSp or ElementCode.FCSSp when lv is ElementLevel.Lv3 => 2.6,
            ElementCode.CSSp or ElementCode.FCSSp when lv is ElementLevel.Lv4 => 3.0,
            ElementCode.CoSp or ElementCode.FCoSp when lv is ElementLevel.LvB => 1.5,
            ElementCode.CoSp or ElementCode.FCoSp when lv is ElementLevel.Lv1 => 1.7,
            ElementCode.CoSp or ElementCode.FCoSp when lv is ElementLevel.Lv2 => 2.0,
            ElementCode.CoSp or ElementCode.FCoSp when lv is ElementLevel.Lv3 => 2.5,
            ElementCode.CoSp or ElementCode.FCoSp when lv is ElementLevel.Lv4 => 3.0,
            ElementCode.CCoSp or ElementCode.FCCoSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.CCoSp or ElementCode.FCCoSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.CCoSp or ElementCode.FCCoSp when lv is ElementLevel.Lv2 => 2.5,
            ElementCode.CCoSp or ElementCode.FCCoSp when lv is ElementLevel.Lv3 => 3.0,
            ElementCode.CCoSp or ElementCode.FCCoSp when lv is ElementLevel.Lv4 => 3.5,
            ElementCode.StSq when lv is ElementLevel.LvB => 1.5,
            ElementCode.StSq when lv is ElementLevel.Lv1 => 1.8,
            ElementCode.StSq when lv is ElementLevel.Lv2 => 2.6,
            ElementCode.StSq when lv is ElementLevel.Lv3 => 3.3,
            ElementCode.StSq when lv is ElementLevel.Lv4 => 3.9,
            ElementCode.ChSq => 3.0,
            ElementCode._1Li when lv is ElementLevel.LvB => 1.4,
            ElementCode._1Li when lv is ElementLevel.Lv1 => 1.5,
            ElementCode._1Li when lv is ElementLevel.Lv2 => 1.7,
            ElementCode._1Li when lv is ElementLevel.Lv3 => 1.9,
            ElementCode._1Li when lv is ElementLevel.Lv4 => 2.1,
            ElementCode._2Li when lv is ElementLevel.LvB => 1.5,
            ElementCode._2Li when lv is ElementLevel.Lv1 => 1.9,
            ElementCode._2Li when lv is ElementLevel.Lv2 => 2.3,
            ElementCode._2Li when lv is ElementLevel.Lv3 => 2.7,
            ElementCode._2Li when lv is ElementLevel.Lv4 => 3.1,
            ElementCode._3Li or ElementCode._4Li when lv is ElementLevel.LvB => 3.5,
            ElementCode._3Li or ElementCode._4Li when lv is ElementLevel.Lv1 => 3.9,
            ElementCode._3Li or ElementCode._4Li when lv is ElementLevel.Lv2 => 4.3,
            ElementCode._3Li or ElementCode._4Li when lv is ElementLevel.Lv3 => 4.7,
            ElementCode._3Li or ElementCode._4Li when lv is ElementLevel.Lv4 => 5.1,
            ElementCode._5TLi or ElementCode._5SLi when lv is ElementLevel.LvB => 4.6,
            ElementCode._5TLi or ElementCode._5SLi when lv is ElementLevel.Lv1 => 5.0,
            ElementCode._5TLi or ElementCode._5SLi when lv is ElementLevel.Lv2 => 5.4,
            ElementCode._5TLi or ElementCode._5SLi when lv is ElementLevel.Lv3 => 5.8,
            ElementCode._5TLi or ElementCode._5SLi when lv is ElementLevel.Lv4 => 6.2,
            ElementCode._5BLi when lv is ElementLevel.LvB => 5.0,
            ElementCode._5BLi when lv is ElementLevel.Lv1 => 5.4,
            ElementCode._5BLi when lv is ElementLevel.Lv2 => 5.8,
            ElementCode._5BLi when lv is ElementLevel.Lv3 => 6.2,
            ElementCode._5BLi when lv is ElementLevel.Lv4 => 6.5,
            ElementCode._5ALi or ElementCode._5RLi when lv is ElementLevel.LvB => 5.4,
            ElementCode._5ALi or ElementCode._5RLi when lv is ElementLevel.Lv1 => 5.8,
            ElementCode._5ALi or ElementCode._5RLi when lv is ElementLevel.Lv2 => 6.2,
            ElementCode._5ALi or ElementCode._5RLi when lv is ElementLevel.Lv3 => 6.6,
            ElementCode._5ALi or ElementCode._5RLi when lv is ElementLevel.Lv4 => 7.0,
            ElementCode._1Tw when lv is ElementLevel.LvB => 0.9,
            ElementCode._1Tw when lv is ElementLevel.Lv1 => 1.1,
            ElementCode._1Tw when lv is ElementLevel.Lv2 => 1.3,
            ElementCode._1Tw when lv is ElementLevel.Lv3 => 1.5,
            ElementCode._1Tw when lv is ElementLevel.Lv4 => 1.7,
            ElementCode._2Tw when lv is ElementLevel.LvB => 2.6,
            ElementCode._2Tw when lv is ElementLevel.Lv1 => 2.8,
            ElementCode._2Tw when lv is ElementLevel.Lv2 => 3.0,
            ElementCode._2Tw when lv is ElementLevel.Lv3 => 3.2,
            ElementCode._2Tw when lv is ElementLevel.Lv4 => 3.4,
            ElementCode._3Tw when lv is ElementLevel.LvB => 4.8,
            ElementCode._3Tw when lv is ElementLevel.Lv1 => 5.1,
            ElementCode._3Tw when lv is ElementLevel.Lv2 => 5.4,
            ElementCode._3Tw when lv is ElementLevel.Lv3 => 5.7,
            ElementCode._3Tw when lv is ElementLevel.Lv4 => 6.0,
            ElementCode._4Tw when lv is ElementLevel.LvB => 6.4,
            ElementCode._4Tw when lv is ElementLevel.Lv1 => 6.8,
            ElementCode._4Tw when lv is ElementLevel.Lv2 => 7.2,
            ElementCode._4Tw when lv is ElementLevel.Lv3 => 7.6,
            ElementCode._4Tw when lv is ElementLevel.Lv4 => 8.0,
            ElementCode._1TTh => 1.1,
            ElementCode._1STh => 1.1,
            ElementCode._1LoTh => 1.4,
            ElementCode._1FTh => 1.4,
            ElementCode._1LzTh => 2.2,
            ElementCode._1ATh => 2.5,
            ElementCode._2TTh => 2.5,
            ElementCode._2STh => 2.5,
            ElementCode._2LoTh => 2.8,
            ElementCode._2FTh => 3.0,
            ElementCode._2LzTh => 3.0,
            ElementCode._2ATh => 4.0,
            ElementCode._3TTh => 4.4,
            ElementCode._3STh => 4.4,
            ElementCode._3LoTh => 5.0,
            ElementCode._3FTh => 5.3,
            ElementCode._3LzTh => 5.3,
            ElementCode._3ATh => 6.0,
            ElementCode._4TTh => 6.5,
            ElementCode._4STh => 6.5,
            ElementCode._4LoTh => 7.0,
            ElementCode._4FTh => 7.5,
            ElementCode._4LzTh => 7.5,
            ElementCode.FiDs or ElementCode.BiDs when lv is ElementLevel.LvB => 2.6,
            ElementCode.FiDs or ElementCode.BiDs when lv is ElementLevel.Lv1 => 2.9,
            ElementCode.FiDs or ElementCode.BiDs when lv is ElementLevel.Lv2 => 3.2,
            ElementCode.FiDs or ElementCode.BiDs when lv is ElementLevel.Lv3 => 3.5,
            ElementCode.FiDs or ElementCode.BiDs when lv is ElementLevel.Lv4 => 3.8,
            ElementCode.FoDs or ElementCode.BoDs when lv is ElementLevel.LvB => 3.1,
            ElementCode.FoDs or ElementCode.BoDs when lv is ElementLevel.Lv1 => 3.5,
            ElementCode.FoDs or ElementCode.BoDs when lv is ElementLevel.Lv2 => 3.9,
            ElementCode.FoDs or ElementCode.BoDs when lv is ElementLevel.Lv3 => 4.3,
            ElementCode.FoDs or ElementCode.BoDs when lv is ElementLevel.Lv4 => 4.7,
            ElementCode.PiF => 2.2,
            ElementCode.PSp when lv is ElementLevel.LvB => 1.7,
            ElementCode.PSp when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.PSp when lv is ElementLevel.Lv2 => 2.5,
            ElementCode.PSp when lv is ElementLevel.Lv3 => 3.0,
            ElementCode.PSp when lv is ElementLevel.Lv4 => 3.5,
            ElementCode.PCoSp when lv is ElementLevel.LvB => 2.5,
            ElementCode.PCoSp when lv is ElementLevel.Lv1 => 3.0,
            ElementCode.PCoSp when lv is ElementLevel.Lv2 => 3.5,
            ElementCode.PCoSp when lv is ElementLevel.Lv3 => 4.0,
            ElementCode.PCoSp when lv is ElementLevel.Lv4 => 4.5,
            //ElementsCode._1BL when lv is ElementsLevel.LvB => 0.0,
            ElementCode._1BL when lv is ElementLevel.Lv1 => 3.2,
            ElementCode._1BL when lv is ElementLevel.Lv2 => 3.8,
            ElementCode._1BL when lv is ElementLevel.Lv3 => 4.4,
            ElementCode._1BL when lv is ElementLevel.Lv4 => 5.0,
            //ElementsCode._2BL when lv is ElementsLevel.LvB => 0.0,
            ElementCode._2BL when lv is ElementLevel.Lv1 => 3.2,
            ElementCode._2BL when lv is ElementLevel.Lv2 => 3.8,
            ElementCode._2BL when lv is ElementLevel.Lv3 => 4.4,
            ElementCode._2BL when lv is ElementLevel.Lv4 => 5.0,
            //ElementsCode._1Mn when lv is ElementsLevel.LvB => 0.0,
            ElementCode._1MN when lv is ElementLevel.Lv1 => 3.2,
            ElementCode._1MN when lv is ElementLevel.Lv2 => 3.8,
            ElementCode._1MN when lv is ElementLevel.Lv3 => 4.4,
            ElementCode._1MN when lv is ElementLevel.Lv4 => 5.0,
            //ElementsCode.Sp when lv is ElementsLevel.LvB => 0.0,
            ElementCode.Sp when lv is ElementLevel.Lv1 => 2.6,
            ElementCode.Sp when lv is ElementLevel.Lv2 => 3.6,
            ElementCode.Sp when lv is ElementLevel.Lv3 => 4.6,
            ElementCode.Sp when lv is ElementLevel.Lv4 => 5.6,
            //ElementsCode.CoSp when lv is ElementsLevel.LvB => 0.0,
            ElementCode._CoSp when lv is ElementLevel.Lv1 => 2.6,
            ElementCode._CoSp when lv is ElementLevel.Lv2 => 3.6,
            ElementCode._CoSp when lv is ElementLevel.Lv3 => 4.6,
            ElementCode._CoSp when lv is ElementLevel.Lv4 => 5.6,
            //ElementsCode.StaLi when lv is ElementsLevel.LvB => 0.0,
            ElementCode.StaLi when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.StaLi when lv is ElementLevel.Lv2 => 3.0,
            ElementCode.StaLi when lv is ElementLevel.Lv3 => 4.0,
            ElementCode.StaLi when lv is ElementLevel.Lv4 => 4.5,
            //ElementsCode.SlLi when lv is ElementsLevel.LvB => 0.0,
            ElementCode.SlLi when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.SlLi when lv is ElementLevel.Lv2 => 3.0,
            ElementCode.SlLi when lv is ElementLevel.Lv3 => 4.0,
            ElementCode.SlLi when lv is ElementLevel.Lv4 => 4.5,
            //ElementsCode.CuLi when lv is ElementsLevel.LvB => 0.0,
            ElementCode.CuLi when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.CuLi when lv is ElementLevel.Lv2 => 3.0,
            ElementCode.CuLi when lv is ElementLevel.Lv3 => 4.0,
            ElementCode.CuLi when lv is ElementLevel.Lv4 => 4.5,
            //ElementsCode.RoLi when lv is ElementsLevel.LvB => 0.0,
            ElementCode.RoLi when lv is ElementLevel.Lv1 => 2.0,
            ElementCode.RoLi when lv is ElementLevel.Lv2 => 3.0,
            ElementCode.RoLi when lv is ElementLevel.Lv3 => 4.0,
            ElementCode.RoLi when lv is ElementLevel.Lv4 => 4.5,
            //ElementsCode.STw when lv is ElementsLevel.LvB => 0.0,
            ElementCode.STw when lv is ElementLevel.Lv1 => 3.1,
            ElementCode.STw when lv is ElementLevel.Lv2 => 4.6,
            ElementCode.STw when lv is ElementLevel.Lv3 => 5.6,
            ElementCode.STw when lv is ElementLevel.Lv4 => 6.6,
            ElementCode.PSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.PSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.PSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.PSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.PSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.MiSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.MiSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.MiSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.MiSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.MiSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.CiSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.CiSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.CiSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.CiSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.CiSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.SeSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.SeSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.SeSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.SeSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.SeSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.NtMiSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.NtMiSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.NtMiSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.NtMiSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.NtMiSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.NtDiSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.NtDiSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.NtDiSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.NtDiSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.NtDiSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.NtCiSt when lv is ElementLevel.LvB => 2.6,
            ElementCode.NtCiSt when lv is ElementLevel.Lv1 => 4.1,
            ElementCode.NtCiSt when lv is ElementLevel.Lv2 => 5.6,
            ElementCode.NtCiSt when lv is ElementLevel.Lv3 => 7.1,
            ElementCode.NtCiSt when lv is ElementLevel.Lv4 => 8.6,
            ElementCode.ChLi1 => 0.7,
            ElementCode.ChSp1 => 0.7,
            ElementCode.ChTw1 => 0.7,
            _ => throw new ArgumentOutOfRangeException()
        };
        return new BaseValue(value);
        */
    }
}
