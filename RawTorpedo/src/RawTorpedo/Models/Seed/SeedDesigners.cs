using RawTorpedo.Models.Support;
using System.Linq;

namespace RawTorpedo.Models.Seed
{
    public class SeedDesigners
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Designer.Any())
                return;

            context.Designer.AddRange(
                new Designer { Name = "Uwe Rosenberg" },
                new Designer { Name = "Jens Drögemüller" },
                new Designer { Name = "Helge Ostertag" },
                new Designer { Name = "Ananda Gupta" },
                new Designer { Name = "Jason Matthews" },
                new Designer { Name = "Rob Daviau" },
                new Designer { Name = "Matt Leacock" }
                );

            context.SaveChanges();
        }
    }
}
