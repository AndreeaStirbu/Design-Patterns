using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I’m fl ying with a rocket!");
        }
    }
}
