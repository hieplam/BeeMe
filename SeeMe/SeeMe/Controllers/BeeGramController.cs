using System.Web.Mvc;

namespace SeeMe.Controllers
{
    public class BeeGramController : Controller
    {
        // GET: BeeGram
        public ActionResult Index()
        {
            return View();
        }
    }
}