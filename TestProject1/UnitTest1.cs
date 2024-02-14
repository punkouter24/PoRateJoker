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
    }
}