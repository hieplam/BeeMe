﻿using System.Web.Mvc;
using SeeMe.Models;

namespace SeeMe.Controllers
{
    public class ImageDetailController : Controller
    {
        public ActionResult Index()
        {
            var model = new ImageDetailModel
            {
                Artist = new Artist
                {
                    JobTitle = "Senior 2D Concept Artist",
                    AvatarUrl = "sourcehinh/ArtistAvatar/2.jpg",
                    Name = "Arctica Lam"
                },
                Description = "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                Title = "March",
                ImageUrl = "sourcehinh/6.jpg"
            };

            return View(model);
        }
    }
}