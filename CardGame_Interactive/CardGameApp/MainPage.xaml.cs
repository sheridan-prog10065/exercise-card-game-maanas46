namespace CardGameApp;

public partial class MainPage : ContentPage
{
    private CardGame _cardGame; //HAS-A relationship

    public MainPage()
    {
        InitializeComponent();

        //create the card game
        _cardGame = new CardGame();
    }

	private void OnDealCards(object sender, EventArgs e)
	{
        //Ask the game to deal the cards
        _cardGame.DealCards();

        //Display the player card
        Card playerCard = _cardGame.PlayerCard;
        ShowCard(_imgPlayerCard, playerCard);

        //Display the house card
        Card houseCard = _cardGame.HouseCard;
        ShowCard(_imgHouseCard, houseCard);
	}

	private void ShowCard(Image imageControl, Card card)
	{
        //Determine the name of the card based on its suit and value
        char suitId = card.SuitName.ToLower()[0];
        string fileName = $"{suitId}{card.Value.ToString("00")}.png";

        //Show the card
        imageControl.Source = ImageSource.FromFile(fileName);
	}
}