using eBusiness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBusiness.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Blog blog = _context.Blogs.Include(b=>b.BlogComments).FirstOrDefault(b=>b.Id == id);

            if(blog == null)
            {
                return Content("Are you cola?");
            }
            return View(blog);
        }
    }
}
