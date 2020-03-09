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
            this.Title = "Студентска информационна система";
        }

        private void resetFields_Click(object sender, RoutedEventArgs e)
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

        private void showStudentDataButton_Click(object sender, RoutedEventArgs e)
        {
            /*Student student = new Student("Ivan", "Ivanov", "Ivanov", "FKSU", "bachelor", Status.CERTIFIED, "121217033", 3, 9, 36);
            nameTxtBox.Text = student.FirstName;
            secondNameTxtBox.Text = student.SecondName;
            lastNameTextBox.Text = student.LastName;
            facultyTextBox.Text = student.Faculty;
            spe*/


        }

        private void disableAllControlls_Click(object sender, RoutedEventArgs e)
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

        private void enableAllControllsBtn_Click(object sender, RoutedEventArgs e)
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
