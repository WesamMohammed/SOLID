using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrin.Core.Abstraction
{
    public interface IStudent
    {
        public string Name { get; }
        Dictionary<string, double> GetCoursesGrades();
         IStudent EnroulCourse(string name);
        IStudent AssignCourseGrade(string course,double grade);
    }
}
