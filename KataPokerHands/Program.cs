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

			string result = _game.RunGame("3H 3D 5S 6D 8C 3H 3D 5S 6D 8D");

			Console.WriteLine(result);
		}
		
	}
}
