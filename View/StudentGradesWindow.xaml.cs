using StudentInfoSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentInfoSystem.View
{
    /// <summary>
    /// Interaction logic for StudentGradesWindow.xaml
    /// </summary>
    public partial class StudentGradesWindow : Window
    {
         
        public StudentGradesWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void showStudentAverageGradeButtonClick(object sender, RoutedEventArgs e)
        {
            StudentGradesWindowViewModel viewModel = ((StudentGradesWindowViewModel)DataContext);
            double averageStudentGrade = viewModel.CalculateStudentAverageGrade();
            MessageBox.Show("Your average grade is : " + Math.Round(averageStudentGrade, 2).ToString());
        }

        private void showFailedStudenExamsButtonClick(object sender, RoutedEventArgs e)
        {
            StudentGradesWindowViewModel viewModel = ((StudentGradesWindowViewModel)DataContext);
            List<string> failedExams = viewModel.GetStudentFailedExams();
            var message = string.Join(Environment.NewLine, failedExams);
            MessageBox.Show(message);
        }
    }
}
