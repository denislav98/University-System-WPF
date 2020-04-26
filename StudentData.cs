using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {

        static private List<Student> students;

        public static List<Student> getAllStudents()
        {
            students = new List<Student>();

            students.Add(new Student(1, "Ivan", "Ivanov", "Ivanov", "FKSU", "KSI", "bachelor", Status.CERTIFIED, "121217033", 3, 9, 36));
            students.Add(new Student(2, "Dragan", "Draganov", "Ivanov", "FKSU", "KSI", "bachelor", Status.CERTIFIED, "1212234567", 3, 9, 36));

            return students;
        }
        public static Student IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();
            return (from st in context.Students
                    where st.FacultyNumber == facNum
                    select st).First();
        }
    }
}