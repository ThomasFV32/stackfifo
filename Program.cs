using System.Collections.Generic;
using System;

namespace ModeladoFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFO pepito = new FIFO();
            pepito.Add("asd");
            pepito.Add("juan");
            pepito.Add(1.50);
            pepito.Add(2);
            pepito.Add("pepito");
            pepito.Add(2.60);
            pepito.MostrarConsole();
            linea();
            Console.WriteLine("Primer elemento: "+ pepito.GetItem());
            linea();
            pepito.MostrarConsole();
            linea();
            pepito.Delete(1.50);
            pepito.MostrarConsole();
            linea();
            Console.WriteLine(pepito.FindItem("pepito"));
            linea();
            Console.WriteLine(pepito.ReturnMaxMin());
            linea();
            pepito.MostrarConsole();
            linea();
            /* Console.ReadLine(); */
            pepito.Add(-1);
            pepito.Add(new int[] {1,2,3,4,98458});
            pepito.Add(true);
            pepito.Add(false);
            FIFO algo = new FIFO();
            pepito.Add(algo);
            pepito.GetItem();
            pepito.MostrarConsole();
            /* Console.ReadLine(); */
            linea();
            Console.WriteLine(pepito.FindItem(98458));

            
            
        }

        static void linea()
        {
            for(int i = 0 ; i < 80 ;i++)
            Console.Write("-");
            Console.WriteLine("");
        }
    }
}
