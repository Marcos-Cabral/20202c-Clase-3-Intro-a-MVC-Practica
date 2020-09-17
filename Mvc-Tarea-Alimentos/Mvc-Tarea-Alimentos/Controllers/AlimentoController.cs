using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Tarea_Alimentos.Controllers
{
    public class AlimentoController : Controller
    {
        AlimentoServicio alimentoServicio = new AlimentoServicio();
        // GET: Alimento
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(Alimento alimento)
        {
            alimentoServicio.Alta(alimento);
            return RedirectToAction("Todos");
        }
        public ActionResult Todos()
        {
            return View();
        }
        public ActionResult Editar(Alimento alimento)
        {
            alimentoServicio.Editar(alimento);
            return RedirectToAction("Todos");
        }
        public ActionResult Borrar(int id)
        {
            alimentoServicio.Borrar(id);
            return RedirectToAction("Todos");
        }
    }
}