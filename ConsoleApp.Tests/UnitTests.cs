namespace ConsoleApp.Tests;

public class UnitTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        int result = Number.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_WithNegativeNumbers()
    {
        int result = Number.Add(-2, -3);
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Add_WithZero()
    {
        int result = Number.Add(0, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_WithLargeNumbers()
    {
        int result = Number.Add(int.MaxValue, 0);
        Assert.Equal(int.MaxValue, result);
    }

    [Fact]
    public void IsPrime_ReturnsTrueForPrime()
    {
        Assert.True(Number.IsPrime(7));
    }

    [Fact]
    public void IsPrime_ReturnsFalseForNonPrime()
    {
        Assert.False(Number.IsPrime(8));
    }

    [Fact]
    public void IsPrime_ReturnsFalseForZeroAndOne()
    {
        Assert.False(Number.IsPrime(0));
        Assert.False(Number.IsPrime(1));
    }

    [Fact]
    public void IsPrime_ReturnsFalseForNegativeNumbers()
    {
        Assert.False(Number.IsPrime(-7));
        Assert.False(Number.IsPrime(-2));
    }

    [Fact]
    public void IsPrime_ReturnsTrueForTwo()
    {
        Assert.True(Number.IsPrime(2));
    }

    [Fact]
    public void IsPrime_ReturnsTrueForLargePrime()
    {
        Assert.True(Number.IsPrime(97));
    }

    [Fact]
    public void IsPrime_ReturnsFalseForLargeNonPrime()
    {
        Assert.False(Number.IsPrime(100));
    }

    [Fact]
    public void AddPrimeNumbers_ReturnsSumOfPrimes()
    {
        var numbers = new List<int> { 2, 3, 4, 5, 6 };
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(10, result); // 2 + 3 + 5 = 10
    }
    [Fact]
    public void AddPrimeNumbers_EmptyList()
    {
        var numbers = new List<int>();
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(0, result);
    }

    [Fact]
    public void AddPrimeNumbers_OnlyNonPrimes()
    {
        var numbers = new List<int> { 1, 4, 6, 8 };
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(0, result);
    }

    [Fact]
    public void AddPrimeNumbers_OnlyPrimes()
    {
        var numbers = new List<int> { 2, 3, 5, 7 };
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(17, result);
    }

    [Fact]
    public void AddPrimeNumbers_WithDuplicates()
    {
        var numbers = new List<int> { 2, 2, 3, 3 };
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(10, result); // 2+2+3+3
    }

    [Fact]
    public void AddPrimeNumbers_WithNegativesAndZero()
    {
        var numbers = new List<int> { -2, 0, 2, 3 };
        int result = Number.AddPrimeNumbers(numbers);
        Assert.Equal(5, result); // only 2 and 3 are prime
    }
}
