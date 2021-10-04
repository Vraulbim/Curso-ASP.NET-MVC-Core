using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMVC.Controllers
{
    [Route("Filme")]
    public class FilmesController : Controller
    {
        [HttpGet]
        public ActionResult Adicionar()
        {
            return View();
        }
    }
}
