using ijs.Internal;
using Xunit;

namespace ijs_test; 

public class CsvDictTest {
    const string testCsv = @"
name,str,int,double
first,abc,+1,+11.0
second,xyz,-9,-99.0
";
    
    [Fact]
    public void ReadCsvTest() {
        var dict = new CsvDict("name");
        dict.Build(testCsv);
        Assert.True(dict.TryGetValue("first", "str", out string str));
        Assert.Equal("abc", str);
        Assert.True(dict.TryGetValue("second", "str", out str));
        Assert.Equal("xyz", str);
        Assert.True(dict.TryGetValue("first", "int", out int intVal));
        Assert.Equal(1, intVal);
        Assert.True(dict.TryGetValue("second", "int", out intVal));
        Assert.Equal(-9, intVal);
        Assert.True(dict.TryGetValue("first", "double", out double dblVal));
        Assert.Equal(11.0, dblVal);
        Assert.True(dict.TryGetValue("second", "double", out dblVal));
        Assert.Equal(-99.0, dblVal);
    }
}
