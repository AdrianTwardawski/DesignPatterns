 using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cfg = Configuration.GetInstance();
            //var cfg2 = Configuration.GetInstance();
            //if (ReferenceEquals(cfg, cfg2))
            //{
            //    Console.WriteLine("Configuration is a singleton");
            //}


            var cfg3 = Singleton.UtworzObjekt();
            var cfg4 = Singleton.UtworzObjekt();

            if(cfg3 == cfg4)
            {
                Console.WriteLine("Identyczne");
            }
            else
            {
                Console.WriteLine("Różnią się");
            }
        }
    }
}
