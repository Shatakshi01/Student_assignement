using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_assignment.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string LastName{ get; set; }="";
        public DateTime Dob { get; set; }
        public string FavSubject { get; set; }  = "";
    }
}