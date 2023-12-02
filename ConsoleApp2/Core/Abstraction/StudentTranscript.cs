using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrin.Core.Abstraction
{
    public class StudentTranscript : IStudentTranscript
    {
        public void PrintStudentTranscript(IStudent student)
        {



            PrintStudentTranscript(student.Name, student.GetCoursesGrades());
        }

        public void PrintStudentTranscript(string name, Dictionary<string, double> coursesGrades)
        {

            Console.WriteLine($"Transcript of {name}");
            foreach (var courGrade in coursesGrades)
            {
                Console.WriteLine($"Course:{courGrade.Key}=>> Grade:{courGrade.Value}");
            }
        }
    }
}
