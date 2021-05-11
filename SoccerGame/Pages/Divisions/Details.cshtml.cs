using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoccerGame.Data;
using SoccerGame.Models;

namespace SoccerGame.Pages.Divisions
{
    public class DetailsModel : PageModel
    {
        private readonly SoccerGame.Data.GameContext _context;

        public DetailsModel(SoccerGame.Data.GameContext context)
        {
            _context = context;
        }

        public Division Division { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Division = await _context.Divisions.FirstOrDefaultAsync(m => m.DivisionID == id);

            if (Division == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
