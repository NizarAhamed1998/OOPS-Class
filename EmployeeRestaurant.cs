using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class EmployeeRestaurant
    {
        int _employeeId;
        string _employeeName;
        string _gender;
        DateTime _dateOfBirth;
        int _age;
        string _employeePosition;
        string _employeeDepartment;
        string _address;

       
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public int Age
        {
           
            set 
            {
                if (value>=19)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age is not in limit");
                }
            }
        }
        public string EmployeePosition
        {
            get { return _employeePosition; }
            set { _employeePosition = value; }
        }
        public string EmployeeDepartment
        {
            get { return _employeeDepartment; }
            set { _employeeDepartment = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public EmployeeRestaurant(int empId,string empName,string gender,DateTime dateofbirth,string empPosition,string empDepartment,string address)
        {
            EmployeeId = empId;
            EmployeeName = empName;
            Gender = gender;
            DateOfBirth = dateofbirth;
            Age = DateTime.Now.Subtract(DateOfBirth).Days / 365;
            EmployeePosition = empPosition;
            EmployeeDepartment = empDepartment;
            Address = address;
        }
    }
}
