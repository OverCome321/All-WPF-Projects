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
using ClassLibrary1;

namespace Project_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Project9 pr = new Project9();
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Format_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pr.somestring = Name.Text;
                pr.FormatSomeString();
                switch (TypeOfSource.SelectedIndex)
                {
                    case 0:
                        MainLabel.Content = "";
                        MainLabel.Content = $"Отформатированная строка: {pr.somestring}\nСтрока с изменениями в зависимости от исчтоника: Изменений нет!";
                        break;
                    case 1:
                        MainLabel.Content = "";
                        MainLabel.Content =  $"Отформатированная строка: {pr.somestring}\nСтрока с изменениями в зависимости от исчтоника: {pr.CursedSource()}";
                        break;
                    case 2:
                        MainLabel.Content = "";
                        MainLabel.Content = $"Отформатированная строка: {pr.somestring}\nСтрока с изменениями в зависимости от исчтоника: {pr.EverSource()}";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("incorrect format", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 pw = new Window1();
            pw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 pw2 = new Window2();
            pw2.Show();
        }
    }
}
