using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Clases;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Error1();

            Error2();

            Error3();

            Error4();

            Console.ReadLine();
        }

       
        private static void Error1()
        {

            Pelicula pelicula = new Pelicula(1, "Kill Bill Vol 1", new DateTime(2021, 08, 01));



            Pelicula pelicula2;
            pelicula2 = (Pelicula)pelicula.Clone();
            
            pelicula2.CodigoPelicula = 2;
            pelicula2.Nombre = "Mulan";

            Console.WriteLine("La pelicula1 es : " + pelicula.MostarPelicula());
            Console.WriteLine("La pelicula2 es : " + pelicula2.MostarPelicula());
            
        }

        private static void Error2()
        {
            int clavePelicula = 0;

            Dictionary<int, Pelicula> diccionarioPelicula = new Dictionary<int, Pelicula>();

            Pelicula pelicula = new Pelicula(1, "Kill Bill Vol 1", new DateTime(2021, 08, 01));

            clavePelicula = pelicula.CodigoPelicula;
            diccionarioPelicula.Add(clavePelicula, pelicula);
            Console.WriteLine(diccionarioPelicula[1].MostarPelicula());

            Pelicula pelicula2 = new Pelicula(2, "Kill Bill Vol 2", new DateTime(2021, 08, 01));
            clavePelicula = pelicula2.CodigoPelicula;
            diccionarioPelicula.Add(clavePelicula, pelicula);
            Console.WriteLine(diccionarioPelicula[2].MostarPelicula());
        }

        private static void Error3()
        {
            Pelicula pelicula = new Pelicula(1, "Kill Bill Vol 1", new DateTime(2021, 01, 01));

            Console.WriteLine(pelicula.MostarPelicula());

        }

        private static void Error4()
        {
            Pelicula pelicula = new Pelicula(100, "yo flipo", new DateTime(2021, 11, 12));

            Console.WriteLine(pelicula.MostarPelicula());
        }

       

    }
}

