namespace PoRateJoker.Models
{
    public class JokeRating
    {
        public int Id { get; set; }
        public int JokeId { get; set; }
        public int Rating { get; set; }

        // Navigation property
        public Joke Joke { get; set; }
    }


}
