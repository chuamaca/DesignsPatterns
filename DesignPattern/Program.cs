using System;
using System.Collections.Generic;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Singleton.Instance;

            var log = Singleton.Log.Instance;
            log.Save("Log A");
            log.Save("Log b");
            log.Save("Log C");
            log.Save("Log Sistrem");


            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;

            var random = new Random();


            Console.WriteLine(a == b);



            List<Autos> autosD= new List<Autos>();

            for (double item = 0; item <= 10; item++)
            {
                var rd = random.Next(1, 100);
                log.Save(Convert.ToString(rd));
                Console.WriteLine(rd);
            }



          
        }

        class Autos
        {
            
        }
    }
}
