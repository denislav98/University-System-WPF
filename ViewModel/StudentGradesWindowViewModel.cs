using StudentInfoSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    class StudentGradesWindowViewModel : ObservableBase
    {
        private Student _student;
        private bool _canEditProperty = true;

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
            LoadStudentGrades(gradesWindow);
        }

       /* public ICommand LoadStudentGradesComand
        {
            get { return new RelayCommand(LoadStudentGrades); }
        }*/

        private void LoadStudentGrades(StudentGradesWindow gradesWindow)
        {

        }
       

    }
}
