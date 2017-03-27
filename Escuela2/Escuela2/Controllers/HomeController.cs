using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Escuela2.Models;
using Escuela2.ViewModel;

namespace Escuela2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Alumno> Datos = AlumnoViewModel.ListarContenido();
            ViewBag.Datos = Datos;

            return View();
        }
        public ActionResult VerDetalle(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}