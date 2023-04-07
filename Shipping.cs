using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    namespace StrategyPatternExample
    {
        // Strategy interface
        public interface IShippingStrategy
        {
            double CalculateShippingCost(double weight, double distance);
        }

        // Concrete strategy classes
        public class StandardShippingStrategy : IShippingStrategy
        {
            public double CalculateShippingCost(double weight, double distance)
            {
                return weight * 0.5 + distance * 0.1;
            }
        }

        public class ExpeditedShippingStrategy : IShippingStrategy
        {
            public double CalculateShippingCost(double weight, double distance)
            {
                return weight * 1.0 + distance * 0.5;
            }
        }

        // Context class
        public class Order
        {
            public double Weight { get; set; }
            public double Distance { get; set; }
            public IShippingStrategy ShippingStrategy { get; set; }

            public Order(double weight, double distance)
            {
                Weight = weight;
                Distance = distance;
            }

            public double CalculateShippingCost()
            {
                if (ShippingStrategy == null)
                {
                    throw new InvalidOperationException("Shipping strategy has not been set");
                }

                return ShippingStrategy.CalculateShippingCost(Weight, Distance);
            }
        }

        // Client code
        public class Program
        {
            static void Main(string[] args)
            {
                Order order = new Order(10.0, 100.0);

                // Set the shipping strategy to standard
                order.ShippingStrategy = new StandardShippingStrategy();
                Console.WriteLine("Standard shipping cost: " + order.CalculateShippingCost());

                // Set the shipping strategy to expedited
                order.ShippingStrategy = new ExpeditedShippingStrategy();
                Console.WriteLine("Expedited shipping cost: " + order.CalculateShippingCost());

                Console.ReadLine();
            }
        }

  

interface IOperation
        {
            int Calculate(int a, int b);
        }

        class Add : IOperation
        {
            public int Calculate(int a, int b)
            {
                return a + b;
            }
        }

        class Subtract : IOperation
        {
            public int Calculate(int a, int b)
            {
                return a - b;
            }
        }

        class Calculator
        {
            private IOperation operation;
            public Calculator(IOperation operation)
            {
                this.operation = operation;
            }

            public int PerformOperation(int a, int b)
            {
                return operation.Calculate(a, b);
            }
        }

        class Programm
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator(new Add());
                int result = calculator.PerformOperation(5, 3);
                Console.WriteLine($"Result: {result}");

                calculator = new Calculator(new Subtract());
                result = calculator.PerformOperation(5, 3);
                Console.WriteLine($"Result: {result}");
            }
        }

    }

}
