using Microsoft.EntityFrameworkCore;
using MovieTracker.Library.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTrackerApi.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            :base(options) { }
        
        public DbSet<MovieItem> MovieItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieItem>(entity =>
            {
                entity.ToTable("movie_list", "movie");

                entity.HasKey(e => e.movie_id)
                      .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
            });
        }
    }

}
