using Moq;
using ResponsiveWebAppWithTests.Controllers;
using ResponsiveWebAppWithTests.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using System;

namespace testResponsiveWebApp;

public class UnitTest1
{
    [Fact]
    public void testPassingCase()
    {
        string Name = "Cale";
        int BirthYear = 2003;
        string expected = "Cale, 21";

        var mockAgeCalculator = new Mock<IAgeCalculatorModel>();

        mockAgeCalculator
            .Setup(m => m.CalculateAge(Name, BirthYear))
            .Returns(expected);

        string actual = mockAgeCalculator.Object.CalculateAge(Name, BirthYear);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void testCorrectAge()
    {
        var model = new AgeCalculatorModel
        {
            BirthYear = 2003
        };
        int currentYear = DateTime.Now.Year;
        string expectedAge = (currentYear - 2003).ToString();

        string actualAge = model.AgeThisYear();

        Assert.Equal(expectedAge, actualAge);
    }

    [Fact]
    public void testCorrectNameFormat()
    {
        var model = new AgeCalculatorModel
        {
            Name = "Cale"
        };
        string expectedName = "Cale,";

        string actualName = model.NameViewBag();

        Assert.Equal(expectedName, actualName);
    }

    [Fact]
    public void testClearButton()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<HomeController>>();
        var controller = new HomeController(mockLogger.Object);

        // Act
        var result = controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        Assert.Equal(string.Empty, controller.ViewBag.Age);
        Assert.Equal(string.Empty, controller.ViewBag.Name);
    }
}


public interface IAgeCalculatorModel
{
string CalculateAge(string name, int birthYear);
}