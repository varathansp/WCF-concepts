using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        //public static
        static List<EmployeeTable> employees = new List<EmployeeTable>();

        public EmployeeInfo getEmployee(EmployeeRequest employeeRequest)
        {
            Employee employee = null;
            EmployeeTable employeeTable = employees.Where(x => x.id == employeeRequest.EmployeeId).SingleOrDefault();
            if ((EmployeeType)employeeTable.Type == EmployeeType.FullTimeEmployee)
            {
                employee = new FullTimeEmployee
                {
                    id = Convert.ToInt32(employeeTable.id),
                    name = employeeTable.name.ToString(),
                    gender = employeeTable.gender.ToString(),
                    dateOfBirth = Convert.ToDateTime(employeeTable.dateOfBirth),
                    Type = EmployeeType.FullTimeEmployee,
                    annualSalary = Convert.ToInt32(employeeTable.annualSalary)
                };
            }
            else
            {
                employee = new PartTimeEmployee
                {
                    id = Convert.ToInt32(employeeTable.id),
                    name = employeeTable.name.ToString(),
                    gender = employeeTable.gender.ToString(),
                    dateOfBirth = Convert.ToDateTime(employeeTable.dateOfBirth),
                    Type = EmployeeType.PartTimeEmployee,
                    hourlyPay = Convert.ToInt32(employeeTable.hourlyPay),
                    hoursWorked = Convert.ToInt32(employeeTable.hoursWorked)
                };
            }
            return new EmployeeInfo(employee);
        }

        public void saveEmployee(EmployeeInfo employee)
        {
            EmployeeTable employeeTable = new EmployeeTable();
            employeeTable.id = employee.ID;
            employeeTable.name = employee.Name;
            employeeTable.gender = employee.Gender;
            employeeTable.dateOfBirth = employee.DOB;
            employeeTable.Type = employee.Type;

            if (employee.Type == EmployeeType.FullTimeEmployee)
            {
                employeeTable.annualSalary = employee.AnnualSalary;
            }
            else
            {
                employeeTable.hourlyPay = employee.HourlyPay;
                employeeTable.hoursWorked = employee.HoursWorked;
            }
            employees.Add(employeeTable);
        }


    }
}


//public Employee getEmployee(int id)
//{
//    Employee employee = null;
//    EmployeeTable employeeTable = employees.Where(x => x.id == id).SingleOrDefault();
//    if ((EmployeeType)employeeTable.Type == EmployeeType.FullTimeEmployee)
//    {
//        employee = new FullTimeEmployee
//        {
//            id = Convert.ToInt32(employeeTable.id),
//            name = employeeTable.name.ToString(),
//            gender = employeeTable.gender.ToString(),
//            dateOfBirth = Convert.ToDateTime(employeeTable.dateOfBirth),
//            Type = EmployeeType.FullTimeEmployee,
//            annualSalary = Convert.ToInt32(employeeTable.annualSalary)
//        };
//    }
//    else
//    {
//        employee = new PartTimeEmployee
//        {
//            id = Convert.ToInt32(employeeTable.id),
//            name = employeeTable.name.ToString(),
//            gender = employeeTable.gender.ToString(),
//            dateOfBirth = Convert.ToDateTime(employeeTable.dateOfBirth),
//            Type = EmployeeType.PartTimeEmployee,
//            hourlyPay = Convert.ToInt32(employeeTable.hourlyPay),
//            hoursWorked = Convert.ToInt32(employeeTable.hoursWorked)
//        };
//    }
//    return employee;
//}

//public void saveEmployee(Employee employee)
//{
//    EmployeeTable employeeTable = new EmployeeTable();
//    employeeTable.id = employee.id;
//    employeeTable.name = employee.name;
//    employeeTable.gender = employee.gender;
//    employeeTable.dateOfBirth = employee.dateOfBirth;
//    employeeTable.Type = employee.Type;

//    if (employee.GetType() == typeof(FullTimeEmployee))
//    {
//        employeeTable.annualSalary = ((FullTimeEmployee)employee).annualSalary;
//    }
//    else
//    {
//        employeeTable.hourlyPay = ((PartTimeEmployee)employee).hourlyPay;
//        employeeTable.hoursWorked = ((PartTimeEmployee)employee).hoursWorked;
//    }
//    employees.Add(employeeTable);
//}
