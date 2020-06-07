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
        private StudentInfoContext context;

        public StudentGradesWindow()
        {
            InitializeComponent();
            DataContext = this;
            context = new StudentInfoContext();
        }
       
    }
}
