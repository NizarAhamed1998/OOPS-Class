using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class GovernmentEmployeeDetail
    {
        int _employeeCode;
        string _name;
        string _gender;
        DateTime _dateOfBirth;
        int _age;
        string _employeeDepartment;
        string _zone;
        string _division;
        string _employeeGroup;
        string _designation;
        string _category;

       
        public int EmployeeCode
        {
            get { return _employeeCode; }
            
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            
        }

        public DateTime DateOfBirth
        {
            set { _dateOfBirth = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string EmployeeDepartment
        {
            get { return _employeeDepartment; }
            set { _employeeDepartment = value; }
        }
        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }
        public string Division
        {
            get { return _division; }
            set { _division = value; }
        }
        public string EmployeeGroup
        {
            get { return _employeeGroup; }
            set { _employeeGroup = value; }
        }
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public GovernmentEmployeeDetail(int employeeCode,string employeeName,string gender,DateTime dateOfBirth,string department,string zone,string division,string employeeGroup,string designation,string category)
        {
            this._employeeCode = employeeCode;
            Name = employeeName;
            this._gender = gender;
            DateOfBirth = dateOfBirth;
            EmployeeDepartment = department;
            Zone = zone;
            Division = division;
            EmployeeGroup = employeeGroup;
            Designation = designation;
            Category = category;
        }
    }
}
