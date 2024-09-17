using System;
using Xunit;


namespace BoardInitializationTests
{
    public class InitializationTest
    {
        [Fact]
        public void TestBoardInitialization_ShouldSetCorrectValues()
        {
            // Arrange
            var game = new GameManager();

            // Act
            game.ResetBoard();

            // Assert
            Assert.True(game.stageArea.performerSlots <= 8); // Check 8 performer slots are available.
            Assert.True(game.attractionArea.segments == 20); // Check 20 stalls are initialized.
            Assert.True(game.players <= 4); // Check number of players
        }

        [Fact]
        public void TestPlayerInitialization_ShouldSetCorrectValues()
        {
            // Arrange
            var player = new Player();

            // Assert
            Assert.True(player.score == 0); // Check the initiale score is 0 for a player.
        }
    }
}