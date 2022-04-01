# What's this?

フィギュアスケートの基礎点の合計を計算するプログラムです。

* コマンドラインでの入力に対応しています。
* シングルだけでなく、ペアとアイスダンスにも対応しています。
* 2021-2022シーズンに準拠しています
* 正確性は保証できませんので参考程度に利用してください。

# Hot to use

1. GitHubからクローンします。

```
git clone git@github.com:naninunenoy/ijs-calculator.git
```

2. プログラムを指定し、コマンドを実行してください。
なお `dotnet` コマンドの実行環境が必須になります。

```
dotnet run --project ijs_cli -- --program 4S-4T+3T-CCSp4-3Ax-FSSp4-StSq3-CCoSp4
```

以下のように表示されます。
なお、例は北京五輪での鍵山優真選手のショートプログラムの基礎点です。

```
基礎点合計は 45.20 です
==== 内訳 ===========================================
 1. 4回転サルコウ                         (4S):  9.70
 2. 4回転トウループ + 3回転トウループ  (4T+3T): 13.70
 3. 足替えキャメルスピン Lv.4          (CCSp4):  3.20
 4. 3回転アクセル                         (3A):  8.80 後半につき1.1倍加点
 5. フライングシットスピン Lv.4        (FSSp4):  3.00
 6. ステップシークエンス Lv.3          (StSq3):  3.30
 7. 足換えコンビネーションスピン Lv.4 (CCoSp4):  3.50
-----------------------------------------------------
 *  ジャンプ: 3個
    - 後半: 1個
    - 連続ジャンプ: 1個
      - 2連続: 1個
 *  スピン: 3個
 *  ステップシークエンス: 1個
=====================================================
```

GitHub上ではズレていますが [EastAsianWidthDotNet](https://github.com/nuitsjp/EastAsianWidthDotNet) のおかげでターミナル上では揃うはずです。

# LICENSE
MIT
