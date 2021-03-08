﻿namespace Strategy_Pattern
{
    using System;
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can’t fly");
        }
    }
}
