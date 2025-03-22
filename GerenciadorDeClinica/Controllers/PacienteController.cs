using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeClinica.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
