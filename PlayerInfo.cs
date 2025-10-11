public class PlayerInfo
{
    public static void Display(Player p1, Player p2)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine(" Spelare".PadRight(20) + "Skott");
        Console.WriteLine("---------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($" {p1.Name.PadRight(20)}{p1.Bullet}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($" {p2.Name.PadRight(20)}{p2.Bullet}\n");
        Console.ResetColor();
    }

    public static void Welcome(Player p1, Player p2)
    {
        string welcomeText = $"  Välkommen {p1.Name} och {p2.Name}  ";
        string border = new string('=', welcomeText.Length);
        Console.WriteLine(border);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(welcomeText);
        Console.ResetColor();
        Console.WriteLine(border);
        Console.WriteLine();
    }

    public static void PrintBox(string text)
    {
        string border = new string('=', text.Length);
        Console.WriteLine(border);
        Console.WriteLine(text);
        Console.WriteLine(border + "\n");
    }

    public static void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n====================================");
        Console.WriteLine("       GAME OVER YEAAAA!!!!");
        Console.WriteLine("====================================\n");
        Console.ResetColor();
        Thread.Sleep(2000);
    }

    public static void Instructions()
    {
        Console.WriteLine("Instruktioner:");
        Console.WriteLine(
            "[1] Skjuta: Används för att skjuta på motståndaren. Kräver minst 1 skott."
        );
        Console.WriteLine("[2] Ladda: Används för att ladda på skott.");
        Console.WriteLine("[3] Blocka: Används för att blockera skott.");
        Console.WriteLine("[4] Shotgun: Blir tillgängligt när man minst har 3 skott.");
        Console.WriteLine("[0] Avsluta: Används för att avsluta spelet.\n");
        Console.WriteLine(
            "NOTERA: Shotgun slår ut alla andra val förutom Shotgun mot Shotgun. Då blir det oavgjort!\n"
        );
    }

    public static void Warning()
    {
        Console.WriteLine("\n====================================");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("             -VARNING-");
        Console.ResetColor();
        Console.WriteLine("====================================\n");
    }
}
