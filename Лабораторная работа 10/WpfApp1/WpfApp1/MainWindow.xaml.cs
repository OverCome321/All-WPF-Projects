using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Searching.Text = "Введите данные в строку";
           
        }

        private void Searching_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = Searching.Text.ToLower();
            Regex r = new Regex(@"^[авеклмнорстух]{1}[0-9]{3}[авекмлнорстух]{2}[0-9]{2,3}$");
            if (r.IsMatch(s))
            {
                MessageBox.Show("Все подошло!", "Ура!", MessageBoxButton.OK, MessageBoxImage.Information);
                Result.Content = "Все подошло! Ура!";
            }
            else
            {
                Result.Content = "";
                MessageBox.Show("Упс, ошибочка ничего не подошло", "Не подошло!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
