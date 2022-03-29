namespace ijs.Localizations; 

internal static class LocalizationsCsv {
    public static IEnumerable<string> LangCodes() => new[] { "en", "ja" };
    
    public const string Single = @"
code,en,ja
1T,Single Toe Loop,1回転トウループ
1S,Single Salchow,1回転サルコウ
1Lo,Single Loop,1回転ループ
1Eu,Single Euler,オイラー
1F,Single Flip,1回転フリップ
1Lz,Single Lutz,1回転ルッツ
1A,Single Axel,1回転アクセル
2T,Double Toe Loop,2回転トウループ
2S,Double Salchow,2回転サルコウ
2Lo,Double Loop,2回転ループ
2F,Double Flip,2回転フリップ
2Lz,Double Lutz,2回転ルッツ
2A,Double Axel,2回転アクセル
3T,Triple Toe Loop,3回転トウループ
3S,Triple Salchow,3回転サルコウ
3Lo,Triple Loop,3回転ループ
3F,Triple Flip,3回転フリップ
3Lz,Triple Lutz,3回転ルッツ
3A,Triple Axel,3回転アクセル
4T,Quad Toe Loop,4回転トウループ
4S,Quad Salchow,4回転サルコウ
4Lo,Quad Loop,4回転ループ
4F,Quad Flip,4回転フリップ
4Lz,Quad Lutz,4回転ルッツ
4A,Quad Axel,4回転アクセル
USp,Upright Spin,アップライトスピン
LSp,Layback Spin,レイバックスピン
CSp,Camel Spin,キャメルスピン
SSp,Sit Spin,シットスピン
FUSp,Flying Upright Spin,フライングアップライトスピン
FLSp,Flying Layback Spin,フライングレイバックスピン
FCSp,Flying Camel Spin,フライングキャメルスピン
FSSp,Flying Sit Spin,フライングシットスピン
CUSp,Change Foot Upright Spin,足替えアップライトスピン
FCUSp,Flying Change Foot Upright Spin,フライング足替えアップライトスピン
CLSp,Change Foot Layback Spin,足替えレイバックスピン
FCLSp,Flying Change Foot Layback Spin,フライング足替えレイバックスピン
CCSp,Change Foot Camel Spin,足替えキャメルスピン
FCCSp,Flying Change Foot Camel Spin,フライング足替えキャメルスピン
CSSp,Change Foot Sit Spin,足替えシットスピン
FCSSp,Flying Change Foot Sit Spin,フライング足替えシットスピン
CoSp,Combination Spin,コンビネーションスピン
FCoSp,Flying Combination Spin,フライングコンビネーションスピン
CCoSp,Change Foot Combination Spin,足換えコンビネーションスピン
FCCoSp,Flying Change Foot Combination Spin,フライング足換えコンビネーションスピン
StSq,Step Sequence,ステップシークエンス
ChSq,Choreo Sequence,コレオグラフィックシークエンス
";

