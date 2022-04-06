using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
   public class PrivateEmployeeDetail
    {
        string _employeeName;
        string _employeeAddress;
        long _mobileNumber;
        string _personalEmailId;
        int _idProofNumber;
        DateTime _dateOfBirth;
        int _age;
        string _learningInstitution;
        string _martialStatus;
        string _jobTittle;
        int _employeeId;
        string _department;
        string _supervisor;
        string _officeEmployeeEmailId;
        DateTime _dateOfJoining;
        int _salary;

       
       public string EmployeeName
       {
           get { return _employeeName; }
           set { _employeeName = value; }
       }
       public string EmployeeAddress
       {
           get { return _employeeAddress; }
           set { _employeeAddress = value; }
       }
       public long MobileNumber
       {
           get { return _mobileNumber; }
           set { _mobileNumber = value; }
       }

       public string PersonalEmailId
       {
           get { return _personalEmailId; }
           set { _personalEmailId = value; }
       }

       public int IdProofNumber
       {
           get { return _idProofNumber; }
           set { _idProofNumber = value; }
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
               if (value>=24&&value<=70)
               {
                   _age = value;
               }
               else
               {
                   throw new ArgumentException("Age limit is not in limit");
               }
           }
       }

       public string LearningInstitution
       {
           get { return _learningInstitution; }
           set { _learningInstitution = value; }
       }

       public string MartialStatus
       {
           get { return _martialStatus; }
           set { _martialStatus = value; }
       }

       public string JobTittle
       {
           get { return _jobTittle; }
           set { _jobTittle = value; }
       }

       public int EmployeeId
       {
           get { return _employeeId; }
           
       }

       public string Department
       {
           get { return _department; }
           set { _department = value; }
       }

       public string Supervisor
       {
           get { return _supervisor; }
           set { _supervisor = value; }
       }
       public string OfficeEmployeeEmailId
       {
           get { return _officeEmployeeEmailId; }
           set { _officeEmployeeEmailId = value; }
       }
       public DateTime DateOfJoining
       {
           get { return _dateOfJoining; }
          
       }
       public int Salary
       {
           get { return _salary; }
           set { _salary = value; }
       }


       public PrivateEmployeeDetail(string empName,string empAddress,long mobNumber,string personalEmailid,int idProof,DateTime dob,string institution,
           string martialStatus,string jobTittle,int empId,string department,string supervisor,string empEmailId,DateTime doj,int salary)
       {
           EmployeeName = empName;
           EmployeeAddress = empAddress;
           MobileNumber = mobNumber;
           PersonalEmailId = personalEmailid;
           this._idProofNumber = idProof;
           DateOfBirth = dob;
           Age = DateTime.Now.Subtract(_dateOfBirth).Days / 365;
           LearningInstitution = institution;
           MartialStatus = martialStatus;
           JobTittle = jobTittle;
           this._employeeId = empId;
           Department = department;
           Supervisor = supervisor;
           OfficeEmployeeEmailId = empEmailId;
           this._dateOfJoining = doj;
           Salary = salary;


       }


     
    }
}
