using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is <b>default</b> Action";
        }
        // Post: Parameters
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Name: " + name + ", numTimes is: " + ID );
        }
    }
}