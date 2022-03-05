using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ReportGenerator //klasa, której zadaniem jest agregacja rezultatów z trzech kroków skanowania oraz prezentacja wyników skanowania
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors, 
            IEnumerable<string> dependencyScanErrors)
        {
            Console.WriteLine("Quality Scan Errors:");
            Console.WriteLine(string.Join(", ", qualityScanErrors));

            Console.WriteLine("Security Scan Errors:");
            Console.WriteLine(string.Join(", ", securityScanErrors));

            Console.WriteLine("Dependency Scan Errors:");
            Console.WriteLine(string.Join(", ", dependencyScanErrors));
        }
    }
}
