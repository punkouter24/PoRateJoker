namespace PoRateJoker.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }

        // Navigation property
        public List<JokeRating> Ratings { get; set; }
    }

}
