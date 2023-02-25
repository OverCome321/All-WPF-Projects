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

namespace WpfApp54
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double sum1 = 0;
        int damage1 = 0;
        int damage2 = 0;
        double sum2 = 0;
        int hp1 = 0;
        int hp2 = 0;
        int heals1 = 0;
        int heals2 = 0;
        int lives1 = 0;
        int lives2 = 0;
        public MainWindow()
        {
            InitializeComponent();
            MainFraim.Content = new Page1(damage1, sum1, damage2, sum2,hp1,hp2,heals1,heals2,lives1,lives2);
        }


    }
}
