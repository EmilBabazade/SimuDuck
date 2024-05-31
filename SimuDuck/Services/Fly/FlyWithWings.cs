using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck.Services.Fly;
internal class FlyWithWings : IFly
{
    public void Fly()
    {
        Console.WriteLine("I am flying!");
    }
}
