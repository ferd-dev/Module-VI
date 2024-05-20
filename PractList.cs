using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class PractList
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public void print()
        {
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.Write($"{item}, ");
            }
        }

        public void delete()
        {
            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);
        }
    }

   
}
