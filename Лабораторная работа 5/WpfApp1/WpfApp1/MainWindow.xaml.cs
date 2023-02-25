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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SourseOfStrengh sos = new SourseOfStrengh();
        public int power = 100;
        public string date;
        Random r = new Random();
        public int s;
        public MainWindow()
        {
            InitializeComponent();
            sos.nowUss = 0;
            Something.Text = "0";
            Something.IsEnabled = false;
            int power = 100;
            UseSourse.Visibility = Visibility.Hidden;
            Damage12.Text = "0";
            PBSource.Maximum = power;
            PowerOfSourse1.Text = "0";
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
            InfoBTN.IsEnabled = false;
            PowerOfSourse1.IsEnabled = false;
            Damage12.IsEnabled = false;
            PlusToDamage.IsEnabled = false;
            GiveBT.Visibility = Visibility.Hidden;
        
        }

        private void GiveBT_Click(object sender, RoutedEventArgs e)
        {
            PBSource.Value += 100;
            UseSourse.Visibility = Visibility.Hidden;
            Information.IsEnabled = false;
            PlusToDamage.IsEnabled = true;
            if (sos.maxUss == 0)
            {
                UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
            }
        }

        private void PlusToDamage_Click(object sender, RoutedEventArgs e)
        {
            if (Damage12.Text == Convert.ToString(0) || PowerOfSourse1.Text == Convert.ToString(0) || Something.Text == Convert.ToString(0))
            {
                MessageBox.Show("Ошибочка", "Введите данные", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                sos.damage = Convert.ToInt32(Damage12.Text);
                int bonus = s;
                sos.damage += bonus;
                Damage12.Text = sos.damage.ToString();
                PBSource.Value -= bonus;
                sos.maxUss--;
                sos.nowUss++;
                UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
                string sign = Convert.ToString(Math.Sign(sos.maxUss));
                //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
                //enb = Convert.ToBoolean(sign.Replace("0", "false"));
                bool enb;
                sign = sign.Replace("1", "true");
                sign = sign.Replace("0", "false");
                enb = Convert.ToBoolean(sign);
                PlusToDamage.IsEnabled = enb;
                UseSourse.Visibility = Visibility.Hidden;
                if (PBSource.Value == 0)
                {
                    PlusToDamage.IsEnabled = false;
                }
                if (Damage12.Text == Convert.ToString(0) || PowerOfSourse1.Text == Convert.ToString(0))
                {
                    MessageBox.Show("Введите данные в поля", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UseSourse.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sos.maxUss = Convert.ToInt32(PowerOfSourse1.Text);
        }

        private void Damage12_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чтобы наполнить источник выберите дату", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Information.IsEnabled = false;
        }

        private void PowerOfSourse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double a;
                a = (Convert.ToDouble(Day.Text) + ((31 * Convert.ToDouble(Month.Text) / 12) + Convert.ToDouble(Year.Text) + (Convert.ToDouble(Year.Text) / 4) - (Convert.ToDouble(Year.Text) / 100) + (Convert.ToDouble(Year.Text) / 400))) % 7;
                switch (Math.Round(a))
                {
                    case 6:
                        MessageBox.Show("Воскресенье", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        InfoBTN.IsEnabled = false;
                        PowerOfSourse1.IsEnabled = false;
                        Damage12.IsEnabled = false;
                        PlusToDamage.IsEnabled = false;
                        GiveBT.Visibility = Visibility.Hidden;
                        Something.IsEnabled = false;
                        break;
                    case 0:
                        MessageBox.Show("Понедельник", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                       
                        Information.Visibility = Visibility.Hidden;
                        InfoBTN.IsEnabled = true;
                        PowerOfSourse1.IsEnabled = true;
                        Damage12.IsEnabled = true;
                        PlusToDamage.IsEnabled = true;
                        GiveBT.Visibility = Visibility.Visible;
                        Something.IsEnabled = true;
                        break;
                    case 1:
                        MessageBox.Show("Вторник", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        Information.Visibility = Visibility.Hidden;
                        InfoBTN.IsEnabled = true;
                        PowerOfSourse1.IsEnabled = true;
                        Damage12.IsEnabled = true;
                        PlusToDamage.IsEnabled = true;
                        GiveBT.Visibility = Visibility.Visible;
                        Something.IsEnabled = true;
                        break;
                    case 2:
                        MessageBox.Show("Среда", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        Information.Visibility = Visibility.Hidden;
                        InfoBTN.IsEnabled = true;
                        PowerOfSourse1.IsEnabled = true;
                        Damage12.IsEnabled = true;
                        PlusToDamage.IsEnabled = true;
                        GiveBT.Visibility = Visibility.Visible;
                        Something.IsEnabled = true;
                        break;
                    case 3:
                        MessageBox.Show("Четверг","День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        Information.Visibility = Visibility.Hidden;
                        InfoBTN.IsEnabled = true;
                        PowerOfSourse1.IsEnabled = true;
                        Damage12.IsEnabled = true;
                        PlusToDamage.IsEnabled = true;
                        GiveBT.Visibility = Visibility.Visible;
                        Something.IsEnabled = true;
                        break;
                    case 4:
                        MessageBox.Show("Пятница", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        Information.Visibility = Visibility.Hidden;
                        InfoBTN.IsEnabled = true;
                        PowerOfSourse1.IsEnabled = true;
                        Damage12.IsEnabled = true;
                        PlusToDamage.IsEnabled = true;
                        GiveBT.Visibility = Visibility.Visible;
                        Something.IsEnabled = true;
                        break;
                    case 5:
                        MessageBox.Show("Суббота", "День недели", MessageBoxButton.OK, MessageBoxImage.Information);
                        InfoBTN.IsEnabled = false;
                        PowerOfSourse1.IsEnabled = false;
                        Damage12.IsEnabled = false;
                        PlusToDamage.IsEnabled = false;
                        GiveBT.Visibility = Visibility.Hidden;
                        Something.IsEnabled = false;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ничего не получилось!", "Попробуй еще раз!", MessageBoxButton.OK, MessageBoxImage.None);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Something.IsEnabled = false;
            Day.Text = Convert.ToString(0);
            Month.Text = Convert.ToString(0);
            Year.Text = Convert.ToString(0);
            Something.Text = Convert.ToString(0);
            s = 0;
            PBSource.Value = 0;
            sos.nowUss = 0;
            PlusToDamage.IsEnabled = true;
            Damage12.Text = Convert.ToString(0);
            InfoBTN.IsEnabled = false;
            PowerOfSourse1.IsEnabled = false;
            Damage12.IsEnabled = false;
            PlusToDamage.IsEnabled = false;
            GiveBT.Visibility = Visibility.Hidden;
            Information.Visibility = Visibility.Visible;
            Information.IsEnabled = true;
            PowerOfSourse1.Text = Convert.ToString(0);
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            s = Convert.ToInt32(Something.Text);
        }
    }
}
