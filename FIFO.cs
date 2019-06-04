using System;
using System.Linq;
using System.Collections.Generic;
namespace ModeladoFIFO
{
    public class FIFO
    {
        List<object> fifo;
        public FIFO()
        {
            fifo = new List<object>();
        }

        public void Add(object valor)
        {
            fifo.Add(valor);
        }
        public void Delete(object valor)
        {
            if(fifo[0]!=null)
            {
                
                fifo.Remove(fifo.Find(x=>x==valor));
            }
        }
        public object GetItem()
        {
            object temp= fifo.First();
            Delete(temp);
            return temp;
        }
        public object FindItem(object item)
        {
            return fifo.Contains(item);
        }
        public string ReturnMaxMin()
        {
            return "Primero: "+fifo.First() + " Ultimo: "+ fifo.Last();
        }
        
        public List<object> Mostrar () => (from p in fifo select p).ToList();

        public void MostrarConsole()
        {
            List<object> temp=Mostrar();
            foreach(var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}