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

namespace Gutnov232
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DontClick_Button_Click(object sender, RoutedEventArgs e)
        {
            GreetingTB.Text = "Написано же – не нажимать!";
            DontClick_Button.Visibility = Visibility.Hidden;
        }

        private void Go_to_window2_Button_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow sw = new SecondWindow();
            sw.Show();
            this.Close();
        }

        private void Go_to_window3_Button_Click(object sender, RoutedEventArgs e)
        {
            ThirdWindow tw = new ThirdWindow();
            tw.Show();
            this.Close();
        }
    }
}
