using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KataPokerHands
{
	class Card
	{
		public char Rank { get; private set; }
		public char Suit { get; private set; }

		// Input comes as a two letter string, first letter
		// the number and the second is the suit
		// Ex: "2D" = 2 of Diamonds; "AD" Ace of Diamonds
		public Card(string card)
		{
			Rank = card[0];
			Suit = card[1];
		}

		public override string ToString()
		{
			return Rank + Suit.ToString();
		}

		// Return the number relative to the lettered cards
		// otherwise return the number parsed to int.
		public int RankParsing()
		{
			if (Rank.Equals('T')) return 10;
			if (Rank.Equals('J')) return 11;
			if (Rank.Equals('Q')) return 12;
			if (Rank.Equals('K')) return 13;
			if (Rank.Equals('A')) return 14;
			return Convert.ToInt32(Rank.ToString());
		}

		// See if the card provided is the next number
		// to this one.
		public bool IsPreviousTo(Card card)
		{
			return card.RankParsing() - this.RankParsing() == 1;
		}
	}
}
