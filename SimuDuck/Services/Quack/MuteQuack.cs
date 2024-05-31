namespace SimuDuck.Services.Quack;

internal class MuteQuack : IQuack
{
    public void Quack()
    {
        Console.WriteLine("...");
    }
}
