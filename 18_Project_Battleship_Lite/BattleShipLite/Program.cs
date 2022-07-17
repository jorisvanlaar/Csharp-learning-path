using BattleshipLiteLibrary;            
using BattleshipLiteLibrary.Models;


WelcomeMessage();

PlayerInfoModel activePlayer = CreatePlayer("Player 1");
PlayerInfoModel opponent = CreatePlayer("Player 2");
PlayerInfoModel winner = null;

do
{
    DisplayShotGrid(activePlayer);
    RecordPlayerShot(activePlayer, opponent);
    
    bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

    if (doesGameContinue == true)
    {
        (activePlayer, opponent) = (opponent, activePlayer);    
    }
    else
    {
        winner = activePlayer;
    }
} while (winner == null);

IdentifyWinner(winner);


static void WelcomeMessage()
{
    Console.WriteLine("Welcome to Battleship Lite");
    Console.WriteLine("Created by Joris van Laar");
    Console.WriteLine();
}

static PlayerInfoModel CreatePlayer(string playerTitle)
{
    PlayerInfoModel output = new();

    Console.WriteLine($"Player information for {playerTitle}");

    output.UserName = AskForUserName();

    GameLogic.InitializeShotGrid(output);                           
    
    PlaceShips(output);

    Console.Clear();

    return output;
}

static string AskForUserName()
{
    Console.Write("What is your name: ");
    return Console.ReadLine();
}

static void PlaceShips(PlayerInfoModel model)
{
    do
    {
        Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: "); 
        string location = Console.ReadLine();

        bool isValidLocation = false;
        
        try
        {
            isValidLocation = GameLogic.PlaceShip(model, location);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (isValidLocation == false)
        {
            Console.WriteLine("That was not a valid location. Please try again");
        }
    } while (model.ShipLocations.Count < 5);
}

static void DisplayShotGrid(PlayerInfoModel activePlayer)
{
    Console.Clear();
    Console.WriteLine($"ShotGrid of {activePlayer.UserName}");
    Console.WriteLine("--------------------");
    string currentRow = activePlayer.ShotGrid[0].SpotLetter;
    
    foreach (var gridSpot in activePlayer.ShotGrid)
    {
        if (gridSpot.SpotLetter != currentRow)
        {
            Console.WriteLine();
            currentRow = gridSpot.SpotLetter;
        }
        
        if (gridSpot.Status == GridSpotStatus.Empty)
        {
            Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} "); 
        }
        else if (gridSpot.Status == GridSpotStatus.Hit)
        {
            Console.Write(" X  ");
        }
        else if(gridSpot.Status == GridSpotStatus.Miss)
        {
            Console.Write(" O  ");
        }
        else
        {
            Console.Write(" ?  ");
        }
    }

    Console.WriteLine();
    Console.WriteLine();
}

static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
{
    bool isValidShot = false;
    string shotLetter = "";
    int shotNumber = 0;

    do
    {
        string shot = AskForShot(activePlayer);

        try
        {
            (shotLetter, shotNumber) = GameLogic.SplitLocationIntoLetterAndNumber(shot);    

            isValidShot = GameLogic.ValidateShot(activePlayer, shotLetter, shotNumber);     
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            isValidShot = false;
        }

        if (isValidShot == false)
        {
            Console.WriteLine("Invalid shot location. Please try again.");
        }
    } while (isValidShot == false);

    bool isAHit = GameLogic.IdentifyShotResult(opponent, shotLetter, shotNumber);   

    GameLogic.MarkShotResult(activePlayer, shotLetter, shotNumber, isAHit);         

    DisplayShotResults(shotLetter, shotNumber, isAHit);                             

    Console.Write("Press ENTER to continue");
    Console.ReadLine();
}

static string AskForShot(PlayerInfoModel player)
{
    Console.Write($"{player.UserName}, please enter your shot selection: ");
    return Console.ReadLine();
}

static void DisplayShotResults(string shotLetter, int shotNumber, bool isAHit)
{
    if (isAHit)
    {
        Console.WriteLine($"{shotLetter}{shotNumber} is a HIT!");
    }
    else
    {
        Console.WriteLine($"{shotLetter}{shotNumber} is a MISS.");
    }

    Console.WriteLine();
}

static void IdentifyWinner(PlayerInfoModel winner)
{
    Console.WriteLine();
    Console.WriteLine("WE HAVE A WINNER!");
    Console.WriteLine($"Congratulations to {winner.UserName} for winning!");
    Console.WriteLine($"{winner.UserName} took {GameLogic.GetShotCount(winner)} shots.");
}
