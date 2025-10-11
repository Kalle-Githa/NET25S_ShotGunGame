public class Computer
{
    private static Random random = new Random();

    public static string Move(Player one, Player aiBoss)
    {
        // random.Next(1, 4) blir antingen 1,2,3
        string rand = random.Next(1, 4).ToString();

        if (aiBoss.Bullet >= 3)
        {
            rand = "4";
        }
        else if (aiBoss.Bullet == 0 && one.Bullet == 0)
        {
            rand = "2";
        }
        else if (aiBoss.Bullet == 0)
        {
            rand = random.Next(2, 4).ToString();
        }
        else if (one.Bullet == 0 && aiBoss.Bullet == 2)
        {
            rand = "2";
        }
        else if (one.Bullet == 0)
        {
            rand = random.Next(1, 3).ToString();
        }

        return rand;
    }
}
