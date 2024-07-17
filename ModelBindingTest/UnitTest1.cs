using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelBinding.Models;
using ModelBinding;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ModelBinding.Tests;


public class FiltersTests
{
    [Theory]
    [InlineData(null, "all", "all", "all")]
    [InlineData("", "all", "all", "all")]
    [InlineData("1-2-3", "1", "2", "3")]
    [InlineData("1-2", "all", "all", "all")]
    public void Constructor_InitializesPropertiesCorrectly(string filterString, string expectedCategoryId, string expectedDue, string expectedStatusId)
    {
        // Arrange & Act
        var filters = new Filters(filterString);

        // Assert
        Assert.Equal(expectedCategoryId, filters.CategoryId);
        Assert.Equal(expectedDue, filters.Due);
        Assert.Equal(expectedStatusId, filters.StatusId);
    }

    [Theory]
    [InlineData("1-2-3", true)]
    [InlineData("all-2-3", false)]
    public void HasCategory_ReturnsCorrectValue(string filterString, bool expected)
    {
        // Arrange
        var filters = new Filters(filterString);

        // Act
        var result = filters.HasCategory;

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1-future-3", true, false, false)]
    [InlineData("1-past-3", false, true, false)]
    [InlineData("1-today-3", false, false, true)]
    [InlineData("1-2-3", false, false, false)]
    public void DueFilters_ReturnCorrectValues(string filterString, bool expectedIsFuture, bool expectedIsPast, bool expectedIsToday)
    {
        // Arrange
        var filters = new Filters(filterString);

        // Act & Assert
        Assert.Equal(expectedIsFuture, filters.IsFuture);
        Assert.Equal(expectedIsPast, filters.IsPast);
        Assert.Equal(expectedIsToday, filters.IsToday);
    }

    [Theory]
    [InlineData("1-2-3", true)]
    [InlineData("1-all-3", false)]
    public void HasDue_ReturnsCorrectValue(string filterString, bool expected)
    {
        // Arrange
        var filters = new Filters(filterString);

        // Act
        var result = filters.HasDue;

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1-2-3", true)]
    [InlineData("1-2-all", false)]
    public void HasStatus_ReturnsCorrectValue(string filterString, bool expected)
    {
        // Arrange
        var filters = new Filters(filterString);

        // Act
        var result = filters.HasStatus;

        // Assert
        Assert.Equal(expected, result);
    }
}
