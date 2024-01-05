using Microsoft.EntityFrameworkCore;
using PoRateJoker.Models;

namespace PoRateJoker
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Joke> Jokes { get; set; }
        public DbSet<JokeRating> JokeRatings { get; set; }
    }
}
