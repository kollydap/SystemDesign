using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Interfaces;
using Duck.Behaviors;
using Duck.Classes;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentDuck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            SingingDuck singingDuck = new SingingDuck();
            singingDuck.performQuack();
            Console.ReadLine();
        }
    }
    
}


