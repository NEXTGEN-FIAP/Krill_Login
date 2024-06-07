using Microsoft.AspNetCore.Mvc;

namespace KrillMonitoringSystem.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
