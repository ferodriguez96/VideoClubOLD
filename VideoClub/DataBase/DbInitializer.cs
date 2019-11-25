using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;

namespace VideoClub.DataBase
{
    public static class DbInitializer
    {
        public static void Initialize(VideoClubDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Peliculas.Any())
            {
                return;   // DB has been seeded
            }
        }
    }
}
