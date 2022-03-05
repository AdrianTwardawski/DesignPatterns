using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class QualityScanner //klasa, której zadaniem jest przeskanowanie repozytorium githuba i zwrócenie rezultatów w postaci kolekcji stringów
    {
        public IEnumerable<string> QualityScan(string githubUrl)
        {
            Console.WriteLine("Quality scan");

            return new List<string>() { "Error1", "Error2" }; //zwrócone rezultaty, które oznaczają rzeczy do poprawy po skanowaniu
        }
    }
}
