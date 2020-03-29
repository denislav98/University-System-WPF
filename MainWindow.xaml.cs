using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Студентска информационна система";
        }

        public void FillStudentDataIntoFields(Student student)
        {
            nameTxtBox.Text = student.FirstName;
            secondNameTxtBox.Text = student.SecondName;
            lastNameTextBox.Text = student.LastName;
            facultyTextBox.Text = student.Faculty;
            specialityTxtBox.Text = student.Speciality;
            OKSTxtBox.Text = student.QualificatioDegree;
            statusTxtBox.Text = student.Status.ToString();
            courseTxtBox.Text = student.Course.ToString();
            runTxtBox.Text = student.Run.ToString();
            groupTxtBox.Text = student.Group.ToString();
            facultyNumberTxtBox.Text = student.FacultyNumber.ToString();
        }

        private void resetFields(object sender, RoutedEventArgs e)
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Clear();
                }
            }
        }

        private void disableAllControlls(object sender, RoutedEventArgs e)
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.IsEnabled = false;
                }
            }
        }

        private void enableAllControlls(object sender, RoutedEventArgs e)
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.IsEnabled = true;
                }
            }
        }
    }
}
