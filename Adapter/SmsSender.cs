using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSender //zakładamy, że ta klasa jest klasą zewnętrzną i to dla niej przygotowujemy adapter
    {
        public void SendSms(string to, string text) //metoda służąca do wysyłania sms-ów
        {
            Console.WriteLine($"Sending SMS to : {to}");
        }
    }
}
