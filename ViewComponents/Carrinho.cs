using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.ViewComponents
{
    [ViewComponent(Name ="Carrinho")]
    public class Carrinho : ViewComponent
    {

        public int ItensCarrinhos { get; set; }

        public Carrinho()
        {
            ItensCarrinhos = 2;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinhos);
        }

    }
}
