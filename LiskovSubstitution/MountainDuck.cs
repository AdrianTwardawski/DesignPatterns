using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class MountainDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Mountain duck flies");
        }

        public override void Qwack()
        {
            Console.WriteLine("Mountain duck Qwack");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountain duck Swim");
        }
    }
}
