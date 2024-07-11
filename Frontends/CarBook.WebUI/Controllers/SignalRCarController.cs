using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult SignalRCarIndex()
        {
            return View();
        }
    }
}
