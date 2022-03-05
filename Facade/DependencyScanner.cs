using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DependencyScanner //klasa, której zadaniem jest przeskanowanie repozytorium pod kątem sprawdzenia zależności projektu
    {
        public IEnumerable<string> DependecyScan(string githubUrl)
        {
            Console.WriteLine("Dependency Scan");

            return new List<string>() { "DependencyScan Error1" }; // zwrócenie rezultatów w postaci kolekcji stringów
        }
    }
}
