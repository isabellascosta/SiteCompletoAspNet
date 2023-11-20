using Microsoft.AspNetCore.Mvc;

namespace SiteCompleto.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
