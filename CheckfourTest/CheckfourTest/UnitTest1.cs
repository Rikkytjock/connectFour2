using Xunit;

namespace ConnectFour.Tests
{
    public class ConnectFourTests
    {
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            var gameState = new GameState();

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.No_Winner, result);
        }

        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();
            gameState.TheBoard = new List<int> { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.Tie, result);
        }
    }
}