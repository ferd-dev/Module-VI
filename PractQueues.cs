using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class PractQueues
    {
        private Queue<string> customers = new Queue<string>();

        public PractQueues()
        {
            customers.Enqueue("Cliente 1");
            customers.Enqueue("Cliente 2");
            customers.Enqueue("Cliente 3");
            customers.Enqueue("Cliente 4");
            customers.Enqueue("Cliente 5");
        }

        public void print()
        {
            Console.WriteLine("---------");
            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
        }

        public void deleteCustomer()
        {
            customers.Dequeue();
        }
    }
}
