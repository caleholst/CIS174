using Microsoft.AspNetCore.Mvc;

namespace ModelBinding.ViewComponents
{
    public class StatusButtonsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string currentStatus)
        {
            var statuses = new List<string> { "To Do", "In Progress", "Quality Assurance (QA)", "Done" };
            ViewBag.CurrentStatus = currentStatus;
            return View(statuses);
        }
    }
}