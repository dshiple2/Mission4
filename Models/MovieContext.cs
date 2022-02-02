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

        public DbSet<Category> Categories { get; set; }

        //seed data


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Horror"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Romance"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Mystery"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Goat"
                }
            );
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryID = 1,
                    Title = "Surfs Up",
                    Year = 2005,
                    Director = "Hilton",
                    Rating = "R"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryID = 1,
                    Title = "Megamind",
                    Year = 2006,
                    Director = "Washington",
                    Rating = "G"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryID = 6,
                    Title = "Shrek",
                    Year = 2002,
                    Director = "Nieldman",
                    Rating = "PG"
                }
            );
        }
    }
}
