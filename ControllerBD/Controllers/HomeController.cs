using Microsoft.AspNetCore.Mvc;

namespace ControllerBD.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
