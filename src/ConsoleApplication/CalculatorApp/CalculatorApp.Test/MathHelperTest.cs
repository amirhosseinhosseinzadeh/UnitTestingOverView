using Xunit;

namespace CalculatorApp.Test;

public class MathHelperTest
{
    [Fact]
    public void IsEvenTest()
    {
        var calculator = new MathFormulas();
        int x = 1;
        int y = 2;
        var xResult = calculator.IsEven(x);
        var yResult = calculator.IsEven(y);
        Assert.False(xResult);
        Assert.True(yResult);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(1, 3, 2)]
    public void DiffTest(int x, int y, int expectedValue)
    {
        var calculator = new MathFormulas();
        var result = calculator.Diff(x, y);
        Assert.Equal(expectedValue, result);
    }

    [Theory]
    [InlineData(new int[] { 7, 9, 23, 10 }, 49)]
    public void SumTest(int[] values, int expectedValues)
    {
        var calculator = new MathFormulas();
        var sumResult = calculator.Sum(values);
        Assert.Equal(expectedValues, sumResult);
    }

    //testing add , avg methods

    [Theory]
    [InlineData(new int[] { 2, 5 }, 3.5)]
    [InlineData(new int[] { 2, 5, 9, 6, 1 }, 4.6)]
    public void AverageTest(int[] values, double expectedValue)
    {
        var calculator = new MathFormulas();
        var avg = calculator.Average(values);
        Assert.Equal(expectedValue, avg);
    }

    [Theory]
    [InlineData(25, 83, 108)]
    [InlineData(-4, -16, -20)]
    [InlineData(66, 99, 165)]
    [InlineData(2563, 99435, 101998)]
    public void AddTest(int x, int y, int expectedValue)
    {
        var calculator = new MathFormulas();
        var addResult = calculator.Add(x, y);
        Assert.Equal(expectedValue, addResult);
    }


    [Theory]
    [MemberData(nameof(MathFormulas.Data), MemberType = typeof(MathFormulas))]
    public void Add_MemberData_Test(int x, int y, int expectedValue)
    {
        var calculator = new MathFormulas();
        var addResult = calculator.Add(x, y);
        Assert.Equal(expectedValue, addResult);
    }

    //[Theory(Skip="ssss")]
    // Skip property is using to skip the test with added reason
    [Theory(Skip="ssss")]
    [ClassData(typeof(MathFormulas))]
    public void Add_ClassData_Test(int x, int y, int expectedValue)
    {
        var calculator = new MathFormulas();
        var addResult = calculator.Add(x, y);
        Assert.Equal(expectedValue, addResult);
    }
}