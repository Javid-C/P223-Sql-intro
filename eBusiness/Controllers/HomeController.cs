using eBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBusiness.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider()
                {
                    Id = 1,
                    Order=1,
                    Image = "1.jpg",
                    Title = "The Best Business Information",
                    Description = "We're In The Business Of Helping You Start Your Business",
                    RedirectUrl = "https://www.google.com"
                },
                new Slider()
                {
                    Id = 2,
                    Order = 2,
                    Image = "2.jpg",
                    Title = "At vero eos et accusamus",
                    Description = "Helping Business Security & Peace of Mind for Your Family",
                    RedirectUrl = "https://www.shazam.com"
                },
                new Slider()
                {
                    Id = 3,
                    Order =3,
                    Image = "3.jpg",
                    Title = "Temporibus autem quibusdam",
                    Description = "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem",
                    RedirectUrl = "https://www.github.com"
                }
            };
            return View(sliders);
        }
    }
}
