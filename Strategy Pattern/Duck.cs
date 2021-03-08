namespace Strategy_Pattern
{
    using System;

    public abstract class Duck
    {
        // represents the behaviour that is changing 
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;
        public Duck()
        {
        }
        public abstract void display();

        // delegates the behaviour
        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }

        //allow the behaviour type to be changed at runtime
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

}
