using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using StudentInfoSystem;
using UserLoginn;

namespace StudentInfoSystem
{
    class MainWindowViewModel : ObservableBase
    {
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set { _student = value; RaisePropertyChangedEvent("Student"); }
        }

        private bool _canEditProperty = true;
        public bool CanEditProperty
        {
            get { return _canEditProperty; }
            set { _canEditProperty = value; RaisePropertyChangedEvent("CanEditProperty"); }
        }

        public MainWindowViewModel(Student student, MainWindow main)
        {
            if (student == null)
            {
                student = new Student();
                main = new MainWindow();
            }
            Student = student;
            LoadStudentData(main);
        }

        public ICommand LoadStudentDataCommand
        {
            get { return new RelayCommand(LoadStudentData); }
        }

        private void LoadStudentData(MainWindow main)
        {
            main.nameTxtBox.Text = Student.FirstName;
            main.secondNameTxtBox.Text = Student.SecondName;
            main.lastNameTextBox.Text = Student.LastName;
            main.facultyTextBox.Text = Student.Faculty;
            main.specialityTxtBox.Text = Student.Speciality;
            main.OKSTxtBox.Text = Student.QualificatioDegree;
            main.statusTxtBox.ItemsSource = main.StudStatusChoices;
            main.courseTxtBox.Text = Student.Course.ToString();
            main.runTxtBox.Text = Student.Run.ToString();
            main.groupTxtBox.Text = Student.Group.ToString();
            main.facultyNumberTxtBox.Text = Student.FacultyNumber.ToString();
        }

        public ICommand ClearStudentDataCommand
        {
            get { return new RelayCommand(ClearStudentData); }
        }

        private void ClearStudentData()
        {
            Student = new Student();
        }

        public ICommand DeactivateEditingCommand
        {
            get { return new RelayCommand(DeactivateEditing); }
        }

        private void DeactivateEditing()
        {
            CanEditProperty = false;
        }

        public ICommand ActivateEditingCommand
        {
            get { return new RelayCommand(ActivateEditing); }
        }

        private void ActivateEditing()
        {
            CanEditProperty = true;
        }
    }
}