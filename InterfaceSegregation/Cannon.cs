using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Cannon : IPrinter, IFaxer
    {
        public void Fax(string content)
        {
            Console.WriteLine("Cannon print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Cannon print color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Cannon print grey");
        }
      
    }
}
