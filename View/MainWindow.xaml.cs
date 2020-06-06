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
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentInfoContext context;
        public MainWindow()
        {
            InitializeComponent();
            //Title = "Студентска информационна система";
            //FillStudStatusChoices();
            DataContext = this;
            context = new StudentInfoContext();
        }
        public List<string> StudStatusChoices { get; set; }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }
        public bool TestStudentsIfEmpty()
        {
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();
            return countStudents == 0;
        }

        public void CopyTestStudents()
        {
            foreach (Student st in getAllStudents())
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
        }

        private List<Student> getAllStudents()
        {
            return context.Students.ToList();
        }

        private void isEmptyStudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            bool isEmpty = TestStudentsIfEmpty();
            if (isEmpty)
            {
                CopyTestStudents();
                MessageBox.Show("Students added successfully");
            }
            else
            {
                MessageBox.Show(isEmpty.ToString());

            }
        }

        /*   public void FillStudentDataIntoFields(Student student)
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
           }*/
    }
}
