using System;
using Microsoft.EntityFrameworkCore;

namespace m4.Models
{
    public class MovieApplicationContext: DbContext
    {
       public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options): base(options)
        {

        }
        public DbSet<FormResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    FormID = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year="2012",
                    Director="Joss Whedon",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormID = 2,
                    Category = "Action/Adventure",
                    Title = "Dark Knight, The",
                    Year = "2008",
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new FormResponse
                {
                    FormID = 3,
                    Category = "Action/Adventure",
                    Title = "Matrix, The",
                    Year = "1999",
                    Director = "The Wachowski Brothers",
                    Rating = "R",
                    Edited = false
                }



            );
        }
    }
}
