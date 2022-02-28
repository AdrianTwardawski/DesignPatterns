using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class HpLaserJet : IPrinter, IScanner, IFaxer
    {
        public void Fax(string content)
        {
            Console.WriteLine("Hp laser jet print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Hp laser jet print color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Hp laser jet print grey");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Hp laser jet print scan");
        }
    }
}
