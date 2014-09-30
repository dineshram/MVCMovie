using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        public string Index()
        {
            return "<b>default</b> action";
        }

        // GET: /HelloWorld/Welcome

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is : " + numTimes);
            return "The welcome action method..";
        }
    }
}