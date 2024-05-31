using SimuDuck.Services.Fly;
using SimuDuck.Services.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck.Ducks;
internal class ModelDuck : Duck
{
    public ModelDuck()
    {
        _fly = new FlyNoWay();
        _quack = new Quack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model duck!");
    }
}
