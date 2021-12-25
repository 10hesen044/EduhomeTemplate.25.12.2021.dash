using EduhomeTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduhomeTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    public class NoticeController : Controller
    {
        private readonly DataContext _context;

        public NoticeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Notices.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Notice notice)
        {
            _context.Notices.Add(notice);
            _context.SaveChanges();


            return RedirectToAction("index", "notice");
        }
    }
}
