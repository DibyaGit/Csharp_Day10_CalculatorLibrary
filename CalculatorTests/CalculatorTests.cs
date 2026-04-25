using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorTests;

public class CalculatorTests
{
    private Calculator _calc;

    [SetUp]
    public void Setup()
    {
        _calc = new Calculator();
    }

    [Test]
    public void Add_ValidInputs_ReturnsSum()
    {
        double result = _calc.Add(10, 5);
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Add_Zero_ReturnsSameNumber()
    {
        double result = _calc.Add(10, 0);
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Subtract_ValidInputs_ReturnsDifference()
    {
        double result = _calc.Subtract(10, 5);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Multiply_ValidInputs_ReturnsProduct()
    {
        double result = _calc.Multiply(10, 5);
        Assert.That(result, Is.EqualTo(50));
    }

    [Test]
    public void Divide_ValidInputs_ReturnsQuotient()
    {
        double result = _calc.Divide(10, 2);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
    }
}