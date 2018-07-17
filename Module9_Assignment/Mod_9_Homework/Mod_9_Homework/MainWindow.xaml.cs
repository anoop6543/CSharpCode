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

namespace Mod_9_Homework
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student> Students = new List<Student>();
        int i = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student_temp = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            Students.Add(student_temp);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (i < Students.Count && i >= 0)
            {
                txtFirstName.Text = Students[i].first_Name;
                txtLastName.Text = Students[i].last_Name;
                txtCity.Text = Students[i].city;
                i = i + 1;
            }
            else
            {
                i = 0;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (i < (Students.Count) && i > 0)
            {
                txtFirstName.Text = Students[i].first_Name;
                txtLastName.Text = Students[i].last_Name;
                txtCity.Text = Students[i].city;
                 i = i - 1;
            }
            else
            {
                i = Students.Count - 1;
            }
        }
    }
}
