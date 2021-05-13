using SoccerGame.Data;
using SoccerGame.Models;
using System;
using System.Linq;

namespace SoccerGame.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GameContext context)
        {
          context.Database.EnsureCreated();
       
            // Look for any students.
            if (context.Players.Any())
            {
                return;   // DB has been seeded
            }


            var divisions = new Division[]
{
               new Division {Division_Name = "Major League", Location = "USA"},
               new Division {Division_Name = "USL Championship", Location = "UK" },
               new Division {Division_Name = "USL League One ", Location = "Canda"},
               new Division {Division_Name = "USL League Two ", Location = "New Zealand" }
};

            context.Divisions.AddRange(divisions);
            context.SaveChanges();


            var teams = new Team[]
            {
                new Team {TeamName = "Manchester", DivisionID = 1},
                new Team {TeamName = "LiverPool", DivisionID = 1},
                new Team {TeamName = "Chelsea", DivisionID = 1},


                new Team {TeamName = "Arsenal  ", DivisionID = 2},
                new Team {TeamName = "Inter Milan", DivisionID = 2},
                new Team {TeamName = "Barcelona", DivisionID = 2},


                new Team {TeamName = "Tottemham", DivisionID = 3},
                new Team {TeamName = "Juventus", DivisionID = 3},
                new Team {TeamName = "A.C Milan", DivisionID = 3},


                new Team {TeamName = "Roma", DivisionID = 4},
                new Team {TeamName = "Galaxy", DivisionID = 4},
                new Team {TeamName = "Toronto", DivisionID = 4}



            };

            context.Teams.AddRange(teams);
            context.SaveChanges();
            var players = new Player[]
{
                new Player{PlayerName = "Mike Davis", Age = 16, Position = "Defender", TeamID = 1},
                new Player{PlayerName = "Tasnim Jacobs", Age = 15, Position = "Midfielder", TeamID = 1},
                new Player{PlayerName = "Nieve Lees", Age = 14, Position = "Goalkeeper", TeamID = 1},
                new Player{PlayerName = "Iyla Marsden", Age = 16, Position = "Attacker", TeamID = 1},
                new Player{PlayerName = "Atlas Gallegos", Age = 17, Position = "Attacker", TeamID = 1},
                new Player{PlayerName = "Louise Busby", Age = 18, Position = "Defender", TeamID = 1},

                new Player{PlayerName = "Anisah Salazar", Age = 16, Position = "Defender", TeamID = 2},
                new Player{PlayerName = "Laurel Dunkley", Age = 13, Position = "Midfielder", TeamID = 2},
                new Player{PlayerName = "Rex Finch", Age = 14, Position = "Goalkeeper", TeamID = 2},
                new Player{PlayerName = "Tamera Alvarez", Age = 15, Position = "Attacker", TeamID = 2},
                new Player{PlayerName = "Leigh Milner", Age = 17, Position = "Attacker", TeamID = 2},
                new Player{PlayerName = "Kavita Shea", Age = 16, Position = "Defender", TeamID = 2},

                 new Player{PlayerName = "Fatimah Mosley", Age = 16, Position = "Defender", TeamID = 3},
                new Player{PlayerName = "Claude Tang", Age = 13, Position = "Midfielder", TeamID = 3},
                new Player{PlayerName = "Ottilie Mckeown", Age = 14, Position = "Goalkeeper", TeamID = 3},
                new Player{PlayerName = "Maximilian Dowling", Age = 16, Position = "Attacker", TeamID = 3},
                new Player{PlayerName = "Taslima Merritt", Age = 17, Position = "Attacker", TeamID = 3},
                new Player{PlayerName = "Don Ryan", Age = 18, Position = "Defender", TeamID = 3},

                 new Player {PlayerName = "Theresa Stevens", Age = 16, Position = "Defender", TeamID = 4},
                new Player {PlayerName = "Mateo Reader", Age = 14, Position = "Midfielder", TeamID = 4},
                new Player {PlayerName = "Johnny Waller", Age = 13, Position = "Goalkeeper", TeamID = 4},
                new Player {PlayerName = "Rayan Hoover", Age = 15, Position = "Attacker", TeamID = 4},
                new Player {PlayerName = "Norah Redman", Age = 16, Position = "Attacker", TeamID = 4},
                new Player {PlayerName = "Rahul Enriquez", Age = 17, Position = "Defender", TeamID = 4}

            

};

            context.Players.AddRange(players);
            context.SaveChanges();








        }
    }
}