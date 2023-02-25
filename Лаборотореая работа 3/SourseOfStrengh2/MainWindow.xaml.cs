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

namespace SourseOfStrengh2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SourseOfStrengh sos = new SourseOfStrengh();
        public int power = 100;
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            sos.nowUss = 0;
            int power = 100;
            TBPlusDamage.Text = "0";
            PowerOfSourse.Text = "0";
            PBSource.Maximum = power;
            Safe.Visibility = Visibility.Hidden;
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
        }

        private void GiveBT_Click(object sender, RoutedEventArgs e)
        {
            
            if (TBPlusDamage.Text == Convert.ToString(0) || PowerOfSourse.Text == Convert.ToString(0))
            {
                MessageBox.Show("Ошибочка", "Введите данные", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                PlusToDamage.IsEnabled = true;
                PowerOfSourse.IsEnabled = true;
                TBPlusDamage.IsEnabled = true;
                PBSource.Value += 100;
                UseSourse.Visibility = Visibility.Hidden;
                PlusToDamage.IsEnabled = true;
                sos.maxUss += 0;
                
            }

        }

        private void PlusToDamage_Click(object sender, RoutedEventArgs e)
        {
            if (TBPlusDamage.Text == Convert.ToString(0) || PowerOfSourse.Text == Convert.ToString(0))
            {
                MessageBox.Show("Ошибочка", "Введите данные", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                sos.maxUss--;
                sos.nowUss++;
                sos.damage = Convert.ToInt32(TBPlusDamage.Text);
                int bonus = 20;
                sos.damage += bonus;
                TBPlusDamage.Text = sos.damage.ToString();
                PBSource.Value -= bonus;
                UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
                if (sos.maxUss == 0)
                {
                    PlusToDamage.IsEnabled = false;
                    PowerOfSourse.IsEnabled = false;
                    TBPlusDamage.IsEnabled = false;
                    Safe.Visibility = Visibility.Visible;
                    GiveBT.Visibility = Visibility.Hidden;

                }
                if (PBSource.Value == 0)
                {
                    PlusToDamage.IsEnabled = false;
                }
            }
        }

        private void InfoBTN_Click(object sender, RoutedEventArgs e)
        {
            UseSourse.Visibility = Visibility.Visible;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sos.maxUss = Convert.ToInt32(PowerOfSourse.Text);
        }

        private void PBSource_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void TBPlusDamage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sos.nowUss = 0;
            PowerOfSourse.Text = Convert.ToString(0);
            PBSource.Value = 0;
            TBPlusDamage.Text = Convert.ToString(0);
            sos.maxUss = 0;
            UseSourse.Visibility = Visibility.Hidden;
            PlusToDamage.IsEnabled = true;
            TBPlusDamage.IsEnabled = true;
            PowerOfSourse.IsEnabled = true;
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss = 0} Использовано: {sos.nowUss = 0} раз";
        }

        private void Safe_Click(object sender, RoutedEventArgs e)
        {
            PlusToDamage.IsEnabled = true;
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
            Safe.Visibility = Visibility.Hidden;
            TBPlusDamage.IsEnabled = true;
            PowerOfSourse.IsEnabled = true;
            GiveBT.Visibility = Visibility.Visible;
            UseSourse.Visibility = Visibility.Hidden;
        }
    }
}
