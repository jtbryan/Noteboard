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
    public class NotesIndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public NotesIndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Note> Notes {get;set;}

        // Bind Property allow post to access this Note object
        [BindProperty]
        public Note Note {get;set;}

        [HttpGet]
        public async Task OnGet()
        {
            Notes = await _db.Note.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Note.AddAsync(Note);
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
