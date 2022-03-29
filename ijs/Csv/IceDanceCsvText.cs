﻿namespace ijs.Csv;

public static class IceDanceCsvText {
    public const string PatternDanceCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
ブルース第1シークエンス,1BL1,3.2,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第1シークエンス,1BL2,3.8,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第1シークエンス,1BL3,4.4,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第1シークエンス,1BL4,5.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第2シークエンス,2BL1,3.2,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第2シークエンス,2BL2,3.8,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第2シークエンス,2BL3,4.4,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ブルース第2シークエンス,2BL4,5.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドナイトブルース第1シークエンス,1MN1,3.2,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドナイトブルース第1シークエンス,1MN2,3.8,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドナイトブルース第1シークエンス,1MN3,4.4,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドナイトブルース第1シークエンス,1MN4,5.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
";
    public const string SpinCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
スピン,Sp1,2.6,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
スピン,Sp2,3.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
スピン,Sp3,4.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
スピン,Sp4,5.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
コンビネーションスピン,CoSp1,2.6,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
コンビネーションスピン,CoSp2,3.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
コンビネーションスピン,CoSp3,4.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
コンビネーションスピン,CoSp4,5.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
";
    public const string LiftCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
ステーショナリーリフト,StaLi1,2.0,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
ステーショナリーリフト,StaLi2,3.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ステーショナリーリフト,StaLi3,4.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ステーショナリーリフト,StaLi4,4.5,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ストレートラインリフト,SlLi1,2.0,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
ストレートラインリフト,SlLi2,3.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ストレートラインリフト,SlLi3,4.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ストレートラインリフト,SlLi4,4.5,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
カーブリフト,CuLi1,2.0,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
カーブリフト,CuLi2,3.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
カーブリフト,CuLi3,4.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
カーブリフト,CuLi4,4.5,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ローテーショナルリフト,RoLi1,2.0,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
ローテーショナルリフト,RoLi2,3.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ローテーショナルリフト,RoLi3,4.0,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ローテーショナルリフト,RoLi4,4.5,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
";    
    public const string TwizzleCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
ツイズル・セット(シークエンシャルまたはシンクロナイズドツイズル),STw1,3.1,-1.0,-0.7,-0.3,+0.6,+1.2,+1.8
ツイズル・セット(シークエンシャルまたはシンクロナイズドツイズル),STw2,4.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ツイズル・セット(シークエンシャルまたはシンクロナイズドツイズル),STw3,5.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ツイズル・セット(シークエンシャルまたはシンクロナイズドツイズル),STw4,6.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
";
    public const string StepSequenceCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
パーシャルステップシークエンス,PStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
パーシャルステップシークエンス,PSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
パーシャルステップシークエンス,PSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
パーシャルステップシークエンス,PSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
パーシャルステップシークエンス,PSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
ミッドライン(イン・ホールド),MiStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドライン(イン・ホールド),MiSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
ミッドライン(イン・ホールド),MiSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
ミッドライン(イン・ホールド),MiSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
ミッドライン(イン・ホールド),MiSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーキュラー(イン・ホールド),CiStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
サーキュラー(イン・ホールド),CiSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
サーキュラー(イン・ホールド),CiSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーキュラー(イン・ホールド),CiSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーキュラー(イン・ホールド),CiSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーペンタイン(イン・ホールド),SeStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
サーペンタイン(イン・ホールド),SeSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
サーペンタイン(イン・ホールド),SeSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーペンタイン(イン・ホールド),SeSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
サーペンタイン(イン・ホールド),SeSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ミッドライン,NtMiStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触ミッドライン,NtMiSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触ミッドライン,NtMiSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ミッドライン,NtMiSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ミッドライン,NtMiSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ダイアゴナル,NtDiStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触ダイアゴナル,NtDiSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触ダイアゴナル,NtDiSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ダイアゴナル,NtDiSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触ダイアゴナル,NtDiSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触サーキュラー,NtCiStB,2.6,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触サーキュラー,NtCiSt1,4.1,-1.5,-1.0,-0.5,+0.6,+1.2,+1.8
非接触サーキュラー,NtCiSt2,5.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触サーキュラー,NtCiSt3,7.1,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
非接触サーキュラー,NtCiSt4,8.6,-3.0,-2.0,-1.0,+1.1,+2.2,+3.3
";
    public const string ChoreographicElementsCsv = @"
name,code,baseValue,goe-3,goe-2,goe-1,goe+1,goe+2,goe+3
コレオグラフィックダンスリフト,ChLi1,0.7,-0.6,-0.4,-0.2,+0.7,+1.4,+2.1
コレオグラフィックスピニングムーブメント,ChSp1,0.7,-0.6,-0.4,-0.2,+0.7,+1.4,+2.1
コレオグラフィックツイズリングムーブメント,ChTw1,0.7,-0.6,-0.4,-0.2,+0.7,+1.4,+2.1
";
}