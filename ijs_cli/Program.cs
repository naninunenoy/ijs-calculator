using System.CommandLine;
using ijs_cli;

// $ dotnet run -- --program 4S-4T+3T-CCSp4-3Ax-FSSp4-StSq3-CCoSp4
// エレメントは `-` で区切る
// 連続ジャンプは `+` で区切る
// 後半ジャンプは末尾に `x` を付与する
// --sports single/pair/icedance で種目を判別(デフォルトはsingle)

const string programDescription =
    "以下のようにプログラムを入力してください --program 4S-4T+3T-CCSp4-3Ax-FSSp4-StSq3-CCoSp4\n" +
    "* エレメントは - で区切ってください\n" +
    "* 連続ジャンプは + で区切ってください\n" +
    "* 後半のジャンプには末尾に x をつけてください";

var programOption = new Option<string>(
    "--program",
    getDefaultValue: () => "",
    description: programDescription);

var sportsOption = new Option<string>(
    "--sports",
    getDefaultValue: () => "single",
    description: "single/pair/icedance を指定してください\n" +
                 "何も入力していない場合はシングルになります");

// Add the options to a root command:
var rootCommand = new RootCommand
{
    programOption,
    sportsOption
};

rootCommand.Description = "IJS Cli";

rootCommand.SetHandler((string programArgs, string sportType) =>
{
    if (string.IsNullOrEmpty(programArgs)) {
        Console.WriteLine(programDescription);
        return;
    }

    var calc = new TotalBaseValueCalculator(sportType, programArgs);
    var success = false;
    TotalBaseValue totalBaseValue = default;
    string description;
    try {
        (totalBaseValue, description) = calc.Calculate();
        success = true;
    } catch (Exception e) {
        description = e.Message;
    }

    Console.WriteLine(success ? $"基礎点は{totalBaseValue}です" : "基礎点の計算に失敗しました");
    Console.WriteLine(description);
}, programOption, sportsOption);

// Parse the incoming args and invoke the handler
return rootCommand.Invoke(args);
