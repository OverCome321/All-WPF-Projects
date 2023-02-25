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
using System.IO;
using ClassLibrary1;
namespace Project11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileReader fr = new FileReader();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtString_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (CbString.SelectedIndex)
                {
                    case 0:
                        MainLabel.Content = "";
                        MainLabel.Content = fr.DefoltReader();
                        break;
                    case 1:
                        MainLabel.Content = "";
                        MainLabel.Content = fr.CursedReader();
                        break;
                    case 2:
                        MainLabel.Content = "";
                        MainLabel.Content = fr.EverReader();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Файл изменен и попробуйте заново!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LearFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainLabel.Content = "";
                MainLabel.Content = $"{fr.JustReadFile()}";
            }
            catch
            {
                MessageBox.Show("Файл изменен и попробуйте заново!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string stroka = MainLabel.Content.ToString();
                fr.WriteInFile(stroka);
            }
            catch
            {
                MessageBox.Show("Файл изменен и попробуйте заново!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
