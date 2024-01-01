using War_Game;

public class Program
{
    private static void Main(string[] args)
    {
        Warrior alice = new Warrior("Alice" , 1000 , 40 , 60);
        Warrior bob = new Warrior("Bob", 1000, 30, 20);

        Battle battle = new Battle(alice, bob);
        battle.StartGame();

    }
}