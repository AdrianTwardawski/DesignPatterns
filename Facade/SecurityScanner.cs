using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SecurityScanner //klasa, której zadaniem jest przeskanowanie repozytorium pod względem bezpieczeństwa
    {
        public IEnumerable<string> SecurityScan(string githubUrl)
        {
            Console.WriteLine("Security scan");

            return new List<string>() { "securrity error1" }; // zwrócenie rezultatów w postaci kolekcji stringów
        }
    }
}
