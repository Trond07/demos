using Events;

CardDealer dealer = new CardDealer();

if (Ask("Do you want to handle 'Ace' events? "))
    dealer.AcePicked += OnAce;

if (Ask("Do you want to handle 'Picture card' events? "))
    dealer.PicturecardPicked += OnPicturecard;

if (Ask("Do you want to handle 'Diamond' events? "))
    dealer.DiamondPicked += OnDiamond;

Console.WriteLine("Dealing 5 cards...\n");
for (int i = 0; i < 5; i++)
{
    string number, suit;
    dealer.Deal(out number, out suit);
    Console.WriteLine($"You got the {number} of {suit}\n");
}


// -----------------------------------------------------------------------
// Event handler functions
// -----------------------------------------------------------------------

void OnAce(object? source, CardEventArgs e)
{
    Console.WriteLine($"OnAce handler, {e.Number} of {e.Suit}!!!");
}

void OnPicturecard(object? source, CardEventArgs e)
{
    Console.WriteLine($"OnPicturecard handler, {e.Number} of {e.Suit}!!!");
}

void OnDiamond(object? source, CardEventArgs e)
{
    Console.WriteLine($"OnDiamond handler, {e.Number} of {e.Suit}!!!");
}


// -----------------------------------------------------------------------
// Helper function
// -----------------------------------------------------------------------

bool Ask(string question)
{
    Console.Write(question);
    string? input = Console.ReadLine()?.ToUpper();
    return input != null && input[0] == 'Y';
}