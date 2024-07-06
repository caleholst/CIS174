using ModelBinding.Models;

public static class TicketExtensions
{
    public static bool IsOverdue(this Ticket ticket)
    {
        return ticket.StatusId == "open" && ticket.DueDate < DateTime.Today;
    }
}