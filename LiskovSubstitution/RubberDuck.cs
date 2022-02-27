using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }

        public override void Qwack()
        {
            Console.WriteLine("Rubber duck Qwack");
        }

        public override void Swim()
        {
            Console.WriteLine("Rubber duck Swim");
        }
    }
}
