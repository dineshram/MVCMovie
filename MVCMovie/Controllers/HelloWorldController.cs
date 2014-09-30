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

        public string Welcome()
        {
            return "The welcome action method..";
        }
      /*  public ActionResult Index()
        {
            return View();
        }*/
    }
}