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
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.OrderBy(x=>x.Order).ToList();
            return View(sliders);
        }
    }
}
