﻿using System;
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
        }

        public static void InsertIntoStudentData()
        {
            StudentData.insertIntoStudentAndGrades();
        }
    }
}