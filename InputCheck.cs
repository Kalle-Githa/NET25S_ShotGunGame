public class InputCheck
{
    public static string GameMode()
    {
        string? mode = Console.ReadLine();
        Console.Clear();

        while (mode != "1" && mode != "2")
        {
            PlayerInfo.Warning();
            Console.WriteLine("Fel inmatning! Välj endast mellan:\n[1] Mot Datorn [2] Mot Spelare");

            mode = Console.ReadLine();
            Console.Clear();
        }

        return mode!;
    }

    public static string? Pick(Player activeP, Player passiveP)
    {
        string? pick = MaskInput.MaskPassword();
        Console.Clear();

        if (pick == "0")
        {
            PlayerInfo.GameOver();
            return null;
        }

        while (
            pick != "1"
            && pick != "2"
            && pick != "3"
            && !(pick == "4" && activeP.Bullet >= 3)
            && pick != "0"
        )
        {
            PlayerInfo.Warning();
            PlayerInfo.Display(activeP, passiveP);

            Console.WriteLine(
                "Fel inmatning! Välj endast mellan:\n[1] Skjuta [2] Ladda [3] Blocka"
                    + (activeP.Bullet >= 3 ? " [4] Shotgun" : "")
                    + " [0] Avsluta"
            );

            pick = MaskInput.MaskPassword();
            Console.Clear();

            if (pick == "0")
            {
                PlayerInfo.GameOver();
                return null;
            }
        }

        return pick!;
    }

    public static void Options(Player player)
    {
        if (player.Bullet >= 3)
        {
            Console.WriteLine("[1] Skjuta  [2] Ladda  [3] Blocka  [4] Shotgun  [0] Avsluta");
        }
        else
        {
            Console.WriteLine("[1] Skjuta  [2] Ladda  [3] Blocka  [0] Avsluta");
        }
    }
}
