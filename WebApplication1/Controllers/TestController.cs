using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        private Models.Person p = new Models.Person();
        // GET: Default
        public ActionResult Index()
        {
            p.FirstName = "Rob";
            p.LastName = "Riedinger";
            p.TwitterHandle = "@riedstep";
            return View(p);
        }
    }
}