using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Noteboard.Model;

namespace Noteboard.Pages.Notes
{
    public class NotecardsIndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public NotecardsIndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Notecard> Notecards {get;set;}

        // Bind Property allow post to access this Note object
        [BindProperty]
        public Notecard Notecard {get;set;}

        [HttpGet]
        public async Task OnGet()
        {
            Notecards = await _db.Notecard.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Notecard.AddAsync(Notecard);
                await _db.SaveChangesAsync();
                TempData["Failure"] = "false";
                return RedirectToPage("Index");;
            }
            else
            {
                TempData["Failure"] = "true";
                return RedirectToPage("Index");;
            }
        }
    }
}
