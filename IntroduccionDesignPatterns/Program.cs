using System;
using System.Collections.Generic;

namespace IntroduccionDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Orientado a Objetos
            var hector = new SportyPerson("Cesar", 25, "Peruano");
            var pancho = new SportyPerson("Panchito", 25);
            Console.WriteLine(hector.MostrarObjeto());
            Console.WriteLine(pancho.MostrarObjeto());
            hector.Run();
            pancho.Run();

            var carrito = new CalidadJuguete(1, 50.10);
            var muneca = new CalidadJuguete(2, 50.00);
            var peluche = new CalidadJuguete(3, 50.00);
            var lapiz = new CalidadJuguete(5, 70.00);

            Console.WriteLine("----------PRECIO DE JUGUETES----------");
            Console.WriteLine(carrito.PrecioJuguete());
            Console.WriteLine(muneca.PrecioJuguete());
            Console.WriteLine(peluche.PrecioJuguete());
            Console.WriteLine(lapiz.PrecioJuguete());

            Console.WriteLine("----------CALIDAD DEL PRECIO DE JUGUETES----------");
            carrito.Calidad();
            muneca.Calidad();
            peluche.Calidad();
            lapiz.Calidad();

            #endregion

            #region Interface


            Console.WriteLine("%%%%%%%%%%   Interfaces %%%%%%%%%%%%%%%%%%%");
            List<IVolador> aves = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            var gallina1 = new Gallina();
            var gallina2 = new Gallina();
            var gallina3 = new Gallina();


            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(pato3);
            aves.Add(gallina1);
            aves.Add(gallina2);
            aves.Add(gallina3);


            AVolar(aves);

            Console.WriteLine("%%%%%%%%%%   Interfaces  MOVILIDAD %%%%%%%%%%%%%%%%%%%");
            List<IAuto> autos = new List<IAuto>();
            var marcaRonco = new ServicioExpress();
            var marcaNexus = new ServicioExpress();
            var marcaCroos = new ServicioExpress();
            var marcaYundai = new ServicioCarga();
            var marcaChangan = new ServicioCarga();

            autos.Add(marcaRonco);
            autos.Add(marcaNexus);
            autos.Add(marcaCroos);
            autos.Add(marcaYundai);
            autos.Add(marcaChangan);


            TransportePeque(autos);



            #endregion
        }








        #region Herencia Orienatado a Objetos


        abstract class Person
        {
            public string name { get; set; }
            public int age { get; set; }
            public string nacionality { get; set; }

            //Creas un objeto a partir de la persona
            public Person(string name_, int age_, string nacionality_)
            {
                name = name_;
                age = age_;
                nacionality = nacionality_;
            }
            public Person(string name_, int age_)
            {
                name = name_;
                age = age_;

            }

            public string MostrarObjeto()
            {
                return name + " " + age + " " + nacionality;
            }

            public string MostrarObjetoMinimo()
            {
                return name + " " + age;
            }
        }


        //Herencia
        class SportyPerson : Person
        {
            public SportyPerson(string name_, int age_, string nacionality_) : base(name_, age_, nacionality_)
            {

            }

            public SportyPerson(string name_, int age_) : base(name_, age_)
            {

            }

            public void Run()
            {
                Console.WriteLine(name + " Esta Correindo");
            }
        }

        abstract class Juguete
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public double precio { get; set; }

            public Juguete(int Id_, double Precio_)
            {

                Id = Id_;

                precio = Precio_;

            }

            public string PrecioJuguete()
            {
                return Id + " " + precio;
            }
        }

        class CalidadJuguete : Juguete
        {
            public CalidadJuguete(int Id_, double Precio_) : base(Id_, Precio_)
            {

            }

            public void Calidad()
            {
                Console.WriteLine("Calidad Juguete " + Id + " Precio $. " + precio);
            }
        }

        #endregion






        #region Interface

        static void AVolar(List<IVolador> aves)
        {
            foreach (var ave in aves)
            {
                ave.Vuela();

            }
        }

        static void TransportePeque (List<IAuto> autos)
        {
            foreach (var auto in autos)
            {
                auto.TaxiE();
            }
        }


        interface IVolador
        {
            public void Vuela();
        }

        interface ICaminador
        {
            public void Camina();
        }


        public class Pato : IVolador, ICaminador
        {

            public void Vuela()
            {
                Console.WriteLine("Mi Pato Vuela");
            }

            public void Camina()
            {
                Console.WriteLine("Mi Pato Camina");
            }
        }

        public class Gallina : IVolador
        {
            public void Vuela()
            {
                Console.WriteLine("Mi Gallina Vuela");
            }
        }


        interface IMoto
        {
            public void DeliveryE();
        }


        interface IAuto
        {
            public void TaxiE();
        }

      


        class ServicioExpress : IMoto, IAuto
        {
            public void DeliveryE()
            {
                Console.WriteLine("Servicio de Delivery");
            }

            public void TaxiE()
            {
                Console.WriteLine("Servicio de Taxi");
            }
            
        }

        class ServicioCarga: IAuto
        {
            public void TaxiE()
            {
                Console.WriteLine("Servicio de Carga");
            }
        }

    }

    #endregion
}
