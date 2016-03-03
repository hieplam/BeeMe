using System.Web.Mvc;
using SeeMe.Models;

namespace SeeMe.Controllers
{
    public class ImageDetailController : Controller
    {
        public ActionResult Index()
        {
            var model = new ImageDetailModel
            {
                ArtistName ="Lam TaHy",
                ImageDescription = "This is the first Tahy picture",
                ImageName = "My Image"
            };

            return View(model);
        }
    }
}