using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class CityDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("City duck flies");
        }

        public override void Qwack()
        {
            Console.WriteLine("City duck Qwack");
        }

        public override void Swim()
        {
            Console.WriteLine("City duck Swim");
        }
    }
}
