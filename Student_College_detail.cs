using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class Student_College_detail
    {
        int _admissionNo;
        int _rollNo;
        long _registerNo;
        DateTime _dateOfJoining;
        string _studentName;
        DateTime _dateOfBirth;
        int _age;
        string _gender;
        string _degree;
        string _majorGroup;
        string _studentClass;
        char _classSection;
        string _address;
        string _martialStatus;
        string _fatherName;
        string _motherName;
        long _studentContactNo;
        string _studentEmailId;
        long _fatherContactNo;
        long _motherContactNo;

        


        public string AdmissionNo
        {
            get { return Convert.ToString(_admissionNo); }  
        }

        public string RollNo
        {
            get { return Convert.ToString(_rollNo); }
        }

        public string RegisterNo
        {
            get { return Convert.ToString(_registerNo); }
        }

        public string DateOfJoining
        {
            get { return Convert.ToString(_dateOfJoining); }
        }

        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }

        public DateTime DateOfBirth
        {
            set { _dateOfBirth = value; }
        }

        public string Age
        {
            get { return Convert.ToString(_age); }
            set
            {
                if (Convert.ToInt32(value) >= 18 && Convert.ToInt32(value) <= 60)
                {
                    _age = Convert.ToInt32(value);
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }

        public string Gender
        {
            get { return _gender; }
           
        }

        public string Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }
        public string MajorGroup
        {
            get { return _majorGroup; }
            set { _majorGroup = value; }
        }
        public string StudentClass
        {
            get { return _studentClass; }
            set { _studentClass = value; }
        }
        public char ClassSection
        {
            get { return _classSection; }
            set { _classSection = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string MartialStatus
        {
            get { return _martialStatus; }
            set { _martialStatus = value; }
        }
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }
        public string MotherName
        {
            get { return _motherName; }
            set { _motherName = value; }
        }
        public string StudentContactNo
        {
            get { return Convert.ToString(_studentContactNo); }
            set { _studentContactNo =Convert.ToInt64( value); }
        }
        public string StudentEmailId
        {
            get { return _studentEmailId; }
            set { _studentEmailId = value; }
        }
        public string FatherContactNo
        {
            get { return Convert.ToString(_fatherContactNo); }
            set { _fatherContactNo = Convert.ToInt64(value); }
        }
        public string MotherContactNo
        {
            get { return Convert.ToString(_motherContactNo); }
            set { _motherContactNo = Convert.ToInt64(value); }
        }

        public Student_College_detail(int admissionNo,int rollNo,long registerNo,DateTime dateOfJoining,string studentName,DateTime dateOfBirth,string gender,
            string degree,string majorGroup,string studentClass,char classSection,string address,string martialStatus,string fatherName,string motherName,
            long studentContactNo,string studentMailId,long fatherContactNo,long motherContactNo)
        {
            this._admissionNo = admissionNo;
            this._rollNo = rollNo;
            this._registerNo = registerNo;
            this._dateOfJoining = dateOfJoining;
            StudentName = studentName;
            Age = Convert.ToString(DateTime.Now.Subtract(dateOfBirth).Days / 365);
            this._gender = gender;
            //int s = 1 ;
            //state c = (state)s;
            Degree = degree;
            MajorGroup = majorGroup;
            StudentClass = studentClass;
            ClassSection = classSection;
            Address = address;
            MartialStatus = martialStatus;
            FatherName = fatherName;
            MotherName = motherName;
            StudentContactNo = Convert.ToString(studentContactNo);
            StudentEmailId = studentMailId;
            FatherContactNo = Convert.ToString(fatherContactNo);
            MotherContactNo = Convert.ToString(motherContactNo);

        }
       
    }
    public enum state
    {
        male=1,
        female=2,
        others=3
    }
    public enum status
    {
        single=1,
        married=2
    }
}
