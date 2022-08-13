using Microsoft.AspNetCore.Mvc;

namespace WebSignalR.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
