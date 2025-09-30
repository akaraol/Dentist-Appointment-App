using Microsoft.AspNetCore.Mvc;

namespace ClinicAppointments.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
