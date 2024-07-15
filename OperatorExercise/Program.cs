using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Thsi area of a circle with a radius of (radius) is {Math.Round(AreaOfCircle(radius), 2)}");
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = 17 + 4;
            int subtraction = 17 - 4;
            int mult = 17 + 4;

            int quotient = 17 / 4;
            int remainder = 17 % 4;


            //Console.WriteLine($@"{17}/{4} is {quotient} remainder {remainder}.");
            
            //PrintAreaOfCircle();
            
            // var is implicit type inferrence (more on this later)
            var i = 4;
            var j = 7;
            var k = ++j * j++;

             Console.WriteLine(k); // ouputs ?



        }
    }
}


