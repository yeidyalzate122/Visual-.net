using Adminsitracion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adminsitracion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult DatosPersonales(Datos obj )
        {

            // se valida si los datos estan
            if(ModelState.IsValid)
               {

                return View(obj);

            }
            else
            {
                return View("Index");
            }
            
        }
    }
}