using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class StudentDetailCentre
    {
        string _studentName;
        int _batchNo;
        string _courseName;
        int _feesPaid;
        int _feesPending;
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        

        public int BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
        

        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        

        public int FeesPaid
        {
            get { return _feesPaid; }
            set { _feesPaid = value; }
        }
        

        public int FeesPending
        {
            get { return _feesPending; }
            set { _feesPending = value; }
        }

        public StudentDetailCentre(string Name,int batchNo,string courseName,int feesPaid,int feesPending)
        {
            StudentName = Name;
            BatchNo = batchNo;
            CourseName = courseName;
            FeesPaid = feesPaid;
            FeesPending = feesPending;
        }
    }
}
