using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Interfaces;

namespace Duck.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I’m flying!!");
        }
    }
    public class FlyWithoutWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying Without Wings");
        }
    }

    public class Quack : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Quack");
        }
    }
    public class MuteQuack : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Silenceeee");
        }

    }
    public class Squeak : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Squeak");
        }
    }
    public class Sing : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("I CAN Singggggggggggggg");
        }
    }

}
