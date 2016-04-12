using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawTorpedo.Models.Seed
{
    public class SeedCollections
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Collection.Any())
                return;

            var userId = @"56f72ab1-1a84-486c-b219-04fb1ca94aa9";
            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            if (user == null)
                return;
            
            // add collection
            context.Collection.Add(new Collection
            {
                User = user,
                CollectionType = Domain.Enums.CollectionType.Collection,
                Game = context.Game.FirstOrDefault(x => x.GameName == "Pandemic Legacy: Season 1")
            });

            // add wishlist
            context.Collection.Add(new Collection
            {
                User = user,
                CollectionType = Domain.Enums.CollectionType.Wishlist,

            });

            context.SaveChanges();
        }
    }
}
