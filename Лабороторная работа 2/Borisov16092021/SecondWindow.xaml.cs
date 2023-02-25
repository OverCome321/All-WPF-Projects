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

namespace Gutnov232
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Go_to_window1_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Red_Button_Click(object sender, RoutedEventArgs e)
        {
            Red_Circle.Fill = Brushes.Red;
            Yellow_Circle.Fill = Brushes.White;
            Green_Circle.Fill = Brushes.White;
        }

        private void Yellow_Button_Click(object sender, RoutedEventArgs e)
        {
            Red_Circle.Fill = Brushes.White;
            Yellow_Circle.Fill = Brushes.Yellow;
            Green_Circle.Fill = Brushes.White;
        }

        private void Green_Button_Click(object sender, RoutedEventArgs e)
        {
            Red_Circle.Fill = Brushes.White;
            Yellow_Circle.Fill = Brushes.White;
            Green_Circle.Fill = Brushes.Green;
        }

        private void Go_to_window3_Button_Click(object sender, RoutedEventArgs e)
        {
            ThirdWindow tw = new ThirdWindow();
            tw.Show();
            this.Close();
        }
    }
}
