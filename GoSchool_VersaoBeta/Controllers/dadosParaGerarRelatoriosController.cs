using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoSchool_VersaoBeta.Controllers
{
    public class DadosParaGerarRelatoriosController : Controller
    {
        // GET: dadosParaGerarRelatorios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuDadosHorario()
        {
            return PartialView("MenuDadosHorario");
        }
    }
}