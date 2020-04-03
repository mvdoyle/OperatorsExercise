﻿using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //Allow user to input the radius
            Console.WriteLine("What is the radius of your circle?");

            double realRadius;
            var radius = double.TryParse(Console.ReadLine(), out realRadius);

            //Calculate area of the circle
            var areaOfCircle = CalculateArea(realRadius);

            Console.WriteLine($"The area of a circle with radius of {realRadius} is {areaOfCircle}");

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
