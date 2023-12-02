using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrin.Core.Abstraction
{
    public class Student : IStudent
    {
        public string Name { get;private set; }
        private Dictionary<string, double> CoursesGrades  =new Dictionary<string, double>();

        public Student(string name)
        {
            Name = name;
        }
        public IStudent AssignCourseGrade(string course, double grade)
        {
            if (this.CoursesGrades.ContainsKey(course))
            {
                this.CoursesGrades[course]= grade;
            }
            else
            {
                this.CoursesGrades.Add(course, grade);
            }
            return this;
        }

        public IStudent EnroulCourse(string name)
        {
            this.CoursesGrades.TryAdd(name, 0.0);
            return this;
        }

        public Dictionary<string, double> GetCoursesGrades()
        {

            return this.CoursesGrades;
        }
    }
}
