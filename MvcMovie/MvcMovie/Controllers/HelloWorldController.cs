using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit htaps://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my defaul action...";

        //}

        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/

        //public string Welcome(string name, int numTimes=1)

        //{
        //    return "This is the Welcome action method...";

        //}
        //public string Welcome(string name, int numTimes = 1)

        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        //public string Welcome(string name, int ID = 1)

        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}