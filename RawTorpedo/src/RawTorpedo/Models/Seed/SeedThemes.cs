﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawTorpedo.Models.Seed
{
    public class SeedThemes
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Theme.Any())
                return;


        }
    }
}
