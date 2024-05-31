namespace SimuDuck.Services.Fly;

internal class FlyNoWay : IFly
{
    public void Fly()
    {
        Console.WriteLine("I cant fly");
    }
}