using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Interfaces;
using Duck.Behaviors;
namespace Duck.Classes
{
    public abstract class ParentDuck
    {
        //Declare two reference variables 
        //for the behavior interface types. 
        //All duck subclasses(in the same
        //package) inherit these
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public ParentDuck()
        {
        }
        public abstract void display();
        public void performFly()
        {
            //delegate to the behaviour class
            flyBehavior.Fly();
        }
        public void performQuack()

        {
            //delegate to the behaviour class
            quackBehavior.Quackk();
        }
        public void setFly( IFlyBehavior IFb){
            flyBehavior = IFb;
        }
        public void setQuack(IQuackBehavior IQb)
        {
            quackBehavior = IQb;
        }
        public void swim()
        {
            Console.WriteLine("All ducks float , even decoys!");
        }
    }




    public class MallardDuck : ParentDuck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
    public class PlasticDuck : ParentDuck
    {
        public PlasticDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithoutWings();
        }
        public override void display()
        {
            Console.WriteLine("I am a Plastic Duck");
        }
    }
    public class SingingDuck : ParentDuck
    {
        public SingingDuck()
        {
            quackBehavior = new Sing();
        }
        public override void display()
        {
            Console.WriteLine("I am a Singing Duckkkkk");
        }
    }
}
