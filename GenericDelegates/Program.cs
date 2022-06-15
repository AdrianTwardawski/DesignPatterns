using System;
using System.Collections.Generic;

namespace GenericDelegates
{
    class Program
    {
        public delegate void Display(string value);
        public delegate bool GenericPredicate<T>(T value);
       
        static void Main(string[] args)
        {
            //void WriteWithComma(string value)
            //{
            //    Console.WriteLine(value + ", ");
            //}

            //Display display = WriteWithComma;

            Display display = (string value) => Console.Write(value + ", ");

            //display("test");

            var numbers = new int[] { 10, 30, 50 };
            //DisplayNumbers(numbers, display);

            //var count = Count(numbers, 15);
            var count = Count(numbers, (int value) => value > 15);
            Console.WriteLine(count);

            var strings = new string[] { "Generic", "Delegate", "test" };
            var countStrings = Count(strings, value => value.Length > 4);
            Console.WriteLine(countStrings);

        }

        static void DisplayNumbers(IEnumerable<int> numbers, Display display)
        {
            foreach(int number in numbers)
            {
                display(number.ToString());
            }
        }

        // static int Count<T>(IEnumerable<T> elements, Predicate<T> predicate) // wbudowana delegata przez Microsoft
        static int Count<T>(IEnumerable<T> elements, GenericPredicate<T> predicate)
        {
            int count = 0;
            foreach (T element in elements)
            {
                if (predicate(element))
                {
                    count++;
                }
            }
            return count;
        }

        //static int Count(IEnumerable<int> numbers, int greaterThanValue)
        //{
        //    int count = 0;
        //    foreach(int number in numbers)
        //    {
        //        if(number > greaterThanValue)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
