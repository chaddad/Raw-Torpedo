using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace RawTorpedo.Models.Seed
{
    public class SeedManager
    {
        public static void Initialize(IServiceProvider serviceProvider, bool refreshDatabase = false)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (refreshDatabase)
            {
                context.Collection.RemoveRange(context.Collection.Where(x => x.ID > 0));
                context.Game.RemoveRange(context.Game.Where(x => x.ID > 0));
                context.Designer.RemoveRange(context.Designer.Where(x => x.ID > 0));
                context.Mechanic.RemoveRange(context.Mechanic.Where(x => x.ID > 0));
                context.Publisher.RemoveRange(context.Publisher.Where(x => x.ID > 0));
                context.Theme.RemoveRange(context.Theme.Where(x => x.ID > 0));
                context.SaveChanges();
            }

            // check each model for .Any(), if none => then seed
            // pass context down for each content type
            // finalize with context.SaveChanges();

            SeedDesigners.Initialize(context);
            SeedMechanics.Initialize(context);
            SeedPublishers.Initialize(context);
            SeedThemes.Initialize(context);
            SeedGames.Initialize(context);
            SeedCollections.Initialize(context);

            context.SaveChanges();
        }
    }
}
