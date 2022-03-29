﻿namespace ijs.Internal;

internal static class PairCsvText {
        public const string JumpCsv = SingleCsvText.JumpCsv;
        public const string StepSequenceCsv = SingleCsvText.StepSequenceCsv;
        public const string LiftCsv = @"
name,code,baseValue,goe-5,goe-4,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3,goe+4,goe+5
グループ1,1LiB,1.40,-0.70,-0.56,-0.42,-0.28,-0.14,+0.14,+0.28,+0.42,+0.56,+0.70
グループ1,1Li1,1.50,-0.75,-0.60,-0.45,-0.30,-0.15,+0.15,+0.30,+0.45,+0.60,+0.75
グループ1,1Li2,1.70,-0.85,-0.68,-0.51,-0.34,-0.17,+0.17,+0.34,+0.51,+0.68,+0.85
グループ1,1Li3,1.90,-0.95,-0.76,-0.57,-0.38,-0.19,+0.19,+0.38,+0.57,+0.76,+0.95
グループ1,1Li4,2.10,-1.05,-0.84,-0.63,-0.42,-0.21,+0.21,+0.42,+0.63,+0.84,+1.05
グループ2,2LiB,1.50,-0.75,-0.60,-0.45,-0.30,-0.15,+0.15,+0.30,+0.45,+0.60,+0.75
グループ2,2Li1,1.90,-0.95,-0.76,-0.57,-0.38,-0.19,+0.19,+0.38,+0.57,+0.76,+0.95
グループ2,2Li2,2.30,-1.15,-0.92,-0.69,-0.46,-0.23,+0.23,+0.46,+0.69,+0.92,+1.15
グループ2,2Li3,2.70,-1.35,-1.08,-0.81,-0.54,-0.27,+0.27,+0.54,+0.81,+1.08,+1.35
グループ2,2Li4,3.10,-1.55,-1.24,-0.93,-0.62,-0.31,+0.31,+0.62,+0.93,+1.24,+1.55
グループ3,3LiB,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
グループ3,3Li1,3.90,-1.95,-1.56,-1.17,-0.78,-0.39,+0.39,+0.78,+1.17,+1.56,+1.95
グループ3,3Li2,4.30,-2.15,-1.72,-1.29,-0.86,-0.43,+0.43,+0.86,+1.29,+1.72,+2.15
グループ3,3Li3,4.70,-2.35,-1.88,-1.41,-0.94,-0.47,+0.47,+0.94,+1.41,+1.88,+2.35
グループ3,3Li4,5.10,-2.55,-2.04,-1.53,-1.02,-0.51,+0.51,+1.02,+1.53,+2.04,+2.55
グループ4,4LiB,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
グループ4,4Li1,3.90,-1.95,-1.56,-1.17,-0.78,-0.39,+0.39,+0.78,+1.17,+1.56,+1.95
グループ4,4Li2,4.30,-2.15,-1.72,-1.29,-0.86,-0.43,+0.43,+0.86,+1.29,+1.72,+2.15
グループ4,4Li3,4.70,-2.35,-1.88,-1.41,-0.94,-0.47,+0.47,+0.94,+1.41,+1.88,+2.35
グループ4,4Li4,5.10,-2.55,-2.04,-1.53,-1.02,-0.51,+0.51,+1.02,+1.53,+2.04,+2.55
グループ5トゥラッソー,5TLiB,4.60,-2.30,-1.84,-1.38,-0.92,-0.46,+0.46,+0.92,+1.38,+1.84,+2.30
グループ5トゥラッソー,5TLi1,5.00,-2.50,-2.00,-1.50,-1.00,-0.50,+0.50,+1.00,+1.50,+2.00,+2.50
グループ5トゥラッソー,5TLi2,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
グループ5トゥラッソー,5TLi3,5.80,-2.90,-2.32,-1.74,-1.16,-0.58,+0.58,+1.16,+1.74,+2.32,+2.90
グループ5トゥラッソー,5TLi4,6.20,-3.10,-2.48,-1.86,-1.24,-0.62,+0.62,+1.24,+1.86,+2.48,+3.10
グループ5ステップインラッソー,5SLiB,4.60,-2.30,-1.84,-1.38,-0.92,-0.46,+0.46,+0.92,+1.38,+1.84,+2.30
グループ5ステップインラッソー,5SLi1,5.00,-2.50,-2.00,-1.50,-1.00,-0.50,+0.50,+1.00,+1.50,+2.00,+2.50
グループ5ステップインラッソー,5SLi2,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
グループ5ステップインラッソー,5SLi3,5.80,-2.90,-2.32,-1.74,-1.16,-0.58,+0.58,+1.16,+1.74,+2.32,+2.90
グループ5ステップインラッソー,5SLi4,6.20,-3.10,-2.48,-1.86,-1.24,-0.62,+0.62,+1.24,+1.86,+2.48,+3.10
グループ5バックワードラッソー,5BLiB,5.00,-2.50,-2.00,-1.50,-1.00,-0.50,+0.50,+1.00,+1.50,+2.00,+2.50
グループ5バックワードラッソー,5BLi1,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
グループ5バックワードラッソー,5BLi2,5.80,-2.90,-2.32,-1.74,-1.16,-0.58,+0.58,+1.16,+1.74,+2.32,+2.90
グループ5バックワードラッソー,5BLi3,6.20,-3.10,-2.48,-1.86,-1.24,-0.62,+0.62,+1.24,+1.86,+2.48,+3.10
グループ5バックワードラッソー,5BLi4,6.50,-3.25,-2.60,-1.95,-1.30,-0.65,+0.65,+1.30,+1.95,+2.60,+3.25
グループ5アクセルラッソー,5ALiB,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
グループ5アクセルラッソー,5ALi1,5.80,-2.90,-2.32,-1.74,-1.16,-0.58,+0.58,+1.16,+1.74,+2.32,+2.90
グループ5アクセルラッソー,5ALi2,6.20,-3.10,-2.48,-1.86,-1.24,-0.62,+0.62,+1.24,+1.86,+2.48,+3.10
グループ5アクセルラッソー,5ALi3,6.60,-3.30,-2.64,-1.98,-1.32,-0.66,+0.66,+1.32,+1.98,+2.64,+3.30
グループ5アクセルラッソー,5ALi4,7.00,-3.50,-2.80,-2.10,-1.40,-0.70,+0.70,+1.40,+2.10,+2.80,+3.50
グループ5リバースラッソー,5RLiB,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
グループ5リバースラッソー,5RLi1,5.80,-2.90,-2.32,-1.74,-1.16,-0.58,+0.58,+1.16,+1.74,+2.32,+2.90
グループ5リバースラッソー,5RLi2,6.20,-3.10,-2.48,-1.86,-1.24,-0.62,+0.62,+1.24,+1.86,+2.48,+3.10
グループ5リバースラッソー,5RLi3,6.60,-3.30,-2.64,-1.98,-1.32,-0.66,+0.66,+1.32,+1.98,+2.64,+3.30
グループ5リバースラッソー,5RLi4,7.00,-3.50,-2.80,-2.10,-1.40,-0.70,+0.70,+1.40,+2.10,+2.80,+3.50
";
        public const string TwistLiftCsv = @"
name,code,baseValue,goe-5,goe-4,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3,goe+4,goe+5
1回転ツイストリフト,1TwB,0.90,-0.45,-0.36,-0.27,-0.18,-0.09,+0.09,+0.18,+0.27,+0.36,+0.45
1回転ツイストリフト,1Tw1,1.10,-0.55,-0.44,-0.33,-0.22,-0.11,+0.11,+0.22,+0.33,+0.44,+0.55
1回転ツイストリフト,1Tw2,1.30,-0.65,-0.52,-0.39,-0.26,-0.13,+0.13,+0.26,+0.39,+0.52,+0.65
1回転ツイストリフト,1Tw3,1.50,-0.75,-0.60,-0.45,-0.30,-0.15,+0.15,+0.30,+0.45,+0.60,+0.75
1回転ツイストリフト,1Tw4,1.70,-0.85,-0.68,-0.51,-0.34,-0.17,+0.17,+0.34,+0.51,+0.68,+0.85
2回転ツイストリフト,2TwB,2.60,-1.30,-1.04,-0.78,-0.52,-0.26,+0.26,+0.52,+0.78,+1.04,+1.30
2回転ツイストリフト,2Tw1,2.80,-1.40,-1.12,-0.84,-0.56,-0.28,+0.28,+0.56,+0.84,+1.12,+1.40
2回転ツイストリフト,2Tw2,3.00,-1.50,-1.20,-0.90,-0.60,-0.30,+0.30,+0.60,+0.90,+1.20,+1.50
2回転ツイストリフト,2Tw3,3.20,-1.60,-1.28,-0.96,-0.64,-0.32,+0.32,+0.64,+0.96,+1.28,+1.60
2回転ツイストリフト,2Tw4,3.40,-1.70,-1.36,-1.02,-0.68,-0.34,+0.34,+0.68,+1.02,+1.36,+1.70
3回転ツイストリフト,3TwB,4.80,-2.40,-1.92,-1.44,-0.96,-0.48,+0.48,+0.96,+1.44,+1.92,+2.40
3回転ツイストリフト,3Tw1,5.10,-2.55,-2.04,-1.53,-1.02,-0.51,+0.51,+1.02,+1.53,+2.04,+2.55
3回転ツイストリフト,3Tw2,5.40,-2.70,-2.16,-1.62,-1.08,-0.54,+0.54,+1.08,+1.62,+2.16,+2.70
3回転ツイストリフト,3Tw3,5.70,-2.85,-2.28,-1.71,-1.14,-0.57,+0.57,+1.14,+1.71,+2.28,+2.85
3回転ツイストリフト,3Tw4,6.00,-3.00,-2.40,-1.80,-1.20,-0.60,+0.60,+1.20,+1.80,+2.40,+3.00
4回転ツイストリフト,4TwB,6.40,-3.20,-2.56,-1.92,-1.28,-0.64,+0.64,+1.28,+1.92,+2.56,+3.20
4回転ツイストリフト,4Tw1,6.80,-3.40,-2.72,-2.04,-1.36,-0.68,+0.68,+1.36,+2.04,+2.72,+3.40
4回転ツイストリフト,4Tw2,7.20,-3.60,-2.88,-2.16,-1.44,-0.72,+0.72,+1.44,+2.16,+2.88,+3.60
4回転ツイストリフト,4Tw3,7.60,-3.80,-3.04,-2.28,-1.52,-0.76,+0.76,+1.52,+2.28,+3.04,+3.80
4回転ツイストリフト,4Tw4,8.00,-4.00,-3.20,-2.40,-1.60,-0.80,+0.80,+1.60,+2.40,+3.20,+4.00
";
        public const string ThrowJumpCsv = @"
name,code,baseValue,error,goe-5,goe-4,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3,goe+4,goe+5
1回転トウループ,1TTh,1.10,0.83,-0.55,-0.44,-0.33,-0.22,-0.11,+0.11,+0.22,+0.33,+0.44,+0.55
1回転サルコウ,1STh,1.10,0.83,-0.55,-0.44,-0.33,-0.22,-0.11,+0.11,+0.22,+0.33,+0.44,+0.55
1回転ループ,1LoTh,1.40,1.05,-0.70,-0.56,-0.42,-0.28,-0.14,+0.14,+0.28,+0.42,+0.56,+0.70
1回転フリップ,1FTh,1.40,1.05,-0.70,-0.56,-0.42,-0.28,-0.14,+0.14,+0.28,+0.42,+0.56,+0.70
1回転ルッツ,1LzTh,1.40,1.05,-0.70,-0.56,-0.42,-0.28,-0.14,+0.14,+0.28,+0.42,+0.56,+0.70
1回転アクセル,1ATh,2.20,1.65,-1.10,-0.88,-0.66,-0.44,-0.22,+0.22,+0.44,+0.66,+0.88,+1.10
2回転トウループ,2TTh,2.50,1.88,-1.25,-1.00,-0.75,-0.50,-0.25,+0.25,+0.50,+0.75,+1.00,+1.25
2回転サルコウ,2STh,2.50,1.88,-1.25,-1.00,-0.75,-0.50,-0.25,+0.25,+0.50,+0.75,+1.00,+1.25
2回転ループ,2LoTh,2.80,2.10,-1.40,-1.12,-0.84,-0.56,-0.28,+0.28,+0.56,+0.84,+1.12,+1.40
2回転フリップ,2FTh,3.00,2.25,-1.50,-1.20,-0.90,-0.60,-0.30,+0.30,+0.60,+0.90,+1.20,+1.50
2回転ルッツ,2LzTh,3.00,2.25,-1.50,-1.20,-0.90,-0.60,-0.30,+0.30,+0.60,+0.90,+1.20,+1.50
2回転アクセル,2ATh,4.00,3.00,-2.00,-1.60,-1.20,-0.80,-0.40,+0.40,+0.80,+1.20,+1.60,+2.00
3回転トウループ,3TTh,4.40,3.30,-2.20,-1.76,-1.32,-0.88,-0.44,+0.44,+0.88,+1.32,+1.76,+2.20
3回転サルコウ,3STh,4.40,3.30,-2.20,-1.76,-1.32,-0.88,-0.44,+0.44,+0.88,+1.32,+1.76,+2.20
3回転ループ,3LoTh,5.00,3.75,-2.50,-2.00,-1.50,-1.00,-0.50,+0.50,+1.00,+1.50,+2.00,+2.50
3回転フリップ,3FTh,5.30,3.98,-2.65,-2.12,-1.59,-1.06,-0.53,+0.53,+1.06,+1.59,+2.12,+2.65
3回転ルッツ,3LzTh,5.30,3.98,-2.65,-2.12,-1.59,-1.06,-0.53,+0.53,+1.06,+1.59,+2.12,+2.65
3回転アクセル,3ATh,6.00,4.50,-3.00,-2.40,-1.80,-1.20,-0.60,+0.60,+1.20,+1.80,+2.40,+3.00
4回転トウループ,4TTh,6.50,4.88,-3.25,-2.60,-1.95,-1.30,-0.65,+0.65,+1.30,+1.95,+2.60,+3.25
4回転サルコウ,4STh,6.50,4.88,-3.25,-2.60,-1.95,-1.30,-0.65,+0.65,+1.30,+1.95,+2.60,+3.25
4回転ループ,4LoTh,7.00,5.25,-3.50,-2.80,-2.10,-1.40,-0.70,+0.70,+1.40,+2.10,+2.80,+3.50
4回転フリップ,4FTh,7.50,3.80,-3.75,-3.00,-2.25,-1.50,-0.75,+0.75,+1.50,+2.25,+3.00,+3.75
4回転ルッツ,4LzTh,7.50,3.80,-3.75,-3.00,-2.25,-1.50,-0.75,+0.75,+1.50,+2.25,+3.00,+3.75
";
        public const string DeathSpiralLiftCsv = @"
name,code,baseValue,goe-5,goe-4,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3,goe+4,goe+5
フォアイン,FiDsB,2.60,-1.30,-1.04,-0.78,-0.52,-0.26,+0.26,+0.52,+0.78,+1.04,+1.30
フォアイン,FiDs1,2.90,-1.45,-1.16,-0.87,-0.58,-0.29,+0.29,+0.58,+0.87,+1.16,+1.45
フォアイン,FiDs2,3.20,-1.60,-1.28,-0.96,-0.64,-0.32,+0.32,+0.64,+0.96,+1.28,+1.60
フォアイン,FiDs3,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
フォアイン,FiDs4,3.80,-1.90,-1.52,-1.14,-0.76,-0.38,+0.38,+0.76,+1.14,+1.52,+1.90
バックイン,BiDsB,2.60,-1.30,-1.04,-0.78,-0.52,-0.26,+0.26,+0.52,+0.78,+1.04,+1.30
バックイン,BiDs1,2.90,-1.45,-1.16,-0.87,-0.58,-0.29,+0.29,+0.58,+0.87,+1.16,+1.45
バックイン,BiDs2,3.20,-1.60,-1.28,-0.96,-0.64,-0.32,+0.32,+0.64,+0.96,+1.28,+1.60
バックイン,BiDs3,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
バックイン,BiDs4,3.80,-1.90,-1.52,-1.14,-0.76,-0.38,+0.38,+0.76,+1.14,+1.52,+1.90
フォアアウト,FoDsB,3.10,-1.55,-1.24,-0.93,-0.62,-0.31,+0.31,+0.62,+0.93,+1.24,+1.55
フォアアウト,FoDs1,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
フォアアウト,FoDs2,3.90,-1.95,-1.56,-1.17,-0.78,-0.39,+0.39,+0.78,+1.17,+1.56,+1.95
フォアアウト,FoDs3,4.30,-2.15,-1.72,-1.29,-0.86,-0.43,+0.43,+0.86,+1.29,+1.72,+2.15
フォアアウト,FoDs4,4.70,-2.35,-1.88,-1.41,-0.94,-0.47,+0.47,+0.94,+1.41,+1.88,+2.35
バックアウト,BoDsB,3.10,-1.55,-1.24,-0.93,-0.62,-0.31,+0.31,+0.62,+0.93,+1.24,+1.55
バックアウト,BoDs1,3.50,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
バックアウト,BoDs2,3.90,-1.95,-1.56,-1.17,-0.78,-0.39,+0.39,+0.78,+1.17,+1.56,+1.95
バックアウト,BoDs3,4.30,-2.15,-1.72,-1.29,-0.86,-0.43,+0.43,+0.86,+1.29,+1.72,+2.15
バックアウト,BoDs4,4.70,-2.35,-1.88,-1.41,-0.94,-0.47,+0.47,+0.94,+1.41,+1.88,+2.35
ピボットフィギュア,PiF,2.20,-1.10,-0.88,-0.66,-0.44,-0.22,+0.22,+0.44,+0.66,+0.88,+1.10
";
        public const string SpinCsv = @"
name,code,baseValue,error,goe-5,goe-4,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3,goe+4,goe+5
ペア,PSpB,1.70,,-0.85,-0.68,-0.51,-0.34,-0.17,+0.17,+0.34,+0.51,+0.68,+0.85
ペア,PSp1,2.00,,-1.00,-0.80,-0.60,-0.40,-0.20,+0.20,+0.40,+0.60,+0.80,+1.00
ペア,PSp2,2.50,,-1.25,-1.00,-0.75,-0.50,-0.25,+0.25,+0.50,+0.75,+1.00,+1.25
ペア,PSp3,3.00,,-1.50,-1.20,-0.90,-0.60,-0.30,+0.30,+0.60,+0.90,+1.20,+1.50
ペア,PSp4,3.50,,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
ペアコンビネーション,PCoSpB,2.50,1.88,-1.25,-1.00,-0.75,-0.50,-0.25,+0.25,+0.50,+0.75,+1.00,+1.25
ペアコンビネーション,PCoSp1,3.00,2.25,-1.50,-1.20,-0.90,-0.60,-0.30,+0.30,+0.60,+0.90,+1.20,+1.50
ペアコンビネーション,PCoSp2,3.50,2.63,-1.75,-1.40,-1.05,-0.70,-0.35,+0.35,+0.70,+1.05,+1.40,+1.75
ペアコンビネーション,PCoSp3,4.00,3.00,-2.00,-1.60,-1.20,-0.80,-0.40,+0.40,+0.80,+1.20,+1.60,+2.00
ペアコンビネーション,PCoSp4,4.50,3.38,-2.25,-1.80,-1.35,-0.90,-0.45,+0.45,+0.90,+1.35,+1.80,+2.25
";
}