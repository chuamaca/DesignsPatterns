using System;
using System.Collections.Generic;
using DesignPattern.FactoryPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            //var singleton = Singleton.Singleton.Instance;
            //var log = Singleton.Log.Instance;
            //log.Save("Log A");
            //log.Save("Log b");
            //log.Save("Log C");
            //log.Save("Log Sistrem");


            //var a = Singleton.Singleton.Instance;
            //var b = Singleton.Singleton.Instance;

            //var random = new Random();


            //Console.WriteLine(a == b);



            //List<Autos> autosD = new List<Autos>();

            //for (double item = 0; item <= 10; item++)
            //{
            //    var rd = random.Next(1, 100);
            //    log.Save(Convert.ToString(rd));
            //    Console.WriteLine(rd);
            //}
            #endregion

            #region Factory Metod
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(10);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(9);


            #endregion



        }

        class Autos
        {
            
        }
    }
}
