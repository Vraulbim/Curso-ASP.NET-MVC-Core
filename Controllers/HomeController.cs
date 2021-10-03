using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Controllers
{
    [Route("")]
    [Route("Clientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Página-inicial")]
        [Route("Página-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {
            var filme = new Filme{
                Titulo = "Batman",
                DataLancamento = DateTime.Now,
                Genero = "",
                Avaliacao = 10,
                Valor = 10.23M
            };


            //return RedirectToAction("Privacy", filme);
            return View();
        }

        [Route("Privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View();
        }

        [Route("Erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
