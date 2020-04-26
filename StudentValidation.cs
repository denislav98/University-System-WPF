using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginn;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public static Student GetStudentDataByFacultyNumber(User user)
        {
            return StudentData.IsThereStudent(user.FacultyNumber);
            /*List<Student> students = StudentData.getAllStudents();
            return students.Find(s => s.FacultyNumber.Equals(user.FacultyNumber)); */
        }
    }
}