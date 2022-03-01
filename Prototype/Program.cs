using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle()
            {
                Radius = 10,
                X = 1,
                Y = 2,
                Border = new Border()
                {
                    Color = "Blue",
                    Size = "2px"
                }
            };

            Circle c2 = (Circle)c1.Clone();

            bool referenceEquals = ReferenceEquals(c1, c2);
            Console.WriteLine($"ReferenceEquals: {referenceEquals}");

            bool borderReferenceEquals = ReferenceEquals(c1.Border, c2.Border);
            Console.WriteLine($"borderReferenceEquals: {borderReferenceEquals}");

            Console.WriteLine();

        }
    }
}
