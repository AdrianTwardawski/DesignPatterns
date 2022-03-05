using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var pdfGenerator = new PdfGenerator();

            Console.WriteLine("** PDF **");
            pdfGenerator.GenerateReport(); //mamy dostęp tylko do metody szablonowej

            Console.WriteLine("** CSV **");
            var csvGenerator = new CsvGenerator();

            csvGenerator.GenerateReport();

        }
    }
}
