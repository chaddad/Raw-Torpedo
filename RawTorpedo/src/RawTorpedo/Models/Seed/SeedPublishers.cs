using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Models.Seed
{
    public class SeedPublishers
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Publisher.Any())
                return;

            context.Publisher.AddRange(
                new Publisher { Name = "Lookout Games" },
                new Publisher { Name = "999 Games" },
                new Publisher { Name = "Devir" },
                new Publisher { Name = "Filosofia Éditions" },
                new Publisher { Name = "Hobby Japan" },
                new Publisher { Name = "HomoLudicus" },
                new Publisher { Name = "Korea Boardgames co., Ltd." },
                new Publisher { Name = "Lacerta" },
                new Publisher { Name = "Mayfair Games" },
                new Publisher { Name = "MINDOK" },
                new Publisher { Name = "uplay.it edizioni" },
                new Publisher { Name = "Feuerland Spiele" },
                new Publisher { Name = "Bard Centrum Gier" },
                new Publisher { Name = "Cranio Creations" },
                new Publisher { Name = "FunBox Jogos" },
                new Publisher { Name = "Swan Panasia Co., Ltd." },
                new Publisher { Name = "テンデイズゲームズ (Ten Days Games)" },
                new Publisher { Name = "White Goblin Games" },
                new Publisher { Name = "Z-Man Games" },
                new Publisher { Name = "Zvezda" },
                new Publisher { Name = "GMT Games" },
                new Publisher { Name = "(Self-Published)" },
                new Publisher { Name = "Asterion Press" },
                new Publisher { Name = "Udo Grebe Gamedesign" },
                new Publisher { Name = "Wargames Club Publishing" },
                new Publisher { Name = "Jolly Thinkers" },
                new Publisher { Name = "Lifestyle Boardgames Ltd" }
                );

            context.SaveChanges();
        }
    }
}
