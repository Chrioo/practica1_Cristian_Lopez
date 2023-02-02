using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praxtica1Clopez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Caballo miCaballo = new Caballo("Socrates");
                Humano miHumano = new Humano("Jeff");
                Gorila miGorila = new Gorila("Macumba");
                Ballena miBallena = new Ballena("Moby");
                Cocodrilo miCocodrilo = new Cocodrilo("Skar");

                Mamifero[] almacenAnimales = new Mamifero[4];
                almacenAnimales[0] = miCaballo;
                almacenAnimales[1] = miHumano;
                almacenAnimales[2] = miGorila;
                almacenAnimales[3] = miBallena;
               

                for (int i = 0; i < 3; i++)
                {
                   almacenAnimales[i].pensar();
                }

                Mamifero miMamifero = new Mamifero("");
                miMamifero.pensar();

                miCaballo.cuidarCrias();
                miHumano.getNombre();
                miGorila.balancearse();

            


        }

        abstract class Animales
        {
            public void respirar()
            {
                Console.WriteLine("Soy capaz de poder respirar");
            }

            public abstract void getNombre();
        }

        interface IAnimalesTerrestres
        {
            int numeroPatas();
        }

        class Reptil : Animales
        {
            public Reptil(String Nombre)
            {
                String nombreSerVivo = Nombre;
            }

            public override void getNombre()
            {
                Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
            }

            private String nombreSerVivo;
        }

        class Mamifero : Animales
        {
            public Mamifero(String Nombre)
            {
                String nombreSerVivo = Nombre;
            }



            public void pensar()
            {
                Console.WriteLine("Pensamientos básico instintivos");
            }

            public void cuidarCrias()
            {
                Console.WriteLine("Cuidar de las crias hasta que se valgan por si solar");
            }


            public override void getNombre()
            {
                Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
            }

            private String nombreSerVivo;


        }

        class Ballena : Mamifero
        {
            public Ballena(String NombreBallena) : base(NombreBallena)
            {

            }

            public void nadar()
            {
                Console.WriteLine("Tengo la capacidad de nadar");
            }
        }

        class Caballo : Mamifero, IAnimalesTerrestres
        {
            public Caballo(String NombreCaballo) : base(NombreCaballo)
            {

            }

            public void galopar()
            {
                Console.WriteLine("Yo puedo galopar");
            }

            public int numeroPatas()
            {
                return 4;
            }

        }

        class Humano : Mamifero
        {
            public Humano(String NombreHumano) : base(NombreHumano)
            {

            }

            public void pensar()
            {
                Console.WriteLine("Soy capaz de pensar ");
            }
        }

        class Gorila : Mamifero, IAnimalesTerrestres
        {
            public Gorila(String NombreGorila) : base(NombreGorila)
            {

            }

            public void balancearse()
            {
                Console.WriteLine("Soy capaz de balancearme");
            }
            public int numeroPatas()
            {
                return 2;
            }
        }

        class Cocodrilo : Reptil, IAnimalesTerrestres
        {
            public Cocodrilo(String NombreCocodrilo) : base(NombreCocodrilo)
            {

            }

            public void Cazar()
            {
                Console.WriteLine("Yo puedo Cazar");
            }
            public int numeroPatas()
            {
                return 4;
            }
        }
    }
    
}
