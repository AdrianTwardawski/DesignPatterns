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
            return (Circle)this.MemberwiseClone();
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
