using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class Student:Person
    {
        private string cbNumber;
        public Student(string name, int age, string cbNumber) : base(name, age)
        {
            this.cbNumber = cbNumber;
        }

        public string CbNumber { get => cbNumber; set => cbNumber = value; }

        public void submitAssignment(string assignmentName)
        {
            Console.WriteLine($"{Name} submitted the assignment: {assignmentName}.");
        }
    }
}
