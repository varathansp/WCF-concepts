﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class EmployeeTable
    {
        
        public int id { get; set; }
       
        public string name { get; set; }
     
        public string gender { get; set; }
      
        public DateTime dateOfBirth { get; set; }
     
        public EmployeeType Type { get; set; }

        public int employeeType { get; set; }

        public int annualSalary { get; set; }

        public int hourlyPay { get; set; }

        public int hoursWorked { get; set; }
    }
}