    public const string Pair = @"
code,ja,en
1T,Single Toe Loop,1回転トウループ
1S,Single Salchow,1回転サルコウ
1Lo,Single Loop,1回転ループ
1Eu,Single Euler,オイラー
1F,Single Flip,1回転フリップ
1Lz,Single Lutz,1回転ルッツ
1A,Single Axel,1回転アクセル
2T,Double Toe Loop,2回転トウループ
2S,Double Salchow,2回転サルコウ
2Lo,Double Loop,2回転ループ
2F,Double Flip,2回転フリップ
2Lz,Double Lutz,2回転ルッツ
2A,Double Axel,2回転アクセル
3T,Triple Toe Loop,3回転トウループ
3S,Triple Salchow,3回転サルコウ
3Lo,Triple Loop,3回転ループ
3F,Triple Flip,3回転フリップ
3Lz,Triple Lutz,3回転ルッツ
3A,Triple Axel,3回転アクセル
4T,Quad Toe Loop,4回転トウループ
4S,Quad Salchow,4回転サルコウ
4Lo,Quad Loop,4回転ループ
4F,Quad Flip,4回転フリップ
4Lz,Quad Lutz,4回転ルッツ
4A,Quad Axel,4回転アクセル
StSq,Step Sequence,ステップシークエンス
ChSq,Choreo Sequence,コレオグラフィックシークエンス
1Li,Group 1 Lift,グループ1リフト
2Li,Group 2 Lift,グループ2リフト
3Li,Group 3 Lift,グループ3リフト
4Li,Group 4 Lift,グループ4リフト
5TLi,Group 5 Toe Lasso Lift,グループ5トゥラッソーリフト
5SLi,Group 5 Step in Lasso Lift,グループ5ステップインラッソーリフト
5BLi,Group 5 Backward Lasso Lift,グループ5バックワードラッソーリフト
5ALi,Group 5 Axel Lasso Lift,グループ5アクセルラッソーリフト
5RLi,Group 5 Reverse Lasso Lift,グループ5リバースラッソーリフト
1Tw,Single Twist Lift,1回転ツイストリフト
2Tw,Double Twist Lift,2回転ツイストリフト
3Tw,Triple Twist Lift,3回転ツイストリフト
4Tw,Quad Twist Lift,4回転ツイストリフト
1TTh,Throw Single Toe Loop,1回転トウループ
1STh,Throw Single Salchow,1回転サルコウ
1LoTh,Throw Single Loop,1回転ループ
1FTh,Throw Single Flip,1回転フリップ
1LzTh,Throw Single Lutz,1回転ルッツ
1ATh,Throw Single Axel,1回転アクセル
2TTh,Throw Double Toe Loop,2回転トウループ
2STh,Throw Double Salchow,2回転サルコウ
2LoTh,Throw Double Loop,2回転ループ
2FTh,Throw Double Flip,2回転フリップ
2LzTh,Throw Double Lutz,2回転ルッツ
2ATh,Throw Double Axel,2回転アクセル
3TTh,Throw Triple Toe Loop,3回転トウループ
3STh,Throw Triple Salchow,3回転サルコウ
3LoTh,Throw Triple Loop,3回転ループ
3FTh,Throw Triple Flip,3回転フリップ
3LzTh,Throw Triple Lutz,3回転ルッツ
3ATh,Throw Triple Axel,3回転アクセル
4TTh,Throw Quad Toe Loop,4回転トウループ
4STh,Throw Quad Salchow,4回転サルコウ
4LoTh,Throw Quad Loop,4回転ループ
4FTh,Throw Quad Flip,4回転フリップ
4LzThThrow Quad Lutz,,4回転ルッツ
FiDs,Forward Inside Death Spiral,フォアインデススパイラル
BiDs,Backward Inside Death Spiral,バックインデススパイラル
FoDs,Forward Outside Death Spiral,フォアアウトデススパイラル
BoDs,Backward Outside Death Spiral,バックアウトデススパイラル
PiF,Pivot Figure,ピボットフィギュア
PSp,Pair Spin,ペアスピン
PCoSp,Pair Combination Spin,ペアコンビネーションスピン
";
    
    public const string IceDance = @"
code,ja,en
1BL,Blues Sequence 1,ブルース第1シークエンス
2BL,Blues Sequence 2,ブルース第2シークエンス
1MN,Midnight Blues Section 1,ミッドナイトブルース第1シークエンス
Sp,Spin,スピン
CoSp,Combination Spin,コンビネーションスピン
StaLi,Stationary Lift,ステーショナリーリフト
SlLi,Straight Line Lift,ストレートラインリフト
CuLi,Curve Lift,カーブリフト
RoLi,Rotational Lift,ローテーショナルリフト
STw,Set of Sequential or Synchronized Twizzles,ツイズル・セット(シークエンシャルまたはシンクロナイズドツイズル)
PSt,Partial Step Sequence,パーシャルステップシークエンス
MiSt,Midline Step Sequence in Hold,ミッドライン(イン・ホールド)
CiSt,Circular Step Sequence in Hold,サーキュラー(イン・ホールド)
SeSt,Serpentine Step Seqence in Hold,サーペンタイン(イン・ホールド)
NtMiSt,Not Touching Midline Step Sequence,非接触ミッドライン
NtDiSt,Not Touching Diagonal Step Sequence,非接触ダイアゴナル
NtCiSt,Not Touching Circular Step Sequence,非接触サーキュラー
ChLi1,Choreographic Dance Lift,コレオグラフィックダンスリフト
ChSp1,Choreographic Spinning Movement,コレオグラフィックスピニングムーブメント
ChTw1,Choreographic Twizzling Movement,コレオグラフィックツイズリングムーブメント
";
}
