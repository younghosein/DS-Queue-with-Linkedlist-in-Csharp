using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFunc_Example
{
    class Program
    {
        static void s()
        {

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Queue Q = new Queue();
            Q.enqueue(1);
            Q.enqueue(3);
            Q.enqueue(4);
            Q.enqueue(6);
            Q.enqueue(5);
            Q.enqueue(7);
            Q.enqueue(2);

            Console.Write("Queue Is : ");
            Q.print();
            Q.delmax();
            Console.Write("Now Queue Is : ");
            Q.print();
            Console.Write("\n\nNow Queue Is : ");
            Q.delbend();
            Q.print();



            Console.ReadKey();
        }
    }
}
