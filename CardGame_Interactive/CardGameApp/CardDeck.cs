
namespace CardGameApp;

public class CardDeck
{
	#region Field Variables
	
	private List<Card> _cardList;

	private static Random s_randomizer;

	private const byte MAX_SUIT_COUNT = 4;
	private const byte MAX_CARD_VALUE = 13;
	
	#endregion
	
	#region Constructors

	/// <summary>
	/// Static constructor is used to initialize all static variables,
	/// in this case the randomizer used to shuffle cards
	/// </summary>
	static CardDeck()
	{
		//Create the randomizer object
		s_randomizer = new Random();
	}

	/// <summary>
	/// Instance constructor used to instantiate field variables
	/// </summary>
	public CardDeck()
	{
		_cardList = new List<Card>(MAX_SUIT_COUNT* MAX_CARD_VALUE);
		
		//fill the deck of cards
		CreateCards();
	}
	
	#endregion
	
	#region Properties
	public int CardCount
	{
		get { return _cardList.Count; }
	}

	#endregion
	
	#region Methods
	/// <summary>
	/// Create the all the cards for each suit
	/// </summary>
	/// <exception cref="NotImplementedException"></exception>
	private void CreateCards()
	{
		//repeat for each of the four suites
		for(byte iSuit = 1; iSuit <= MAX_SUIT_COUNT; iSuit++) 
		{
			CardSuit suit = (CardSuit)iSuit;

			//repeat for each value in a suit
			for(byte value = 1; value <= MAX_CARD_VALUE; value++)
			{
				//create a card with the current value and suit
				Card card = new Card(value, suit);

				//add the card to the list
				_cardList.Add(card);
			}
		}
	}

	/// <summary>
	/// Shuffle the card deck using a Fisher-Yates Shuffle algorithm
	/// </summary>
	public void ShuffleCards()
	{
		//Repeat randomizing the location of each card in the deck
		for (int iCard = 0; iCard < _cardList.Count; iCard++)
		{
			//Choose a random card in the deck
			int randPos = s_randomizer.Next(iCard, _cardList.Count);
			
			//Swap the random card with the card in the current location
			Card randCard = _cardList[randPos];
			Card crtCard = _cardList[iCard];
			_cardList[iCard] = randCard;
			_cardList[randPos] = crtCard;
		}
	}

	#endregion
}

