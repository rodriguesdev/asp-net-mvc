﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreinaWeb.TesteASPNETMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome)
        {
            ViewBag.Mensagem = nome;
            return View("Saudacao");
        }
    }
}