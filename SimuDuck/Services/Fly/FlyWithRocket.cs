using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck.Services.Fly;
internal class FlyWithRocket : IFly
{
    public void Fly()
    {
        Console.WriteLine("Flying with rockets!");
    }
}
