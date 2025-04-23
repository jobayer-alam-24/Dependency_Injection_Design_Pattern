using Dependency_Injection_Design_Pattern.models;

namespace Dependency_Injection_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementation of Tight Coupling
            StudentBL studentBL = new StudentBL();
            var students = studentBL.RetrieveAllStudents();
            foreach(var student in students) Console.WriteLine($"{student.Id}. Name: {student.Name}. Department: {student.Department}");
        }
    }
}