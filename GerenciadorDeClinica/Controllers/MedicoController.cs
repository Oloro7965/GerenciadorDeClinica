using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeClinica.Controllers
{
    public class MedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
