using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ScanFacade //zadaniem tej klasy jest agregacja 4 obiektów, a następnie odpowiednia ich integracja
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();

        public void Scan(string githubUrl) //metoda scan ukrywa szczegóły implementacji korzystając z tych 4 obiektów
        {
            Console.WriteLine($"Scanning {githubUrl}");
            var qualityScanErrors = qualityScanner.QualityScan(githubUrl);
            var securityScanErrors = securityScanner.SecurityScan(githubUrl);
            var dependencyScanErrors = dependencyScanner.DependecyScan(githubUrl);

            //tworzenie raportu dla kodu źródłowego
            Console.WriteLine("Scan report");
            reportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
        }
    }
}
