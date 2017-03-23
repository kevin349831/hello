using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWord.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            ViewBag.Desc = "Hello word";
            return View();
        }

    }
}
