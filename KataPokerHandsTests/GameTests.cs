using KataPokerHands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPokerHandsTests
{
	[TestClass]
	public class GameTest
	{
		[TestMethod]
		public void GameTest1()
		{
			Game _game = new Game();
			string result = _game.RunGame("2H 3D 5S 9C KD 2C 3H 4S 8C AH");

			Assert.AreEqual(result, "White wins.");
		}

		[TestMethod]
		[DataRow("2H 4S 4C 2D 4H 2S 8S AS QS 3S")]
		[DataRow("2H 3D 5S 9C KD 2C 3H 4S 8C KH")]
		public void GameTest2(string input)
		{
			Game _game = new Game();
			string result = _game.RunGame(input);

			Assert.AreEqual(result, "Black wins.");
		}

		[TestMethod]
		public void GameTest3()
		{
			Game _game = new Game();
			string result = _game.RunGame("2H 3D 5S 9C KD 2C 3H 4S 8C KH");

			Assert.AreEqual(result, "Black wins.");
		}

		[TestMethod]
		public void GameTest4()
		{
			Game _game = new Game();
			string result = _game.RunGame("2H 3D 5S 9C KD 2D 3H 5C 9S KH");

			Assert.AreEqual(result, "Tie.");
		}
	}
}
