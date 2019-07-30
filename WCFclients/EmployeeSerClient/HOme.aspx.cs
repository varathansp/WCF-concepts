using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeSerClient
{
    public partial class HOme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            //EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            //EmployeeService.Employee employee = client.getEmployee(Convert.ToInt32(txtID.Text));
            EmployeeService.IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeRequest request = new EmployeeService.EmployeeRequest("XYZ120FABC", Convert.ToInt32(txtID.Text));

            EmployeeService.EmployeeInfo employee = client.getEmployee(request);

            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                //txtAnnualSalary.Text =((EmployeeService.FullTimeEmployee)employee).annualSalary.ToString();
                txtAnnualSalary.Text =employee.AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
            //    txtHourlyPay.Text =((EmployeeService.PartTimeEmployee)employee).hourlyPay.ToString();
            //    txtHoursWorked.Text = ((EmployeeService.PartTimeEmployee)employee).hoursWorked.ToString();
                txtHourlyPay.Text = employee.HourlyPay.ToString();
                txtHoursWorked.Text = employee.HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();


            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DOB.ToShortDateString();
            lblMessage.Text = "Employee Retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeService.IEmployeeService client = new
                EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeInfo employee = new EmployeeService.EmployeeInfo();

            if (ddlEmployeeType.SelectedValue == "-1")
            {
                lblMessage.Text = "Please select Employee Type";
            }
            else
            {
                if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
                    == EmployeeService.EmployeeType.FullTimeEmployee)
                {
                    employee.AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text);
                    employee.Type = EmployeeService.EmployeeType.FullTimeEmployee;
                }
                else if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
                    == EmployeeService.EmployeeType.PartTimeEmployee)
                {
                    employee.HourlyPay = Convert.ToInt32(txtHourlyPay.Text);
                    employee.HoursWorked = Convert.ToInt32(txtHoursWorked.Text);



                    employee.Type = EmployeeService.EmployeeType.PartTimeEmployee;
                }

                employee.ID = Convert.ToInt32(txtID.Text);
                employee.Name = txtName.Text;
                employee.Gender = txtGender.Text;
                employee.DOB = Convert.ToDateTime(txtDateOfBirth.Text);

                client.saveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }

        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }

        }
    }
}

//protected void btnGetEmployee_Click(object sender, EventArgs e)
//        {
//            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
//            EmployeeService.Employee employee = client.getEmployee(Convert.ToInt32(txtID.Text));

//            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
//            {
//                txtAnnualSalary.Text =
//                    ((EmployeeService.FullTimeEmployee)employee).annualSalary.ToString();
//                trAnnualSalary.Visible = true;
//                trHourlPay.Visible = false;
//                trHoursWorked.Visible = false;
//            }
//            else
//            {
//                txtHourlyPay.Text =
//                    ((EmployeeService.PartTimeEmployee)employee).hourlyPay.ToString();
//                txtHoursWorked.Text =
//                    ((EmployeeService.PartTimeEmployee)employee).hoursWorked.ToString();
//                trAnnualSalary.Visible = false;
//                trHourlPay.Visible = true;
//                trHoursWorked.Visible = true;
//            }
//            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();


//            txtName.Text = employee.name;
//            txtGender.Text = employee.gender;
//            txtDateOfBirth.Text = employee.dateOfBirth.ToShortDateString();
//            lblMessage.Text = "Employee Retrieved";
//        }

//        protected void btnSave_Click(object sender, EventArgs e)
//        {
//            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
//            EmployeeService.Employee employee = null;
//            if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.FullTimeEmployee)
//            {
//                employee = new EmployeeService.FullTimeEmployee
//                {
//                    ID = Convert.ToInt32(txtID.Text),
//                    name = txtName.Text,
//                    gender = txtGender.Text,
//                    dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
//                    Type = EmployeeService.EmployeeType.FullTimeEmployee,



//                    annualSalary = Convert.ToInt32(txtAnnualSalary.Text),
//                };
//                client.saveEmployee(employee);
//                lblMessage.Text = "Employee saved";
//            }
//            else if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
//                == EmployeeService.EmployeeType.PartTimeEmployee)
//            {
//                employee = new EmployeeService.PartTimeEmployee
//                {
//                    ID = Convert.ToInt32(txtID.Text),
//                    name = txtName.Text,
//                    gender = txtGender.Text,
//                    dateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
//                    Type = EmployeeService.EmployeeType.PartTimeEmployee,
//                    hourlyPay = Convert.ToInt32(txtHourlyPay.Text),
//                    hoursWorked = Convert.ToInt32(txtHoursWorked.Text),
//                };
//                client.saveEmployee(employee);
//                lblMessage.Text = "Employee saved";
//            }
//            else
//            {
//                lblMessage.Text = "Please select Employee Type";
//            }

//        }