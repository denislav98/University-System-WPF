using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
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
        public string SecondName
        {
            get { return _SecondName; }
            set { _SecondName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Faculty
        {
            get { return _Faculty; }
            set { _Faculty = value; }
        }
        public string Speciality
        {
            get { return _Speciality; }
            set { _Speciality = value; }
        }
        public string QualificatioDegree
        {
            get { return _QualificatioDegree; }
            set { _QualificatioDegree = value; }
        }
        public Status Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string FacultyNumber
        {
            get { return _FacultyNumber; }
            set { _FacultyNumber = value; }
        }
        public int Course
        {
            get { return _Course; }
            set { _Course = value; }
        }
        public int Run
        {
            get { return _Run; }
            set { _Run = value; }
        }
        public int Group
        {
            get { return _Group; }
            set { _Group = value; }
        }
        
    }
}
