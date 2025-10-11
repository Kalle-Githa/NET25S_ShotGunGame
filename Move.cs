public class Move
{
    public static bool Run(
        string firstPlayerInput,
        string secondPlayerInput,
        Player player1,
        Player player2
    )
    {
        if (firstPlayerInput == "1" && secondPlayerInput == "1")
        {
            if (player1.Bullet > 0 && player2.Bullet > 0)
            {
                player1.ShotsBullet();
                player2.ShotsBullet();

                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox($"- Både {player1.Name} och {player2.Name} skjuter PAANG!! -");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nMatchen är OAVGJORD! ");
                Console.ResetColor();

                return false;
            }
            else if (player1.Bullet > 0 && player2.Bullet == 0)
            {
                player1.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player2.Name} försöker skjuta utan skott! {player1.Name} skjuter PAANG!!! -"
                );
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{player1.Name} är vinnaren GRATTIS!!!");
                Console.ResetColor();

                return false;
            }
            else if (player1.Bullet == 0 && player2.Bullet > 0)
            {
                player2.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player1.Name} försöker skjuta utan skott och {player2.Name} skjuter PAANG!!! -"
                );
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{player2.Name} är vinnaren GRATTIS!!!");
                Console.ResetColor();

                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===============================================");
                Console.WriteLine("- HAHAHA!!! Båda försökte skjuta utan skott! -");
                Console.WriteLine("===============================================\n");
                Console.ResetColor();
            }
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "1" && secondPlayerInput == "2")
        {
            if (player1.Bullet > 0)
            {
                player1.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- {player1.Name} skjuter PAANG!! och {player2.Name} laddar -"
                );
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.Name} är vinnaren GRATTIS!!!");
                Console.ResetColor();

                return false; // detta går för att denna objekt returnerar en bool
            }
            else
            {
                player2.AddBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player1.Name} försökte skjuta utan skott och {player2.Name} laddar -"
                );
                Console.ResetColor();
            }
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "1" && secondPlayerInput == "3")
        {
            if (player1.Bullet > 0)
            {
                player1.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- {player1.Name} skjuter PAANG!! och {player2.Name} blockar -"
                );
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;

                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player1.Name} försökte skjuta utan skott och {player2.Name} blockar -"
                );
                Console.ResetColor();
            }
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "2" && secondPlayerInput == "1")
        {
            if (player2.Bullet > 0)
            {
                player2.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- {player1.Name} laddar och {player2.Name} skjuter PAANG!! -"
                );
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{player2.Name} är vinnaren GRATTIS!!!");
                Console.ResetColor();

                return false;
            }
            else
            {
                player1.AddBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player2.Name} försöker skjuta utan skott och {player1.Name} laddar -"
                );
                Console.ResetColor();
            }
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "2" && secondPlayerInput == "2")
        {
            player1.AddBullet();
            player2.AddBullet();
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- Både {player1.Name} och {player2.Name} laddar -");
            Console.ResetColor();
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "2" && secondPlayerInput == "3")
        {
            player1.AddBullet();
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- {player1.Name} laddar och {player2.Name} blockar -");
            Console.ResetColor();
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "3" && secondPlayerInput == "1")
        {
            if (player2.Bullet > 0)
            {
                player2.ShotsBullet();
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- {player1.Name} blockar och {player2.Name} skjuter PAANG!! -"
                );
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                PlayerInfo.PrintBox(
                    $"- CLICK CLICK!! {player2.Name} försöker skjuta utan skott {player1.Name} blockar -"
                );
                Console.ResetColor();
            }
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "3" && secondPlayerInput == "2")
        {
            player2.AddBullet();
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- {player1.Name} blockar och {player2.Name} laddar-");
            Console.ResetColor();
        }
        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "3" && secondPlayerInput == "3")
        {
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- Både {player1.Name} och {player2.Name} blockar -");
            Console.ResetColor();
        }

        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        if (firstPlayerInput == "4" && secondPlayerInput == "4")
        {
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox("CLICK CLACK PAAW!!! Det blev OAVGJORD Shotgun STYLE!");
            Console.ResetColor();

            return false;
        }
        else if (firstPlayerInput == "4")
        {
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- CLICK CLACK BOOM!!! {player1.Name} vann Shotgun STYLE! -");
            Console.ResetColor();

            return false;
        }
        else if (secondPlayerInput == "4")
        {
            Console.ForegroundColor = ConsoleColor.White;
            PlayerInfo.PrintBox($"- CLICK CLACK BOOM!!! {player2.Name} vann Shotgun STYLE! -");
            Console.ResetColor();

            return false;
        }

        // _____________________________________________________________________________________________________________
        // _____________________________________________________________________________________________________________

        return true; // spelet forsätter  måste vara här för denna metod är en bool typ
    }
}
