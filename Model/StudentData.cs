using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace StudentInfoSystem
{
    class StudentData
    {

        static private List<Student> students;


        public static List<Student> getAllStudents(StudentInfoContext context)
        {
            students = new List<Student>();
            List<DisciplineGrade> grades = setAllDisciplineGrades(context);
            students.Add(new Student("Ivan", "Ivanov", "Ivanov", "FKSU", "KSI", "bachelor", Status.CERTIFIED, "121217033", 3, 9, 36, grades));
            // students.Add(new Student(2, "Dragan", "Draganov", "Ivanov", "FKSU", "KSI", "bachelor", Status.CERTIFIED, "1212234567", 3, 9, 36, grades));

            return students;
        }

        public static List<DisciplineGrade> setAllDisciplineGrades(StudentInfoContext context)
        {
            List<DisciplineGrade> grades = new List<DisciplineGrade>();
            grades.Add(new DisciplineGrade("English 1", FormOfControl.NOT_AVAILABLE, 6, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("Mathematics 1", FormOfControl.EXAM, 5, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("Iconomics", FormOfControl.ONGOING_ASSESSMENT, 4, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("OIP", FormOfControl.ONGOING_ASSESSMENT, 3, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("Programing C", FormOfControl.EXAM, 6, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("Fizics", FormOfControl.EXAM, 6, DateTime.Now,1,1));
            grades.Add(new DisciplineGrade("Chemistry", FormOfControl.ONGOING_ASSESSMENT, 6, DateTime.Now,1,1));

            
            foreach(DisciplineGrade grade in grades)
            {
                context.DisciplineGrades.Add(grade);
            }

            return grades;
        }

        public static void insertIntoStudentAndGrades()
        {
            StudentInfoContext context = new StudentInfoContext();
            
            foreach (Student student in getAllStudents(context))
            {
                context.Students.Add(student);
            }
            context.SaveChanges();

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