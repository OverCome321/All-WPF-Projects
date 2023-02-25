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

namespace WpfApp2
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
            Power1.Text = "0";
            MaxUss.Text = "0";
            SILA.Maximum = power;
            PowerOfSourse.Text = "Введите день недели";
            Info.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
            PUT.IsEnabled = false;
            Give.IsEnabled = false;
            Power1.IsEnabled = false;
            Foreach.IsEnabled = false;
            MaxUss.IsEnabled = false;
            Info.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SILA.Value == 0 || MaxUss.Text == Convert.ToString(0) || Power1.Text == Convert.ToString(0))
            {
                MessageBox.Show("Заполните источник", "Упс!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {


                sos.damage = Convert.ToInt32(Power1.Text);
                int bonus = 20;
                sos.damage += bonus;
                Power1.Text = sos.damage.ToString();
                SILA.Value -= bonus;

                sos.maxUss--;
                sos.nowUss++;
                Info.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";

                string sign = Convert.ToString(Math.Sign(sos.maxUss));
                //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
                //enb = Convert.ToBoolean(sign.Replace("0", "false"));
                bool enb;
                sign = sign.Replace("1", "true");
                sign = sign.Replace("0", "false");
                enb = Convert.ToBoolean(sign);
                Power1.IsEnabled = enb;
                Info.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sos.maxUss == 0)
            {
                Info.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
                Power1.IsEnabled = true;
                SILA.Value += 100;
            }
            else
            {
                SILA.Value += 100;
                Info.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PowerOfSourse.Text == "Понедельник" || PowerOfSourse.Text == "Вторник" || PowerOfSourse.Text == "Среда" || PowerOfSourse.Text == "Четверг" || PowerOfSourse.Text == "Пятница" || PowerOfSourse.Text == "понедельник" || PowerOfSourse.Text == "вторник" || PowerOfSourse.Text == "среда" || PowerOfSourse.Text == "четверг" || PowerOfSourse.Text == "чятница")
                {
                    MessageBox.Show("Ура ты выбрал верную дату!", "Поздравляю", MessageBoxButton.OK, MessageBoxImage.None);
                    PUT.IsEnabled = true;
                    Give.IsEnabled = true;
                    Power1.IsEnabled = true;
                    Foreach.IsEnabled = true;
                    MaxUss.IsEnabled = true;
                    Info.Visibility = Visibility.Hidden;
                    PowerOfSourse.IsEnabled = false;
                }    
            }
            catch
            {
                MessageBox.Show("Такое вводить нельзя!, введите другую дату", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                PowerOfSourse.Text = Convert.ToString("Попробую еще раз");
                Info.Visibility = Visibility.Hidden;
            }
            finally
            {
                if (PowerOfSourse.Text == "Воскресенье" || PowerOfSourse.Text == "Суббота" || PowerOfSourse.Text == "воскресенье" || PowerOfSourse.Text == "суббота")
                {
                    MessageBox.Show("У источника выходной, введите другую дату", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    PowerOfSourse.Text = Convert.ToString("Попробую еще раз");
                    Info.Visibility = Visibility.Hidden;
                }    
            }
        }

        private void MaxUss_TextChanged(object sender, TextChangedEventArgs e)
        {
            sos.maxUss = Convert.ToInt32(MaxUss.Text);
        }

        private void Foreach_Click(object sender, RoutedEventArgs e)
        {
            Info.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PowerOfSourse.Text = "Введите день недели";
            Info.Content = $"Оставшееся количество использований: {sos.maxUss = 0} Использовано: {sos.nowUss = 0} раз";
            MaxUss.Text = Convert.ToString(0);
            Power1.Text = Convert.ToString(0);
            PUT.IsEnabled = false;
            Give.IsEnabled = false;
            Power1.IsEnabled = false;
            MaxUss.IsEnabled = false;
            PowerOfSourse.IsEnabled = true;
        }
    }
}
