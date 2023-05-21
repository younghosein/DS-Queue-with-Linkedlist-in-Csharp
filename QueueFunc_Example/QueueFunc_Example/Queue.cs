using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFunc_Example
{
    class Queue
    {
        public Node rear;
        public Node front;
        public Queue()
        {
            front = rear = null;
        }
        public void enqueue(int d)
        {
            Node nn = new Node(d);
            if (rear == null)
            {
                front = nn;
                rear = nn;
                return;
            }
            rear.next = nn;
            rear = nn;
        }
        public void dequeue()
        {
            if (front == null)
            {
                return;
            }
            Console.WriteLine($"{front.data} Is Deleted...");
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
        }
        public void print()
        {
            Node n = front;
            if (front == null && rear == null)
            {
                return;
            }
            while (n != null)
            {
                Console.Write(n.data + " . ");
                n = n.next;
            }
        }
        public void delmax()
        {
            if (front == null)
            {
                return;
            }
            int max = int.MinValue;
            Node n = front;
            while (n != null)
            {
                if (max < n.data)
                    max = n.data;
                n = n.next;
            }
            int d = max;
            Console.WriteLine($"\n\n{max} Is Deleted...");
            Node nn = front;
            Node t = null;

            if (nn != null && nn.data == d)
            {
                front = nn.next;
                return;
            }
            while (nn != null && nn.data != d)
            {
                t = nn;
                nn = nn.next;
            }
            if (nn == null)
            {
                return;
            }
            t.next = nn.next;
        }
        public void delbend()
        {
            int d = rear.data;
            Node nn = front;
            Node t = null;

            if (nn != null && nn.data == d)
            {
                front = nn.next;
                return;
            }
            while (nn != null && nn.data != d)
            {
                t = nn;
                nn = nn.next;
            }
            if (nn == null)
            {
                return;
            }
            t.next = nn.next;
        }

    }
}
