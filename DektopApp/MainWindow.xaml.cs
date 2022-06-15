using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DektopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Read_Files_Handler(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Reading started";
            var stopwatch = Stopwatch.StartNew();
            ProccessFiles();
            stopwatch.Stop();
            ResultLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms";
        }


        private async void Read_FilesAsync_Handler(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Reading started";
            var stopwatch = Stopwatch.StartNew();
            var result = await ProccessFilesAsync(); //aby odczekać wykonanie metody asynchronicznej, to przy wywołaniu dodajemy await,
                                        //a deklaracja metody musi zawierać typ Task jako zwracany typ
            stopwatch.Stop();
            ResultLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms. Result: {result}";
        }

        private void ProccessFiles()
        {
            var filesPath = "C:/Users/Adrian/Desktop/asyncfiles/";
            for (int i = 1; i <= 5; i++)
            {
                var filePath = filesPath + $"{i}.txt";
                
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    ResultLabel.Content = $"Reading { filePath}..";

                    var fileContent = reader.ReadToEnd();
                }
            }
        }

        private async Task<int> ProccessFilesAsync() //zmiana z void na Task, po to aby być w stanie odczekać tą metodę w handlerze.
                                                     //Aby zwrócić rezultat z asynchronicznej metody wykorzytujemy generyczną implementację
                                                     //klasy Task np. Task<int>
        {
            var filesPath = "C:/Users/Adrian/Desktop/asyncfiles/";
            var totalLength = 0;
            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= 5; i++)
            {
                var filePath = filesPath + $"{i}.txt";

                var task = Task.Run(() =>
                {
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {

                        var fileContent = reader.ReadToEnd();
                 
                        totalLength += fileContent.Length;
                    }
                });

                tasks.Add(task);

                //using (var reader = new StreamReader(filePath, Encoding.UTF8))
                //{
                //    ResultLabel.Content = $"Reading {filePath}..";

                //    var fileContent = reader.ReadToEnd();
                     
                //    var fileContent = await Task.Run(() => reader.ReadToEnd()); //wczytywanie pliku do pamięci, akcja zostaje oddelegowana
                //    //na inny wątek niż wątek główny
                //    totalLength += fileContent.Length;
                //}
            }

            await Task.WhenAll(tasks); // wykonujemy kilka akcji równolegle, Task.WhenAll zakończy swoje działanie,
                                       // kiedy wszystkie metody do niej przekazane zakończą swoje działanie

            return totalLength;
        }

    }
}
