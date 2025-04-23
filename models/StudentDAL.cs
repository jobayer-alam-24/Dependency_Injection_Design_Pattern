using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.models
{
    //Service Class
    public class StudentDAL
    {
        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student {Id = 1, Name = "Rahim", Department = Department.CSE},
                new Student {Id = 2, Name = "Karim", Department = Department.EEE},
                new Student {Id = 2, Name = "John Cena", Department = Department.CIVIL},
                new Student { Id = 3, Name = "Ayesha", Department = Department.CSE },
                new Student { Id = 4, Name = "Tariq", Department = Department.EEE },
                new Student { Id = 5, Name = "Sonia", Department = Department.CIVIL },
                new Student { Id = 6, Name = "Mizan", Department = Department.CSE },
                new Student { Id = 7, Name = "Farah", Department = Department.EEE },
                new Student { Id = 8, Name = "Nayeem", Department = Department.CIVIL },
                new Student { Id = 9, Name = "Anika", Department = Department.CSE },
                new Student { Id = 10, Name = "Habib", Department = Department.EEE }

            };
        }
    }
}