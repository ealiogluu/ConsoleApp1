using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrencıTakip
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int StudentNumber { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Student(string firstName, string lastName, string department, int studentNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            StudentNumber = studentNumber;

            Lessons = new List<Lesson>();
        }

        
    }
          
    class Lesson
    {
        public string Name { get; set; }   
        
    }


}
