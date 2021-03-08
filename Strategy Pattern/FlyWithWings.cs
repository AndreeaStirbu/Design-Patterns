namespace Strategy_Pattern
{
    using System;
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I’m flying!!");
        }
    }
}
