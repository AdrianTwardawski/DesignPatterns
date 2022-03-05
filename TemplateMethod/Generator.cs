using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Generator //abstrakcyjna klasa bazowa
    {
        public void GenerateReport() //metoda szablonowa, która jest wykonywana dla każdego z trzech konkretnych algorytmów w poszczególnych klasach
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }

        protected virtual void GetData() //metoda do pobierania danych - współdzielona dla kilka klas z możliwością nadpisania tej metody
        {
            Console.WriteLine("Base get data");
        }

        protected abstract void PrepareData(); // metoda abstrakcyjna do przygotowania danych pod konkretny raport
                                               // - każda klasa dziedzicząca po bazowej klasie Generator musi nadpisać tą metodę
        protected abstract void GenerateFile();
        protected void SendFile() //wysyłka pliku, która wygląda w ten sposób dla każdego z trzech typów plików
                                  //- zakładamy, że żadna klasa dziedziczą po klasie bazowej nie będzie chciała dopisać własnej implementacji
        {
            Console.WriteLine("Sending generated report");
        }
    }
}
