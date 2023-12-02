using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrin.Core.Abstraction
{
    public interface IStudentTranscript
    {
        void PrintStudentTranscript(IStudent student);
        void PrintStudentTranscript(string name ,Dictionary<string,double> cousesGrades);
    }
}
