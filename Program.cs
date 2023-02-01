using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocity = 10; // m/s
            double angle = 30; // degrees
            double airResistanceCoefficient = 0.1; // unitless

            double timeInAir = 0; // s
            double xPosition = 0; // m
            double yPosition = 0; // m

            while (yPosition >= 0)
            {
                double xVelocity = velocity * Math.Cos(angle);
                double yVelocity = velocity * Math.Sin(angle);

                xPosition += xVelocity * timeInAir;

                yPosition += yVelocity * timeInAir - 0.5 * airResistanceCoefficient * Math.Pow(velocity, 2) * timeInAir;

                timeInAir += 1;  // Increment the time by 1 second each iteration of the loop. 
            }

            Console.WriteLine("The range of the ball is " + xPosition + " meters.");
            Console.ReadKey();
        }
    }
}
