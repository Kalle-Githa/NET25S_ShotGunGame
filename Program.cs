Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("====================================");
Console.WriteLine("   VÄLKOMMEN TILL SPELET SHOTGUN!      ");
Console.ResetColor();
Console.WriteLine("====================================\n");
Console.ResetColor();
PlayerInfo.Instructions();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Tryck på Enter för att fortsätta...");
Console.ReadLine();
Console.ResetColor();
Console.Clear();

// ========== Spelarens val om spel läge ==========

Console.WriteLine(" Välj mellan dessa spellägen:\n");
Console.WriteLine("[1] Mot Datorn [2] Mot Spelare");
string? mode = InputCheck.GameMode();
Console.Clear();

if (mode == "1")
{
    Console.WriteLine("Skriv in ditt namn:");
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("\nSpelare 1 skriv ditt namn:\n");
    Console.ResetColor();
}

string? input1 = Console.ReadLine();
string playerName1 = string.IsNullOrWhiteSpace(input1) ? "Spelare 1" : input1;
Player player1 = new Player(playerName1);

Console.Clear();

// ========== Huvudspelarens val ==========

Player player2;

if (mode == "1")
{
    player2 = new Player("Don AI Boss");
    Console.Clear();

    PlayerInfo.Welcome(player1, player2);
}
else
// ========== Andra spelares val ==========
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSpelare 2 skriv in ditt namn:");
    Console.ResetColor();

    string? input2 = Console.ReadLine();
    string playerName2 = string.IsNullOrWhiteSpace(input2) ? "Spelare 2" : input2;
    player2 = new Player(playerName2);
    Console.Clear();

    PlayerInfo.Welcome(player1, player2);
}

// ========== Huvudspelarens drag ==========

while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"  Vad vill du göra {player1.Name}?");
    Console.ResetColor();

    PlayerInfo.Display(player1, player2);
    InputCheck.Options(player1);

    string? firstPlayerInput = InputCheck.Pick(player1, player2);
    if (firstPlayerInput == null)
        return;

    Console.Clear();

    // ========== Andra Spelarens drag ==========

    string? secondPlayerInput;

    // ===== Don AI Boss inmatning =====

    if (mode == "1")
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nDon AI Boss tänker...");
        Console.ResetColor();
        Thread.Sleep(2500);
        secondPlayerInput = Computer.Move(player1, player2);

        Console.Clear();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n\n\n\n  Vad vill du göra {player2.Name}?");
        Console.ResetColor();
        PlayerInfo.Display(player1, player2);
        InputCheck.Options(player2);

        secondPlayerInput = InputCheck.Pick(player2, player1);
        if (secondPlayerInput == null)
        {
            return;
        }

        Console.Clear();
    }

    // ========== Spelarnas val om att spela igen ==========

    if (!Move.Run(firstPlayerInput, secondPlayerInput, player1, player2))
    {
        Console.WriteLine("\nVill Ni spela igen?\n");
        Console.WriteLine("[1] Ja  [2] Nej");
        string? yesOrNo = Console.ReadLine();

        while (yesOrNo != "1" && yesOrNo != "2")
        {
            Console.Clear();
            PlayerInfo.Warning();
            Console.WriteLine("Fel inmatning! Välj endast:\n[1] Ja  [2] Nej");
            yesOrNo = Console.ReadLine();
        }

        if (yesOrNo == "1")
        {
            Console.Clear();
            PlayerInfo.PrintBox($"   Välkommna åter igen {player1.Name} och {player2.Name}   ");

            player1.ResetBullet();
            player2.ResetBullet();
            Console.WriteLine("");
        }
        else
        {
            Console.Clear();
            PlayerInfo.GameOver();

            break;
        }
    }
}
