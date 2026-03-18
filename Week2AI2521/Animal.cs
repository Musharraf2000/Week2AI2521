using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class Animal
    {
        public string name;
        public int age;

        public virtual void MakeSound()
        {
           Console.WriteLine("The animal makes a sound.");
        }
    }
}
