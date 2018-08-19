using KataPokerHands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPokerHandsTests
{
	[TestClass]
	public class GameTest
	{
		[TestMethod]
		[DataRow("2H 3D 5S 9C KD 2C 3H 4S 8C AH")]
		[DataRow("2H 2D 5S 7D 8C 3H 3D 7S 8D 9C")] // two pair with white being the biggest
		[DataRow("4H 4D 4S 4C 8C 8H 8D 8S 8C 9C")] // four of a kind with white being the biggest
		public void GameTest1(string input)
		{
			Game _game = new Game();
			string result = _game.RunGame(input);

			Assert.AreEqual(result, "White wins.");
		}

		[TestMethod]
		[DataRow("2H 4S 4C 2D 4H 2S 8S AS QS 3S")]
		[DataRow("2H 3D 5S 9C KD 2C 3H 4S 8C KH")]
		[DataRow("4H 4D 5S 7D 8C 3H 3D 7S 8D 9C")] // two pair with black being the biggest
		[DataRow("4H 4D 4S 4C 8C 2H 2D 2S 2C 9C")] // four of a kind with black being the biggest
		public void GameTest2(string input)
		{
			Game _game = new Game();
			string result = _game.RunGame(input);

			Assert.AreEqual(result, "Black wins.");
		}

		[TestMethod]
		[DataRow("2H 3D 5S 9C KD 2D 3H 5C 9S KH")] // tie, cards are equal in power
		public void GameTest3(string input)
		{
			Game _game = new Game();
			string result = _game.RunGame(input);

			Assert.AreEqual(result, "Tie.");
		}
	}
}
