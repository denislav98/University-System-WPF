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
using System.Windows.Shapes;
using UserLoginn;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        public static void ShowActionErrorMessage(string errorMsg)
        {
            Console.WriteLine("!!! " + errorMsg + " !!!");
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Password;
            LoginValidation validation = new LoginValidation(username,password,ShowActionErrorMessage);
            User user = new User();
            if (validation.ValidateUserInput(ref user))
            {
                /*  Student student = StudentValidation.GetStudentDataByFacultyNumber(user);
                  if(student == null)
                  {
                      resetInputFields();
                      return;
                  }
                  MainWindow anotherWindow = new MainWindow();
                  anotherWindow.FillStudentDataIntoFields(student);
                  anotherWindow.Show();
                  Close();*/
                Student student = StudentValidation.GetStudentDataByFacultyNumber(user);
                MainWindow mainWindow = new MainWindow();
                MainWindowViewModel vm = new MainWindowViewModel(student, mainWindow);
                mainWindow.DataContext = vm;
                mainWindow.Show();
                Close();
            }
            else
            {
                resetInputFields();
            }

        }

        private void resetInputFields()
        {
            MessageBox.Show("Invalid credentials entred !");
            TextBox usernameBox = usernameTxtBox;
            usernameBox.Clear();
            PasswordBox passwordBox = passwordTxtBox;
            passwordBox.Clear();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
