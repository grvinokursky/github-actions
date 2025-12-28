using BlazorApp.Services;
using NUnit.Framework;

namespace Tests;

[TestFixture]
public class MathServiceTests
{
    private MathService _mathService;

    [SetUp]
    public void Setup()
    {
        _mathService = new MathService();
    }

    [TestCaseSource(nameof(IncreaseTestData))]
    public int IncreaseTests(int inputNumber)
    {
        return _mathService.Increase(inputNumber);
    }

    public static readonly TestCaseData[] IncreaseTestData =
    [
        new TestCaseData(-10).Returns(-9),
        new TestCaseData(-1).Returns(0),
        new TestCaseData(0).Returns(1),
        new TestCaseData(10).Returns(11)
    ];
}