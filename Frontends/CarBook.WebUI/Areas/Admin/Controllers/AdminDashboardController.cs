using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminDashboard")]
    public class AdminDashboardController : Controller
    {
        [Route("AdminDashboardIndex")]
        public IActionResult AdminDashboardIndex()
        {
            return View();
        }
    }
}
