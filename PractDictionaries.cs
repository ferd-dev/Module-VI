using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class PractDictionaries
    {
        private Dictionary<string, int> students = new Dictionary<string, int>();

        public PractDictionaries()
        {
            students.Add("Fernando", 7);
            students.Add("Ana", 8);
            students.Add("Carlos", 7);
            students.Add("Jose", 5);
            students.Add("Maria", 9);
        }

        public void printPar()
        {
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine($"Name: {student.Key} Value: {student.Value}");
            }
        }

        public void updateAndDelete()
        {
            students["Fernando"] = 9;
            students.Remove("Jose");
        }
    }
}
