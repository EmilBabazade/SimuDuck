using SimuDuck.Services.Fly;
using SimuDuck.Services.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck.Ducks;
internal abstract class Duck
{
    protected IFly _fly;
    protected IQuack _quack;

    public virtual void Display() { }

    public void Fly()
    {
        _fly.Fly();
    }

    public void Quack()
    {
        _quack.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, fake ones too!");
    }

    public void SetFly(IFly fly) => _fly = fly;
    public void SetQuack(IQuack quack) => _quack = quack;
}
