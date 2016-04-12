using System;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

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

            if (bool.Parse(ConfigurationManager.AppSettings["refreshDatabase"]))
            {
                // TODO: delete Designers, Mechanics, Publishers, Themes, Games, and Collections
            }

            // check each model for .Any(), if none => then seed
            // pass context down for each content type
            // finalize with context.SaveChanges();

            SeedDesigners.Initialize(context);
            SeedMechanics.Initialize(context);
            SeedPublishers.Initialize(context);
            SeedThemes.Initialize(context);
            SeedGames.Initialize(context);
            //SeedCollections.Initialize(context);

            context.SaveChanges();
        }
    }
}
