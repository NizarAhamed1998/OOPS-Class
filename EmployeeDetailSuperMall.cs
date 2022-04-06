using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class EmployeeDetailSuperMall
    {
        string _employeeCode;

        string _employeeName;

        DateTime _dateOfBirth;

        int _age;
        string _gender;

        string _address;

        long _contactNo;

        string _branchName;

        string _department;

        string _shift;

        int _workTiming;

        int _salary;



        public string EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public DateTime DateOfBirth
        {
            
            set { _dateOfBirth = value; }
        }

        public int Age
        {
            get { return _age; }
            set 
            {
                if (value >= 19)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("above 19 only allow to work");
                }
            }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public long ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public int WorkTiming
        {
            get { return _workTiming; }
            set { _workTiming = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public EmployeeDetailSuperMall(string employeeCode, string employeeName, DateTime dateOfBirth, string address, long contactNo, string branchName,
           string department, string shift, int workTiming, int salary,string gender)
        {
            EmployeeCode = employeeCode;
            EmployeeName = employeeName;
            DateOfBirth = dateOfBirth;
            Age = DateTime.Now.Subtract(_dateOfBirth).Days / 365;
            Address = address;
            ContactNo = contactNo;
            BranchName = branchName;
            Department = department;
            Shift = shift;
            WorkTiming = workTiming;
            Salary = salary;
            Gender = gender;
        }
    }
}
