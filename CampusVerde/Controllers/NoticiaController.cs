using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusVerde.Controllers
{
    public class NoticiaController : Controller
    {
        // GET: Noticia
        public ActionResult Index(int idNoticia)
        {
            ViewBag.idNoticia = idNoticia;
            return View();
        }
    }
}