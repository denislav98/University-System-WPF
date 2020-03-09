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
        public Student GetStudentDataByUser(User user)
        {
            Student student = StudentData.TestStudent;
            if (string.IsNullOrEmpty(user.FacultyNumber))
            {
                Logger.LogActivity("Missing faculty number!");
            }

            if (student.FacultyNumber != user.FacultyNumber)
            {
                Logger.LogActivity("No such Student exists!");
            }

            return student;
        }
    }
}