using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission4Jan24.Models
{
    public class MovieContext : DbContext
    {
        //context
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            // blank for now
        }
        public DbSet<ApplicationResponse> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Family",
                    Title = "Surfs Up",
                    Year = 2005,
                    Director = "Hilton",
                    Rating = "R"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Family",
                    Title = "Megamind",
                    Year = 2006,
                    Director = "Washington",
                    Rating = "G"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Category = "Family",
                    Title = "Shrek",
                    Year = 2002,
                    Director = "Nieldman",
                    Rating = "PG"
                }
            );
        }
    }
}
