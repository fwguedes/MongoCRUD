using MongoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MongoCRUD.Controllers
{
    public class LojaController : Controller
    {
        // GET: Loja
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Adicionar([FromBody]LojaModel novaLoja)
        {


            return View();
        }

        public ActionResult Novo()
        {


            return View();
        }
    }
}