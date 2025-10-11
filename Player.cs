public class Player
{
    public string Name;
    public int Bullet { get; private set; }

    public Player(string name)
    {
        Name = name;
        Bullet = 0;
    }

    public void AddBullet()
    {
        Bullet++;
    }

    public void ShotsBullet()
    {
        if (Bullet > 0)
        {
            Bullet--;
        }
    }

    public void ResetBullet()
    {
        Bullet = 0;
    }
}
