using Microsoft.AspNetCore.Mvc;


namespace ClientCatalog.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}