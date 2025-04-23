using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.models
{
    //Client Class
    public class StudentBL
    {
        public List<Student> RetrieveAllStudents()
        {
            //Client class Depends on Service class
            StudentDAL studentDAL = new StudentDAL();
            return studentDAL.GetAllStudents();
        }
    }
}