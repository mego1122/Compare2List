using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare2List.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int _id,string _Name,string _Email)
        {
            Id = _id;
            Name = _Name;
            Email = _Email;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
