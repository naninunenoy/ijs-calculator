namespace ijs.Csv; 

public class CsvDict {
    readonly string keyTitle;
    readonly Dictionary<string, int> titleIndexDict;
    readonly Dictionary<string, string[]> valuesDict;

    public CsvDict(string keyTitle) {
        this.keyTitle = keyTitle;
        titleIndexDict = new();
        valuesDict = new();
    }

    public void Build(string csv) {
        titleIndexDict.Clear();
        valuesDict.Clear();
        var lines = csv.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        // 1行目をタイトルとする
        var keyTitleIndex = -1;
        var firstLineSplit = lines[0].Split(',');
        for (var i = 0; i < firstLineSplit.Length; i++) {
            var title = firstLineSplit[i];
            titleIndexDict.Add(title, i);
            if (title == keyTitle) {
                keyTitleIndex = i;
            }
        }
        if (keyTitleIndex == -1) throw new ArgumentException($"keyTitle {keyTitle} is not found");
        // 指定したタイトルとキーにした辞書作成
        foreach (var line in lines.Skip(1)) {
            var commaSeparatedValues = line.Split(',');
            valuesDict.Add(commaSeparatedValues[keyTitleIndex], commaSeparatedValues);
        }
    }

    public bool TryGetValue(string key, string valueName, out string value) {
        if (valuesDict.TryGetValue(key, out var values)) {
            if (titleIndexDict.TryGetValue(valueName, out var index)) {
                value = values[index];
                return true;
            }
        }
        value = "";
        return false;
    }
    
    public bool TryGetValue(string key, string valueName, out int value) {
        if (TryGetValue(key, valueName, out string valueString)) {
            return int.TryParse(valueString, out value);
        }
        value = 0;
        return false;
    }
    
    public bool TryGetValue(string key, string valueName, out double value) {
        if (TryGetValue(key, valueName, out string valueString)) {
            return double.TryParse(valueString, out value);
        }
        value = 0;
        return false;
    }
}
