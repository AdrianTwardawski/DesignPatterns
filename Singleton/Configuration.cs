using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Configuration
    {
        private static Configuration _instance = null;
        private static object obj = new object();
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }

        private Configuration()
        {
        }

        public static Configuration GetInstance()
        {
            //istnieje szansa że dwa wątki znajdą sie w tym samym położeniu, przez co te dwa wątki
            //utworzą dwa nowe obiekty typu Configuration
            //lock sprawi, że jeżeli dwa wątki w tym samym czasie będą próbowąły się do warunku if,
            //to pierwszy z nich zablokuje dostęp temu drugiemu, przez co ten drugi wątek po odczekaniu
            //jakiegoś czasu nie będzie już widział wartośći instance tylko wartości równej null
            lock (obj) 
            {
                if(_instance == null)
                {
                    _instance = new Configuration();
                }
            }

            return _instance;
        }
    }
}
