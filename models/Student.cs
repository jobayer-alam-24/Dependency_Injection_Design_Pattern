using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Design_Pattern.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public Department Department {get; set;}
    }
    public enum Department
    {
        CSE, EEE, CIVIL
    }
}