using System;

namespace IntroduccionDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var hector = new SportyPerson("Cesar", 25, "Peruano");
            var pancho = new SportyPerson("Panchito", 25);
            Console.WriteLine(hector.MostrarObjeto());
            Console.WriteLine(pancho.MostrarObjeto());
            hector.Run();
            pancho.Run();

            var carrito = new CalidadJuguete(1,50.10);
            var muneca = new CalidadJuguete(2,50.00);
            var peluche = new CalidadJuguete(3,50.00);
            var lapiz = new CalidadJuguete(5,70.00);

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
        }
    }


 
    abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string nacionality { get; set; }

        //Creas un objeto a partir de la persona
        public Person( string name_, int age_, string nacionality_)
        {
            name = name_;
            age = age_;
            nacionality = nacionality_;
        }
         public Person( string name_, int age_)
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
        public SportyPerson(string name_, int age_, string nacionality_) : base (name_, age_, nacionality_)
        {

        }

        public SportyPerson(string name_, int age_) : base(name_, age_)
        {

        }

        public void Run() 
        {
            Console.WriteLine(name+" Esta Correindo");
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

    class CalidadJuguete: Juguete
    {
        public CalidadJuguete(int Id_, double Precio_) : base (Id_, Precio_)
        {

        }

        public void Calidad()
        {
            Console.WriteLine("Calidad Juguete "+Id+" Precio $. "+precio);
        }
    }
}
