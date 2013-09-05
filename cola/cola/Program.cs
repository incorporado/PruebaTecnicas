using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista unaCola = new Lista();
            
            //Test Size
            int a = unaCola.Size;
            Console.WriteLine(a);
            
            //Test excepcion Top
            try
            {
                object contenido = unaCola.Top;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("No hay elementos en la cola", e);
            }

            //Test excepcion Remove
            try
            {
                unaCola.Remove();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("No hay elementos en la cola", e);
            }

            
            //Test Add
            unaCola.Add(10);
            unaCola.Add(20);
            unaCola.Add(30);
            unaCola.Add(40);
            unaCola.Add(50);
            a = unaCola.Size;
            Console.WriteLine(a);
             
            //Test general 
            object item = unaCola.Top;
            Console.WriteLine((int)item);
            unaCola.Remove();
            item = unaCola.Top;
            Console.WriteLine((int)item);
            unaCola.Remove();
            item = unaCola.Top;
            Console.WriteLine((int)item);
            unaCola.Remove();
            unaCola.Remove();
            item = unaCola.Top;
            Console.WriteLine((int)item);
            unaCola.Remove();
            a = unaCola.Size;
            Console.WriteLine(a);

            Console.Write("Exito");
            Console.In.ReadLine();
        }
    }
}
