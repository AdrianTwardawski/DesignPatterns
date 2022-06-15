using System;

namespace RefOut
{
    class Program
    {

        static bool IsDIvisible(int value, int fator, out int reminder)
        {
            reminder = value % factor;

            return reminder == 0;
        }
        static void Double(ref int value)
        {
            value = value * 2;
            Console.WriteLine($"Doubled value: {value}");
        }

        static void Main(string[] args)
        {
            int someValue = 5;
            Double(ref someValue);
            Console.WriteLine($"some value: {someValue}");

            int value = 5;
            int factor = 2;
            int reminder;
            if(IsDIvisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} is divisible by {factor}");
            }
            else
            {
                Console.WriteLine($"{value} is not divisible by {factor}");
            }
        }
    }
}
