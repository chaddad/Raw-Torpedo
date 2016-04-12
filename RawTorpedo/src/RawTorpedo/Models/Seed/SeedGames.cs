using RawTorpedo.Models.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawTorpedo.Models.Seed
{
    public class SeedGames
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Game.Any())
                return;

            context.Game.AddRange(
                new Game {
                    GameName = "Pandemic Legacy: Season 1",
                    Designer = context.Designer.Where(x => x.Name == "Rob Daviau" || x.Name == "Matt Leacock").ToList(),
                    MaxNumberOfPlayers = 4,
                    MinNumberOfPlayers = 2,
                    SweetNumberOfPlayers = 4,
                    Playtime = Domain.Enums.Playtime.Medium,
                    PublishedDate = new DateTime(2015, 1, 1),
                    Publisher = context.Publisher.Where(x => x.Name == "Z-Man Games").ToList(),
                    Mechanics = context.Mechanic.Where(x => x.Name == "Action Point Allowance System" || x.Name == "Co-operative Play" || x.Name == "Set Collection").ToList(),
                    Themes = context.Theme.Where(x => x.Name == "Environmental" || x.Name == "Medical").ToList(),
                    BGGID = 161936,
                    BGGUrl = @"https://boardgamegeek.com/boardgame/161936/pandemic-legacy-season-1"                    
                    }
                );

            context.SaveChanges();
        }
    }
}
