using System;
using System.Collections;

namespace QueueAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueDemo demo = new QueueDemo();
            demo.QueueOps();
           
        }
    }

    public class QueueDemo
    {
        public void QueueOps()
        {
            Queue q = new Queue();
            Console.WriteLine("********Queue Operations*******");


            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            q.Dequeue();

            foreach (int items in q)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
    
    
}
