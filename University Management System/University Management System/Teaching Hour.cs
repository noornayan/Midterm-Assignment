using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Teaching_Hour
    {
        public string CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public Department Department { get; set; }
        Course[] courses;
        public int CreditCount { get; set; }
        public Teaching_Hour()
        {
            courses = new Course[5];
        }
        public Teaching_Hour(string courseName, int courseCreditNumber, Department department)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Department = department;
            courses = new Course[5];
        }
        public void AddTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 6)
                    this.courses[CreditCount++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}