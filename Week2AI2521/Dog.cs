using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class Dog:Animal
    {
        public string furColor;

        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
