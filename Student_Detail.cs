using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class Student_Detail
    {
       //properties field
        int _admission_no;
        DateTime _date_of_joining;
        int _roll_no;
        string _student_name;
        DateTime _date_of_birth;
        int _age;

       
        string _gender;
        string _address;
        int _student_class;
        char _class_section;
        string _father_name;
        string _mother_name;
        string _father_occupation;
        string _mother_occupation;
        long _father_contact_no;
        long _mother_contact_no;
        string _email_id;
        int _annualIncome;

        

        //encapsulate field

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 6 && value <= 17)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Date of birth is not in limit");
                }
            }
        }
        public int Admission_no
        {
            get { return _admission_no; }
            
        }
       

        public DateTime Date_of_joining
        {
            get { return _date_of_joining; }
           
        }
        

        public int Roll_no
        {
            get { return _roll_no; }
            
        }
       

        public string Student_name
        {
            get { return _student_name; }
            
        }
        

        public DateTime Date_of_birth
        {
            get { return _date_of_birth; }
            set { _date_of_birth = value; }
        }
        

        public string Gender
        {
            get { return _gender; }
            
        }
        

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        

        public int Student_class
        {
            get { return _student_class; }
            set { _student_class = value; }
        }
        

        public char Class_section
        {
            get { return _class_section; }
            set { _class_section = value; }
        }
        

        public string Father_name
        {
            get { return _father_name; }
            
        }
        

        public string Mother_name
        {
            get { return _mother_name; }
            
        }
        

        public string Father_occupation
        {
            get { return _father_occupation; }
            set { _father_occupation = value; }
        }
        

        public string Mother_occupation
        {
            get { return _mother_occupation; }
            set { _mother_occupation = value; }
        }
        

        public long Father_contact_no
        {
            get { return _father_contact_no; }
            set { _father_contact_no = value; }
        }
        

        public long Mother_contact_no
        {
            get { return _mother_contact_no; }
            set { _mother_contact_no = value; }
        }
        
        public string Email_id
        {
            get { return _email_id; }
            set { _email_id = value; }
        }
        
        
        //constructor
        public Student_Detail(int admission_no,string date_of_joining,int roll_no,string student_name,string date_of_birth,
                       string gender,string address,int student_class,char class_section,string father_name,string mother_name,
            string father_occupation,string mother_occupation,long father_contact_no,long mother_contact_no,string email_id)
        {
            this._admission_no = admission_no;
            this._date_of_joining = Convert.ToDateTime(date_of_joining);
            this._roll_no = roll_no;
            this._student_name = student_name;

            Age = DateTime.Now.Subtract(Convert.ToDateTime(date_of_birth)).Days / 365;
           
            this._gender = gender;
            this._address = address;
            this._student_class = student_class;
            this._class_section = class_section;
            this._father_name = father_name;
            this._mother_name = mother_name;
            this._father_occupation = father_occupation;
            this._mother_occupation = mother_occupation;
            this._father_contact_no = father_contact_no;
            this._mother_contact_no = mother_contact_no;
            this._email_id = email_id;
        }

       
        public override string ToString()
        {
            return "Admission_no" + this._admission_no + "\nDate_of_joining" + this._date_of_joining + "\nRollNo" + this._roll_no + "\nStudentName" + this._student_name + "\nAge" + this._age;
        }

    }
}
