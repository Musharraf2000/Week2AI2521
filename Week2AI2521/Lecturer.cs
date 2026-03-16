using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class Lecturer:Person
    {
        private string lecturerID;

        public Lecturer(string name, int age, string lecturerID) : base(name, age)
        {
            this.lecturerID = lecturerID;
        }

        public void MarkAssignment(string assignmentName, Student student)
        {
            Console.WriteLine($"{Name} marked the assignment: {assignmentName} for student {student.Name}.");
        }
    }
}
