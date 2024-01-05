using Bunit;
using Microsoft.EntityFrameworkCore;
using Moq;
using PoRateJoker;
using PoRateJoker.Models;
using PoRateJoker.Services;

namespace TestProject1
{
    public class JokeServiceTests
    {
        [Fact]
        public void GetTopJokes_ReturnsCorrectNumberOfJokes()
        {
            // Arrange
            Mock<DbSet<Joke>> mockDbSet = new();
            Mock<ApplicationDbContext> mockContext = new();
            _ = mockContext.Setup(c => c.Jokes).Returns(mockDbSet.Object);

            JokeService jokeService = new(mockContext.Object);

            // Act
            List<Joke> jokes = jokeService.GetTopJokesAsync(10).Result;

            // Assert
            Assert.Equal(10, jokes.Count);
        }

        //[Fact]
        //public void JokeDisplay_ShowsJokeContent()
        //{
        //    // Arrange
        //    using var ctx = new TestContext();
        //    Joke joke = new() { Setup = "Joke setup", Punchline = "Joke punchline" };

        //    // Act
        //    var cut = ctx.RenderComponent<JokeDisplay>(parameters => parameters
        //      .Add(p => p.Joke, joke)
        //    );

        //    // Assert
        //    cut.MarkupMatches("<div><p>Joke setup</p><p>Joke punchline</p></div>");
        //}
    }
}