// See https://aka.ms/new-console-template for more information
using SingleResponsiblePrin.Core.Abstraction;

Console.WriteLine("Hello, World!");
IStudent student1=new Student("Student1");
student1.EnroulCourse("English");
student1.EnroulCourse("C#");
student1.AssignCourseGrade("C#", 90);
student1.AssignCourseGrade("English", 80);
student1.AssignCourseGrade("Angular", 85);
IStudentTranscript _sysTranscript = new StudentTranscript();
_sysTranscript.PrintStudentTranscript(student1);
Console.WriteLine("---------------------------");
IStudentGPA _sysgpa = new StudentGPA();
var gpa=_sysgpa.GetStudentGPA(student1);
Console.WriteLine($"{student1.Name} GPA : {gpa}%");
