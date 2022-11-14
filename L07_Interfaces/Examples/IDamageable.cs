namespace L07_Interfaces.Examples;

public interface IDamageable
{
    void Damage();
}

public class Monster : IDamageable
{
    private int hp;
    
    public void Damage()
    {
        hp -= 100;
    }
}

public class Tower : IDamageable
{
    private int hp;
    public void Damage()
    {
        hp -= 1;
    }
}