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

namespace GameOfTowers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFraim.Content = new MainPage(); // Это команда позволяет при запуске программы показывать нам страницу MainPage сразу же, ну если обычным языком то в самом начале у нас нет ничего кроме пустого белого экрана MainWindow, а эта команда позволит после запуска приложения сразу же на место MainWindow поместить страницу MainPage
        }
    }
}
