using MongoCRUD.DAO;
using MongoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MongoCRUD.Controllers
{
    public class LojaApiController : ApiController
    {
        
        [HttpPost]
        public void Adicionar(LojaModel novaLoja)
        {
            LojaDAO dao = new LojaDAO();
            dao.Adicionar(novaLoja);

        }

        [HttpGet]
        public void Listar()
        {
            LojaDAO dao = new LojaDAO();
            dao.Listar();
        }

    }
}
