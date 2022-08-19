using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using BookKeeping.Database;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookKeeping.Controllers
{
    public class booksController : Controller
    {
        // GET: /<controller>/
        private readonly BookContext _context;
        public booksController (BookContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }
    }
}

