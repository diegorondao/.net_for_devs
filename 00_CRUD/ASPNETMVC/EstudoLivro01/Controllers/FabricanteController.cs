﻿using EstudoLivro01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstudoLivro01.Controllers
{
    public class FabricanteController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Fabricante
        public ActionResult Index()
        {
           return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}