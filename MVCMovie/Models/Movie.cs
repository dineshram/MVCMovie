using System;
using System.Data.Entity;

// Movie class to represent movies in a database. Each instance of a Movie object will correspond 
// to a row within a database table, and each property of the Movie class will map to a column in the table
namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Decimal Price { get; set; }
    }
    // MovieDBContext class represents the Entity Framework movie database context, which handles fetching, storing, and updating Movie class instances in a database. 
    // The MovieDBContext derives from the DbContext base class provided by the Entity Framework. 
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}