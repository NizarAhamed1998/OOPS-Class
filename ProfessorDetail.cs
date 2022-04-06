using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class ProfessorDetail
    {
        int _professorId;
        DateTime _dateOfJoining;
        string _professorName;
        DateTime _dateOfBirth;
        int _age;
        string _gender;
        string _address;
        long _contactNo;
        string _emailId;
        string _degree;
        string _major;
        int _teachingExperience;
        int _researchExperiance;
        string _jobRole;
        string _department;
        int _salary;


        public DateTime DateOfJoining
        {
            get { return _dateOfJoining; }
            set { _dateOfJoining = value; }
        }
        public int ProfessorId
        {
            get { return _professorId; }
            set { _professorId = value; }
        }
        public string ProfessorName
        {
            get { return _professorName; }
            set { _professorName = value; }
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
                if (value>=30)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("age before 30 is a lecturer not a professor");
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

        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }

        public string Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public string Major
        {
            get { return _major; }
            set { _major = value; }
        }

        public int TeachingExperience
        {
            get { return _teachingExperience; }
            set { _teachingExperience = value; }
        }

        public int ResearchExperiance
        {
            get { return _researchExperiance; }
            set { _researchExperiance = value; }
        }

        public string JobRole
        {
            get { return _jobRole; }
            set { _jobRole = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
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

        public ProfessorDetail(string profName,DateTime dob,string address,long contactNo,string emailId,string degree,string major,int teachingExperiance,
            int researchExperiance,string jobRole,string department,int salary,string gender)
        {
            ProfessorName = profName;
            DateOfBirth = dob;
            Age = DateTime.Now.Subtract(_dateOfBirth).Days / 365;
            Address = address;
            ContactNo = contactNo;
            EmailId = emailId;
            Degree = degree;
            Major = major;
            TeachingExperience = teachingExperiance;
            ResearchExperiance = researchExperiance;
            JobRole = jobRole;
            Department = department;
            Salary = salary;
            Gender = gender;
        }
    }
}
