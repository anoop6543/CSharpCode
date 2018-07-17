using System.Windows;
using System.Windows.Input;
using System;
using System.Windows.Threading;

namespace sampleaapplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        window2 testwin = new window2();

        public MainWindow()
        {
            InitializeComponent();
            //+textBox1.Focus();
            FocusManager.SetFocusedElement(windows,textBox1);
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            testwin.Close();
            timer.Stop();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "HAHAHAHHAHAA";
           
            testwin = new window2();


            testwin.Show();
            timer.Start();
        }
    }
}
