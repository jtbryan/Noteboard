using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Noteboard.Pages.Notes
{
    public class NotesIndexModel : PageModel
    {
        private readonly ILogger<NotesIndexModel> _logger;

        public NotesIndexModel(ILogger<NotesIndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
