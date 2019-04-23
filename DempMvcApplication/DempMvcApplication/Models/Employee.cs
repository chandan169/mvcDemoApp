using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DempMvcApplication.Models
{
    public class Employee
    {
        public Int64 EmployeeId { get; set; }
        public string Name { get; set; }
        public long DepartmentId { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}