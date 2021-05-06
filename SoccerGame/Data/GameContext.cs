using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerGame.Models;

namespace SoccerGame.Data
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public DbSet<SoccerGame.Models.Player> Player { get; set; }

        public DbSet<SoccerGame.Models.Team> Team { get; set; }

        public DbSet<SoccerGame.Models.Division> Division { get; set; }
    }
}
