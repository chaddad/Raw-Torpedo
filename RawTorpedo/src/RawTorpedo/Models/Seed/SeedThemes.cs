using RawTorpedo.Models.Support;
using System.Linq;

namespace RawTorpedo.Models.Seed
{
    public class SeedThemes
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Theme.Any())
                return;

            context.Theme.AddRange(
                new Theme { Name = "Sci-fi"},
                new Theme { Name = "Environmental" },
                new Theme { Name = "Medical" },
                new Theme { Name = "Modern Warfare" },
                new Theme { Name = "Political" },
                new Theme { Name = "Wargame" },
                new Theme { Name = "Civilization" },
                new Theme { Name = "Economic" },
                new Theme { Name = "Fantasy" },
                new Theme { Name = "Territory Building" },
                new Theme { Name = "Animals" },
                new Theme { Name = "Farming" }
                );

            context.SaveChanges();
        }
    }
}
