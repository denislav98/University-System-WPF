using StudentInfoSystem.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    class StudentGradesWindowViewModel : ObservableBase
    {
        private Student _student;
        private List<DisciplineGrade> _studentGrades;

        private StudentInfoContext context;
        private bool _canEditProperty = true;
       
        public List<DisciplineGrade> StudentGrades
        {
            get { return _studentGrades; }
            set { _studentGrades = value; RaisePropertyChangedEvent("DisciplineGrade"); }
        }
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
        public ICommand LoadStudentDataCommand
        {
            get { return new RelayCommand<StudentGradesWindow>(LoadStudentGrades); }
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

        public List<string> GetStudentFailedExams()
        {
            List<string> failedExamMessage = new List<string>();
            failedExamMessage.Add("Failed Exams :");
            foreach (DisciplineGrade grade in StudentGrades)
            {
                if(grade.Grade == 2)
                {
                    failedExamMessage.Add(grade.Discipline);
                }
            }

            return failedExamMessage;
        }

        public double CalculateStudentAverageGrade() 
        {
            double gradesCount = 0;

            foreach(DisciplineGrade grade in StudentGrades)
            {
                gradesCount += grade.Grade;
            }

            return gradesCount / StudentGrades.Count;
        }

        private void loadStudentDisciplineGradesFromDb()
        {
            StudentGrades = new List<DisciplineGrade>();

            StudentGrades = context.DisciplineGrades.Where(i => i.StudentId == Student.StudentId).ToList();
        }
        
        private void LoadStudentGrades(StudentGradesWindow gradesWindow)
        {
            loadStudentDisciplineGradesFromDb();

            for (int i = 0; i < StudentGrades.Count ; i++)
            {
                fillDisciplineTextBox(gradesWindow, i);
                fillGradeTextBox(gradesWindow, i);
                fillFormOfControlTextBox(gradesWindow, i);
                fillLastChangedControlTextBox(gradesWindow, i);
            }
            MessageBox.Show(StudentGrades.Count.ToString());
        }

        private void fillLastChangedControlTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string lastChanged = "LastChanged" + i;
            var lastChangedTextBox = (TextBlock)gradesWindow.FindName(lastChanged);
            string gradeLastChanged = StudentGrades[i].LastChanged.ToString();
            isTextBoxNull(gradeLastChanged, lastChangedTextBox);
        }

        private void fillFormOfControlTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string formOfControl = "FormOfControl" + i;
            var formOfControlTextBox = (TextBlock)gradesWindow.FindName(formOfControl);
            string gradeFormOfControl = StudentGrades[i].FormOfControl.ToString();
            isTextBoxNull(gradeFormOfControl, formOfControlTextBox);
        }

        private void fillGradeTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string grade = "Grade" + i;
            var gradeTextBox = (TextBlock)gradesWindow.FindName(grade);
            string disciplineGrade = StudentGrades[i].Grade.ToString();
            isTextBoxNull(disciplineGrade, gradeTextBox);
        }

        private void fillDisciplineTextBox(StudentGradesWindow gradesWindow, int i)
        {
            string discipline = "Discipline" + i;
            var disciplineTextBloc = (TextBlock)gradesWindow.FindName(discipline);
            string gradeDiscipline = StudentGrades[i].Discipline;
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
