using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Models.Seed
{
    public class SeedMechanics
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Mechanic.Any())
                return;

            context.Mechanic.AddRange(
                new Mechanic { Name = "Action Point Allowance System" },
                new Mechanic { Name = "Co-operative Play" },
                new Mechanic { Name = "Hand Management" },
                new Mechanic { Name = "Point to Point Movement" },
                new Mechanic { Name = "Set Collection" },
                new Mechanic { Name = "Trading" },
                new Mechanic { Name = "Variable Player Powers" },
                new Mechanic { Name = "Area Control / Area Influence" },
                new Mechanic { Name = "Campaign / Battle Card Driven" },
                new Mechanic { Name = "Dice Rolling" },
                new Mechanic { Name = "Simultaneous Action Selection" },
                new Mechanic { Name = "Route/Network Building" },
                new Mechanic { Name = "Worker Placement" },
                new Mechanic { Name = "Tile Placement" }
                    );

            context.SaveChanges();
        }
    }
}
