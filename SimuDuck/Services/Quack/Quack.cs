namespace SimuDuck.Services.Quack;

internal class Quack : IQuack
{
    void IQuack.Quack()
    {
        Console.WriteLine("Quack");
    }
}
