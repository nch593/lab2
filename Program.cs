using System;
using MyTaskLibraryProject;

namespace TestMyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;

            Console.Write("Please enter number 1\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter number 2\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter number 3\n");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Minimum of 2 values: ", MyTaskLibraryProject.Class1.FindMin(number1, number2));
            Console.WriteLine("The Minimum of 3 values: ", MyTaskLibraryProject.Class1.FindMin(number1, number2, number3));

        }
    }
}
