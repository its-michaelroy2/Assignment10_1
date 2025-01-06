using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_1_
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        /// <summary>
        /// Returns a string representation of the Student object.
        /// </summary>
        /// <returns>A string containing the student's ID, name, and GPA.</returns>
        /// <example>
        /// Student student = new Student { Id = 1, Name = "John Doe", GPA = 3.4 };
        /// Console.WriteLine(student);
        /// </example>
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, GPA: {GPA:F2}";
        }
    }
}
