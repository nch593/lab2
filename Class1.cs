using System;
namespace MyTaskLibraryProject
{
    public class Class1
    {
        public static int FindMin(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public static int FindMin(int number1, int number2, int number3)
        {
            return Math.Min(Math.Min(number1, number2), number3);
        }

    }
}
