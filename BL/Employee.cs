using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class Employee : User
    {
        public string Salary { get; private set; }
        public DateTime JoiningDate { get; private set; }
        public int EmployeeType { get; private set; }

        public Employee(DateTime joiningDate, string salary, int employeeType, string username, string password, int userType): base(username, password, userType)
        {
            Salary = salary;
            JoiningDate = joiningDate;
            EmployeeType = employeeType;
        }
    }
}
