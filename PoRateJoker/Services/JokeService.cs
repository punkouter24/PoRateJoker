using Microsoft.EntityFrameworkCore;
using PoRateJoker.Models;

namespace PoRateJoker.Services
{
    public class JokeService
    {
        private readonly ApplicationDbContext _context;

        public JokeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Joke>> GetTopJokesAsync(int count)
        {
            return await _context.Jokes
                .Include(j => j.Ratings)
                .OrderByDescending(j => j.Ratings.Average(r => (double?)r.Rating))
                .ThenByDescending(j => j.Ratings.Count)
                .Take(count)
                .ToListAsync();
        }
    }

}
