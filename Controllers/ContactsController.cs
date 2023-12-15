using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
