using SimuDuck.Ducks;
using SimuDuck.Services.Fly;
using SimuDuck.Services.Quack;

var mallard = new MallardDuck();
mallard.Display();
mallard.Quack();
mallard.Fly();

var model = new ModelDuck();
model.Display();
model.Quack();
model.Fly();
model.SetQuack(new Squeak());
model.SetFly(new FlyWithRocket());
model.Quack();
model.Fly();