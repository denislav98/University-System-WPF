using StudentInfoSystem.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    class StudentGradesWindowViewModel : ObservableBase
    {
        private Student _student;
        private bool _canEditProperty = true;
        private StudentInfoContext context;
        public Student Student
        {
            get { return _student; }
            set { _student = value; RaisePropertyChangedEvent("Student"); }
        }
        public bool CanEditProperty
        {
            get { return _canEditProperty; }
            set { _canEditProperty = value; RaisePropertyChangedEvent("CanEditProperty"); }
        }

        public StudentGradesWindowViewModel(Student student, StudentGradesWindow gradesWindow)
        {
            if (student == null)
            {
                student = new Student();
                gradesWindow = new StudentGradesWindow();
            }
            Student = student;
            context = new StudentInfoContext();
            LoadStudentGrades(gradesWindow);
        }
        public List<DisciplineGrade> StudentDisciplineGrades { get; set; }

        private void loadStudentDisciplineGradesFromDb()
        {
            StudentDisciplineGrades = new List<DisciplineGrade>();

            StudentDisciplineGrades = context.DisciplineGrades.Where(i => i.StudentId == Student.StudentId).ToList();
        }

        /* public ICommand LoadStudentGradesComand
         {
             get { return new RelayCommand(LoadStudentGrades); }
         }*/

        private void LoadStudentGrades(StudentGradesWindow gradesWindow)
        {
            loadStudentDisciplineGradesFromDb();

            for (int i = 0; i < StudentDisciplineGrades.Count; i++)
            {
                fillDisciplineTextBox(gradesWindow, i);
                fillGradeTextBox(gradesWindow, i);
                fillFormOfControlTextBox(gradesWindow, i);
                fillLastChangedControlTextBox(gradesWindow, i);
            }
        }

        private void fillLastChangedControlTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string lastChanged = "LastChanged" + i;
            var lastChangedTextBox = (TextBlock)gradesWindow.FindName(lastChanged);
            string gradeLastChanged = StudentDisciplineGrades[i].LastChanged.ToString();
            isTextBoxNull(gradeLastChanged, lastChangedTextBox);
        }

        private void fillFormOfControlTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string formOfControl = "FormOfControl" + i;
            var formOfControlTextBox = (TextBlock)gradesWindow.FindName(formOfControl);
            string gradeFormOfControl = StudentDisciplineGrades[i].FormOfControl.ToString();
            isTextBoxNull(gradeFormOfControl, formOfControlTextBox);
        }

        private void fillGradeTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string grade = "Grade" + i;
            var gradeTextBox = (TextBlock)gradesWindow.FindName(grade);
            string disciplineGrade = StudentDisciplineGrades[i].Grade.ToString();
            isTextBoxNull(disciplineGrade, gradeTextBox);
        }

        private void fillDisciplineTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string discipline = "Discipline" + i;
            var disciplineTextBloc = (TextBlock)gradesWindow.FindName(discipline);
            string gradeDiscipline = StudentDisciplineGrades[i].Discipline;
            isTextBoxNull(gradeDiscipline, disciplineTextBloc);
        }

        private void isTextBoxNull(string grade, TextBlock textBlock)
        {
            if (textBlock != null)
            {
                textBlock.Text = grade;
            }
        }
    }
}
