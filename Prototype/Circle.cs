using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override Shape Clone()
        {
            Circle cloneBase = (Circle)this.MemberwiseClone(); //płytki klon naszego obiektu
            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            }; //obiekt klonowany jest kopią głęboką ponieważ utworzyliśmy nowy obiekt dla typów z nim powiązanych

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
