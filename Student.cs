using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        private string _FirstName;
        private string _SecondName;
        private string _LastName;
        private string _Faculty;
        private string _Speciality;
        private string _QualificatioDegree;
        private Status _Status;
        private string _FacultyNumber;
        private int _Course;
        private int _Run;
        private int _Group;

        public Student(string firstName, string secondName, string lastName, string faculty, string speciality, string qualificatioDegree, Status status, string facultyNumber, int course, int run, int group)
        {
            _FirstName = firstName;
            _SecondName = secondName;
            _LastName = lastName;
            _Faculty = faculty;
            _Speciality = speciality;
            _QualificatioDegree = qualificatioDegree;
            _Status = status;
            _FacultyNumber = facultyNumber;
            _Course = course;
            _Run = run;
            _Group = group;
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string FacultyNumber
        {
            get { return _FacultyNumber; }
            set { _FacultyNumber = value; }
        }
    }
}
