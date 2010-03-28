using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFizzBuzz;

[TestClass]
public class TestsFizzBuzz
{
    FizzBuzz fizzBuzz = new FizzBuzz();

    [TestMethod]
    public void ShouldReturn_Fizz_WhenNumberIsDivisibleFor_3()
    {
        Assert.AreEqual("Fizz", fizzBuzz.Check(3));
    }

    [TestMethod]
    public void ShouldReturn_Buzz_WhenNumberIsDivisibleFor_5()
    {
        Assert.AreEqual("Buzz", fizzBuzz.Check(5));
    }

    [TestMethod]
    public void ShouldReturn_Fizz_When_SequenceNumbersContains_3()
    {
        Assert.AreEqual("Fizz1", fizzBuzz.Check(3,1));
    }

    [TestMethod]
    public void ShouldReturn_Buzz_When_SequenceNumbersContains_5()
    {
        Assert.AreEqual("1Buzz1", fizzBuzz.Check(1, 5, 1));
    }

    [TestMethod]
    public void ShouldReturn_FizzBuzz_When_NumberIsDivisibleFor_3_Or_5()
    {
        Assert.AreEqual("FizzBuzz", fizzBuzz.Check(15));
    }

    [TestMethod]
    public void ShouldReturn_Fizz_When_NumberContains_3()
    {
        Assert.AreEqual("Fizz", fizzBuzz.Check(23));
    }

    [TestMethod]
    public void ShouldReturn_Buzz_When_NumberContains_5()
    {
        Assert.AreEqual("Buzz", fizzBuzz.Check(55));
    }

    [TestMethod]
    public void ShouldReturnBigSequence()
    {
        string returnFizzBuzz = fizzBuzz.Check(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30);
        Assert.AreEqual("12Fizz4BuzzFizz78FizzBuzzFizzBuzz", returnFizzBuzz);
    }

}

