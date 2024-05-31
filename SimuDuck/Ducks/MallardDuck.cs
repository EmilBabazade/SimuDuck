using SimuDuck.Services.Fly;
using SimuDuck.Services.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck.Ducks;
internal class MallardDuck : Duck
{
    public MallardDuck()
    {
        _quack = new Quack();
        _fly = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("I am a real Mallard duck");
    }
}
