using System;
using System.Linq;

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
                },
                new Game {
                    GameName = "Twilight Struggle",
                    Designer = context.Designer.Where(x => x.Name == "Ananda Gupta" || x.Name == "Jason Matthews").ToList(),
                    MaxNumberOfPlayers = 2,
                    MinNumberOfPlayers = 2,
                    SweetNumberOfPlayers = 2,
                    Playtime = Domain.Enums.Playtime.WickedLong,
                    PublishedDate = new DateTime(2005, 1, 1),
                    Publisher = context.Publisher.Where(x => x.Name == "GMT Games" || x.Name == "(Self-Published)").ToList(),
                    Mechanics = context.Mechanic.Where(x => x.Name == "Area Control / Area Influence" || x.Name == "Campaign / Battle Card Driven" || x.Name == "Dice Rolling" || x.Name == "Hand Management" || x.Name == "Simultaneous Action Selection").ToList(),
                    Themes = context.Theme.Where(x => x.Name == "Modern Warfare" || x.Name == "Political" || x.Name == "Wargame").ToList(),
                    BGGID = 12333,
                    BGGUrl = @"https://boardgamegeek.com/boardgame/12333/twilight-struggle"
                },
                new Game {
                    GameName = "Terra Mystica",
                    Designer = context.Designer.Where(x => x.Name == "Jens Drögemüller" || x.Name == "Helge Ostertag").ToList(),
                    MaxNumberOfPlayers = 5,
                    MinNumberOfPlayers = 2,
                    SweetNumberOfPlayers = 4,
                    Playtime = Domain.Enums.Playtime.Long,
                    PublishedDate = new DateTime(2012, 1, 1),
                    Publisher = context.Publisher.Where(x => x.Name == "Z-Man Games" || x.Name == "MINDOK").ToList(),
                    Mechanics = context.Mechanic.Where(x => x.Name == "Route/Network Building" || x.Name == "Variable Player Powers" || x.Name == "Worker Placement").ToList(),
                    Themes = context.Theme.Where(x => x.Name == "Civilization" || x.Name == "Economic" || x.Name == "Fantasy" || x.Name == "Territory Building").ToList(),
                    BGGID = 120677,
                    BGGUrl = @"https://boardgamegeek.com/boardgame/120677/terra-mystica"
                },
                new Game {
                    GameName = "Caverna: The Cave Farmers",
                    Designer = context.Designer.Where(x => x.Name == "Uwe Rosenberg").ToList(),
                    MaxNumberOfPlayers = 7,
                    MinNumberOfPlayers = 1,
                    SweetNumberOfPlayers = 4,
                    Playtime = Domain.Enums.Playtime.Long,
                    PublishedDate = new DateTime(2013, 1, 1),
                    Publisher = context.Publisher.Where(x => x.Name == "Lookout Games" || x.Name == "MINDOK").ToList(),
                    Mechanics = context.Mechanic.Where(x => x.Name == "Tile Placement" || x.Name == "Worker Placement").ToList(),
                    Themes = context.Theme.Where(x => x.Name == "Animals" || x.Name == "Economic" || x.Name == "Fantasy" || x.Name == "Farming").ToList(),
                    BGGID = 102794,
                    BGGUrl = @"https://boardgamegeek.com/boardgame/102794/caverna-cave-farmers"
                }
                );

            context.SaveChanges();
        }
    }
}
