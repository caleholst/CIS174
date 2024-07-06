using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class TicketController : Controller
{
    private readonly OlympicContext _context;

    public TicketController(OlympicContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tickets = _context.Tickets
            .Include(t => t.Status).ToList();

        return View(tickets);
    }

    [HttpGet]
    public IActionResult Add()
    {
        ViewBag.Statuses = new SelectList(new[]
        {
            new { Value = "Open", Text = "Open" },
            new { Value = "Closed", Text = "Closed" }
        }, "Value", "Text");
        return View();
    }

    [HttpPost]
    public IActionResult Add(Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewBag.Statuses = new SelectList(new[]
        {
            new { Value = "Open", Text = "Open" },
            new { Value = "Closed", Text = "Closed" }
        }, "Value", "Text");
        return View(ticket);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var ticket = _context.Tickets.Find(id);
        if (ticket == null)
        {
            return NotFound();
        }

        ViewBag.Statuses = new SelectList(new[]
        {
            new { Value = "Open", Text = "Open" },
            new { Value = "Closed", Text = "Closed" }
        }, "Value", "Text");
        return View(ticket);
    }

    [HttpPost]
    public IActionResult Edit(Ticket ticket)
    {
        if (ModelState.IsValid)
        {
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        ViewBag.Statuses = new SelectList(new[]
        {
            new { Value = "Open", Text = "Open" },
            new { Value = "Closed", Text = "Closed" }
        }, "Value", "Text");
        return View(ticket);
    }

    public IActionResult MarkCompleted(int id)
    {
        var ticket = _context.Tickets.Find(id);
        if (ticket == null)
        {
            return NotFound();
        }

        ticket.Status = "Completed";
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}