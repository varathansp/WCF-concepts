using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EmployeeService
{
   [MessageContract(IsWrapped= true, WrapperName= "EmployeeRequestObject", WrapperNamespace= "http://MyCompany.com/Employee")]
    public class EmployeeRequest
    {
        //Protection Level
        [MessageBodyMember(Namespace = "http://MyCompany.com/Employee")]
        public int EmployeeId { get; set; }

        [MessageHeader(Namespace = "http://MyCompany.com/Employee")]
        public string LicenseKey { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {
        }
        public EmployeeInfo(Employee employee)
        {
            this.ID = employee.id;
            this.Name = employee.name;
            this.Gender = employee.gender;
            this.DOB = employee.dateOfBirth;
            this.Type = employee.Type;
            if (this.Type == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).annualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).hourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).hoursWorked;
            }
        }

        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Employee")]
        public int ID { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Employee")]
        public string Name { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Employee")]
        public string Gender { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Employee")]
        public DateTime DOB { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Employee")]
        public EmployeeType Type { get; set; }
        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Employee")]
        public int AnnualSalary { get; set; }
        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Employee")]
        public int HourlyPay { get; set; }
        [MessageBodyMember(Order = 8, Namespace = "http://MyCompany.com/Employee")]
        public int HoursWorked { get; set; }
    }


    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
   [DataContract(Namespace ="http://wire/Employee")]
    public class Employee
    {
        [DataMember(Order =1,Name ="ID")]
        public int id { get; set; }
        [DataMember(Order = 2)]
        public string name { get; set; }
        [DataMember(Order = 3)]
        public string gender { get; set; }
        [DataMember(Order = 4)]
        public DateTime dateOfBirth { get; set; }
        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }
    }
    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
//[Serializable]