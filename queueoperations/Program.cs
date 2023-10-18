using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");

            q.Dequeue();
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");

            Queue q1 = new Queue(q.Count);
            q.CopyTo(q1.ToArray(), 0);

            foreach(var item in q1)
            {
                Console.WriteLine(item);
            }

            q1.Clear();
            Console.ReadLine();
        }
        
    }
}
