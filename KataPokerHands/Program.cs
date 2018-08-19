using System;
using System.Collections.Generic;
using System.Text;

namespace KataPokerHands
{
	class Program
	{
		public static void Main(string []args)
		{
			Game _game = new Game();

			string result = _game.RunGame("2H 2D 5S 7D 8C 3H 3D 7S 8D 9C");

			Console.WriteLine(result);
		}
		
	}
}
