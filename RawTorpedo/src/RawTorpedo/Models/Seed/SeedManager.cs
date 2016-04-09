using System;
using Microsoft.Extensions.DependencyInjection;

namespace RawTorpedo.Models.Seed
{
    public class SeedManager
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            // check each model for .Any(), if none => then seed
            // pass context down for each content type
            // finalize with context.SaveChanges();

            //if (context.Movie.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //context.Movie.AddRange(
            //     new Movie
            //     {
            //         Title = "When Harry Met Sally",
            //         ReleaseDate = DateTime.Parse("1989-1-11"),
            //         Genre = "Romantic Comedy",
            //         Rating = "R",
            //         Price = 7.99M
            //     },

            context.SaveChanges();
        }
    }
}
