﻿using ijs;
using Xunit;

namespace ijs_test; 

public class ElementsCodeTest {
    [Fact]
    public void ToEnumStringTest() {
        Assert.Equal("1T", ElementsCode._1T.ToEnumString());
    }
}