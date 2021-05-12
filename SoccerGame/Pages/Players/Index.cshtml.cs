using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoccerGame.Data;
using SoccerGame.Models;

namespace SoccerGame.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly GameContext _context;
        public IndexModel(GameContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Player> Players { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // using System;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Player> playersIQ = from s in _context.Players
                                           select s;

            switch (sortOrder)
            {
                case "name_desc":
                    playersIQ = playersIQ.OrderByDescending(s => s.PlayerName);
                    break;
                case "Date":
                    playersIQ = playersIQ.OrderBy(s => s.Age);
                    break;
                case "date_desc":
                    playersIQ = playersIQ.OrderByDescending(s => s.Position);
                    break;
                default:
                    playersIQ = playersIQ.OrderBy(s => s.Teams);
                    break;
            }

            Players = await playersIQ.AsNoTracking().ToListAsync();
        }
    }
}