using Microsoft.EntityFrameworkCore;
using PoRateJoker.Models;

namespace PoRateJoker.Services
{
    public class RatingService
    {
        private readonly ApplicationDbContext _context;

        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveJokeAndRatingAsync(Joke joke, JokeRating rating)
        {
            // Check if the joke already exists
            var existingJoke = await _context.Jokes.FirstOrDefaultAsync(j => j.Id == joke.Id);
            if (existingJoke == null)
            {
                // Insert the joke if it does not exist
                _context.Jokes.Add(joke);
            }

            // Add the rating
            _context.JokeRatings.Add(rating);

            // Save changes
            await _context.SaveChangesAsync();
        }
    }

}
