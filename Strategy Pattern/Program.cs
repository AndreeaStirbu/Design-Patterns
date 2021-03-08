using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
            model.setFlyBehavior(new FlyWithWings());
            model.performFly();

        }
    }
}
