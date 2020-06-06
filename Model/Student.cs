using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string QualificatioDegree { get; set; }
        public Status Status { get; set; }
        public string FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Run { get; set; }
        public int Group { get; set; }
        public List<DisciplineGrade> DisciplineGrades { get; set; }

        public Student()
        {
            DisciplineGrades =   new List<DisciplineGrade>();
        }
        public Student(string firstName, string secondName, string lastName, string faculty, string speciality, string qualificatioDegree, Status status, string facultyNumber, int course, int run, int group,List<DisciplineGrade> grades)
        {
            
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            QualificatioDegree = qualificatioDegree;
            Status = status;
            FacultyNumber = facultyNumber;
            Course = course;
            Run = run;
            Group = group;
            DisciplineGrades = grades;
        }

        /*  public string FirstName
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
          }*/
        public override string ToString() { return FirstName; }
    }
}
