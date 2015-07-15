using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int Id = 1)
        {
            return HttpUtility.HtmlEncode(string.Format("Hello, {0}, ID: {1}", name, Id));
        }
    }
}