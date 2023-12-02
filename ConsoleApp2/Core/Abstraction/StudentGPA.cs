using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrin.Core.Abstraction
{
    public class StudentGPA : IStudentGPA
    {
        public double GetStudentGPA(IStudent student)
        {
            
           
            return student.GetCoursesGrades().Values.Average();
        }
    }
}
