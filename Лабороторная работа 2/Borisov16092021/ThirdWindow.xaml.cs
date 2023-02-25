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
    /// Логика взаимодействия для ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }

        private static readonly Random random = new Random();

        private void Click_Button_Click(object sender, RoutedEventArgs e)
        {
            Click_Button.Margin = new Thickness(random.Next(0, 640), random.Next(0, 360), 0, 0);


        }


        private void Go_to_window2_Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow sw = new SecondWindow();
            sw.Show();
            this.Close();
        }

        private void Go_to_window1_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
