using System;
using Xunit;

namespace gradebook.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var x = 2;
        var y = 3;

        var actual = x * y;

        var expected = 6;

        Assert.Equal(expected,actual);
    }
}