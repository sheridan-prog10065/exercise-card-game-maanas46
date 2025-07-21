
using System.Diagnostics;

namespace CardGameApp;

public class CardGame
{
	private CardDeck _cardDeck;
	private GameScore _score;
	private Card _playerCard;
	private Card _houseCard;

	public CardGame()
	{
		_cardDeck = new CardDeck();
		_score = new GameScore();
		_playerCard = null;
		_houseCard = null;
		
		//Shuffle the card deck
		_cardDeck.ShuffleCards();
	}
	
	public GameScore Score
	{
		get { return _score; }
	}

	public Card PlayerCard
	{
		get { return _playerCard; }
	}

	public Card HouseCard
	{
		get { return _houseCard; }
	}

	public bool PlayerWins
	{
		get
		{
			//TODO: implmeent PlayerWins 
			return false;
		}
	}

	public bool HouseWins
	{
		get
		{
			//TODO: Implement HouseWins
			return false;
		}
	}

	public bool IsOver
	{
		get
		{
			//TODO: implment this
			return false;
		}
	}

	internal void DealCards()
	{
		//Ask the deck for two random cards
		bool cardsDealt = _cardDeck.GetPairOfCards(out _playerCard, out _houseCard);
		Debug.Assert(cardsDealt, "Cards could not be dealth. The game may be over and the card deck empty.");

	}
}
