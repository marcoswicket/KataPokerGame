using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KataPokerHands
{
	class Hand
	{
		public readonly Card[] _cards;

		public Hand(string cards)
		{
			var aux = cards.Split(' ');
			_cards = (from card in aux select new Card(card)).OrderBy(c => c.RankParsing()).ToArray();
		}

	}
}
