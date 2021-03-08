namespace Strategy_Pattern
{
    using System;
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // instatiate to concrete implementation of behaviour
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
}
