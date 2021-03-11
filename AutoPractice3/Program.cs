using AutoPractice3.Helpers;
using AutoPractice3.Models;
using System;

namespace AutoPractice3
{
    class Program
    {
        public static int Sum(params int[] elems) {
            int sum = 0;
            foreach (int elem in elems) {
                sum += elem;
            }
            return sum;
        }

        static void Main()
        {
            Car car = new Car("Volvo", 5, 4);
            //car.Model = null;
            //PrintCarInfo print = new PrintCarInfo();
            //print.Print(car);

            //Console.WriteLine("sum is {0}", Sum(1, 2) );
            //Console.WriteLine("sum is {0}", Sum(1, 2, 4));
            //Console.WriteLine("sum is {0}", Sum(1, 2, 6, 4));
            //Console.WriteLine("sum is {0}", Sum(1, 2, 3, 5, 6, 6));
            //Console.WriteLine("sum is {0}", Sum(1, 2, 4, 5, 6, 7, 8, 9));
            int[] ints = { 4, 6, -78, 34, 5} ;
            Console.WriteLine("All elements is positive: {0}", Array.TrueForAll(ints, el => el>0));
        }
    }
}
