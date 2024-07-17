using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Moq;

namespace ModelBinding.Models
{
    public class HomeController : Controller
    {
        private readonly TicketContext _context;

        public HomeController(TicketContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Statuses = _context.Statuses.ToList();
            ViewBag.DueFilters = Filters.DueFilterValues;

            IQueryable<Ticket> query = _context.Tickets.Include(t => t.Category).Include(t => t.Status);

            if (filters.HasCategory)
            {
                query = query.Where(t => t.CategoryId == filters.CategoryId);
            }

            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }

            if (filters.HasDue)
            {
                var today = DateTime.Today;

                if (filters.IsPast)
                {
                    query = query.Where(t => t.DueDate < today);
                }
                else if (filters.IsFuture)
                {
                    query = query.Where(t => t.DueDate > today);
                }
                else if (filters.IsToday)
                {
                    query = query.Where(t => t.DueDate == today);
                }
            }

            var tasks = query.OrderBy(t => t.DueDate).ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Statuses = _context.Statuses.ToList();
            var task = new Ticket { StatusId = "open" };
            return View(task);
        }

        [HttpPost]
        public IActionResult Add(Ticket task)
        {
            if (ModelState.IsValid)
            {
                _context.Tickets.Add(task);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Statuses = _context.Statuses.ToList();
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { id });
        }

        [HttpPost]
        public IActionResult MarkCompleted(int taskId)
        {
            var task = _context.Tickets.Find(taskId);

            if (task != null)
            {
                task.StatusId = "closed";
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id)
        {
            var toDelete = _context.Tickets.Where(t => t.StatusId == "closed").ToList();

            foreach (var task in toDelete)
            {
                _context.Tickets.Remove(task);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", new { id });
        }
    }
}

public class HomeControllerTests
{
    private readonly Mock<TicketContext> _mockContext;
    private readonly HomeController _controller;

    public HomeControllerTests()
    {
        var options = new DbContextOptionsBuilder<TicketContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
        var context = new TicketContext(options);

        _mockContext = new Mock<TicketContext>(options);
        _controller = new HomeController(_mockContext.Object);
    }

    [Fact]
    public void Add_Get_ReturnsViewResultWithNewTicket()
    {
        // Arrange
        var categories = new List<Category> { new Category { Id = 1, Name = "Category1" } };
        var statuses = new List<Status> { new Status { Id = "open", Name = "Open" } };
        _mockContext.Setup(c => c.Categories.ToList()).Returns(categories);
        _mockContext.Setup(c => c.Statuses.ToList()).Returns(statuses);

        // Act
        var result = _controller.Add();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsType<Ticket>(viewResult.Model);
        Assert.Equal("open", model.StatusId);
    }

    [Fact]
    public void Add_Post_ValidModel_RedirectsToIndex()
    {
        // Arrange
        var ticket = new Ticket { Id = 1, Name = "Test", Description = "Test", StatusId = "open", CategoryId = 1 };

        // Act
        var result = _controller.Add(ticket);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        _mockContext.Verify(c => c.Tickets.Add(ticket), Times.Once);
        _mockContext.Verify(c => c.SaveChanges(), Times.Once);
    }

    [Fact]
    public void Add_Post_InvalidModel_ReturnsViewWithModel()
    {
        // Arrange
        _controller.ModelState.AddModelError("Name", "Required");
        var ticket = new Ticket();

        // Act
        var result = _controller.Add(ticket);

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsType<Ticket>(viewResult.Model);
        Assert.Same(ticket, model);
        _mockContext.Verify(c => c.Tickets.Add(It.IsAny<Ticket>()), Times.Never);
        _mockContext.Verify(c => c.SaveChanges(), Times.Never);
    }

    [Fact]
    public void Filter_Post_RedirectsToIndexWithFilter()
    {
        // Arrange
        var filters = new[] { "Category1", "Due", "Status1" };

        // Act
        var result = _controller.Filter(filters);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        Assert.Equal("Category1-Due-Status1", redirectToActionResult.RouteValues["id"]);
    }

    [Fact]
    public void MarkCompleted_Post_ChangesStatusToClosedAndRedirectsToIndex()
    {
        // Arrange
        var ticket = new Ticket { Id = 1, Name = "Test", StatusId = "open" };
        _mockContext.Setup(c => c.Tickets.Find(1)).Returns(ticket);

        // Act
        var result = _controller.MarkCompleted(1);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        Assert.Equal("closed", ticket.StatusId);
        _mockContext.Verify(c => c.SaveChanges(), Times.Once);
    }

    [Fact]
    public void DeleteComplete_Post_RemovesClosedTicketsAndRedirectsToIndex()
    {
        // Arrange
        var tickets = new List<Ticket>
        {
            new Ticket { Id = 1, StatusId = "closed" },
            new Ticket { Id = 2, StatusId = "open" },
            new Ticket { Id = 3, StatusId = "closed" }
        };
        _mockContext.Setup(c => c.Tickets.Where(t => t.StatusId == "closed")).Returns(tickets.Where(t => t.StatusId == "closed").AsQueryable());

        // Act
        var result = _controller.DeleteComplete("1-closed");

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        _mockContext.Verify(c => c.Tickets.Remove(It.Is<Ticket>(t => t.StatusId == "closed")), Times.Exactly(2));
        _mockContext.Verify(c => c.SaveChanges(), Times.Once);
    }
}