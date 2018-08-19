using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPokerHands
{
	public class Game
	{
		enum Score
		{
			HighCard,
			OnePair,
			TwoPair,
			ThreeOfAKind,
			Straight,
			Flush,
			FullHouse,
			FourOfAKind,
			StraightFlush
		};

		private const string BlackWin = "Black wins.";
		private const string WhiteWin = "White wins.";
		private const string Tie = "Tie.";

		private Hand _handWhite, _handBlack;
		private Score? _whiteScore, _blackScore;

		private int _whiteRank, _blackRank;

		public Game()
		{

		}

		//public Game(string cards)
		//{
		//	// First player is black second is white
		//	string handBlack = cards.Substring(0, 14);
		//	string handWhite = cards.Substring(15, 14);

		//	_handWhite = new Hand(handWhite);
		//	_handBlack = new Hand(handBlack);
		//}

		private Score? FullHouse(Hand _hand)
		{
			char threeOfAKindRank = FindGroupsOfSize(_hand, 3).FirstOrDefault();
			char pairRank = FindGroupsOfSize(_hand, 2).FirstOrDefault();

			if (threeOfAKindRank != default(char) && pairRank != default(char))
				return Score.ThreeOfAKind;

			return null;
		}

		private Score? StraightFlush(Hand _hand)
		{
			if (Flush(_hand) != null)
			{
				Score? result = Straight(_hand);
				if (result != null)
					return Score.StraightFlush;
			}

			return null;
		}

		private Score? HighCard(Hand _hand)
		{
			return Score.HighCard;
		}

		private Score? Flush(Hand _hand)
		{
			for (int cardIndex = 3; cardIndex > 0; cardIndex--)
			{
				// If its not a sequence return nothing
				if (!_hand._cards[cardIndex].IsPreviousTo(_hand._cards[cardIndex - 1]))
				{
					return null;
				}
			}

			return Score.StraightFlush;
		}

		private Score? Straight(Hand _hand)
		{
			for (int cardIndex = 0; cardIndex < 4; cardIndex++)
			{
				if (!_hand._cards[cardIndex].IsPreviousTo(_hand._cards[cardIndex + 1]))
				{
					return null;
				}
			}

			bool isNormalStraight = _hand._cards[3].IsPreviousTo(_hand._cards[4]);
			if (isNormalStraight)
			{
				return Score.Straight;
			}

			bool isAceLowStraight = _hand._cards[4].Rank == 'A' && _hand._cards[0].Rank == '2';
			if (isAceLowStraight)
			{
				return Score.Straight;
			}

			return null;
		}

		private Score? OnePair(Hand _hand)
		{
			_hand.rank = FindCardsEqualRank(_hand, 2);
			if (_hand.rank != null)
			{
				return Score.OnePair;
			}
			return null;
		}

		private Score? TwoPairs(Hand _hand)
		{
			_hand.group = FindGroupsOfSize(_hand, 2);

			if (_hand.group.Count() == 2)
			{
				return Score.TwoPair;
			}

			return null;
		}

		private Score? ThreeOfAKind(Hand _hand)
		{
			_hand.rank = FindCardsEqualRank(_hand, 3);
			if (_hand.rank != null)
			{
				return Score.ThreeOfAKind;
			}
			return null;
		}

		private Score? FourOfAKind(Hand _hand)
		{
			_hand.rank = FindCardsEqualRank(_hand, 4);
			if (_hand.rank != null)
			{
				return Score.FourOfAKind;
			}
			return null;
		}

		private char? FindCardsEqualRank(Hand _hand, int size)
		{
			var groups = FindGroupsOfSize(_hand, size);
			if (groups.Count() == 1)
			{
				return groups.Single();
			}

			return null;
		}

		private IEnumerable<char> FindGroupsOfSize(Hand _hand, int size)
		{
			return _hand._cards.GroupBy(c => c.Rank).Where(c => c.Count() == size).Select(e => e.Key);
		}

		private Score? GetScore(Hand _hand)
		{
			return StraightFlush(_hand) ??
					FourOfAKind(_hand) ??
					FullHouse(_hand) ??
					Flush(_hand) ??
					Straight(_hand) ??
					ThreeOfAKind(_hand) ??
					TwoPairs(_hand) ??
					OnePair(_hand) ??
					HighCard(_hand);
		}

		private int? ConvertRank(char? rank)
		{
			if (rank == null) return null; // it will probably never reach here
			if (rank.Equals('T')) return 10;
			if (rank.Equals('J')) return 11;
			if (rank.Equals('Q')) return 12;
			if (rank.Equals('K')) return 13;
			if (rank.Equals('A')) return 14;
			return Convert.ToInt32(rank.ToString());
		}

		public string RunGame(string cards)
		{
			try
			{
				// First player is black second is white
				string handBlack = cards.Substring(0, 14);
				string handWhite = cards.Substring(15, 14);

				_handWhite = new Hand(handWhite);
				_handBlack = new Hand(handBlack);

				_whiteScore = GetScore(_handWhite);
				_blackScore = GetScore(_handBlack);
				if (_whiteScore > _blackScore)
					return WhiteWin;
				if (_blackScore > _whiteScore)
					return BlackWin;

				if (_whiteScore == _blackScore)
				{
					if (_whiteScore == Score.OnePair	  || _whiteScore == Score.TwoPair 
					 || _whiteScore == Score.ThreeOfAKind || _whiteScore == Score.FourOfAKind)
					{
						var blackRank = ConvertRank(_handBlack.rank);
						var whiteRank = ConvertRank(_handWhite.rank);

						if (blackRank > whiteRank)
							return BlackWin;
						if (whiteRank > blackRank)
							return BlackWin;
					}
					for (int cardIndex = 4; cardIndex > 0; cardIndex--)
					{
						var blackRank = _handBlack._cards[cardIndex].RankParsing();
						var whiteRank = _handWhite._cards[cardIndex].RankParsing();
						if (blackRank > whiteRank)
							return BlackWin;
						if (blackRank < whiteRank)
							return WhiteWin;
					}
				}
				return Tie;
			} catch (Exception err)
			{
				throw (err);
			}

		}
	}
}
