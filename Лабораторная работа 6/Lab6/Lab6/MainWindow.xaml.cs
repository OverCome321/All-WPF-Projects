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

namespace Lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SourseOfStrengh sos = new SourseOfStrengh();
        public int power = 100;
        Random r = new Random();
        public int s;
        public MainWindow()
        {
            InitializeComponent();
            Thirt.Visibility = Visibility.Hidden;
            Second.Visibility = Visibility.Hidden;
            Some.Text = "0";
            sos.nowUss = 0;
            Speed.Visibility = Visibility.Hidden;
            Damage.Visibility = Visibility.Hidden;
            Defence.Visibility = Visibility.Hidden;
            int power = 100;
            PowerOfSourse.Maximum = power;
            Use.IsEnabled = false;
            Drink.IsEnabled = false;
            Image2.Visibility = Visibility.Hidden;
            Image3.Visibility = Visibility.Hidden;
            MessageBox.Show("Приветствую вас в игре Источник Силы!", "Информация", MessageBoxButton.OK, MessageBoxImage.None);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ALL.Visibility = Visibility.Hidden;
            Info.Visibility = Visibility.Visible;
            int d = Convert.ToInt32(Damage.Text);
            int s = Convert.ToInt32(Speed.Text);
            int h = Convert.ToInt32(Defence.Text);
            switch (Select.SelectedIndex)
            {
                // Атака
                case 0:
                    Info.Content = "Атака = " + Damage.Text;
                    Damage.Visibility = Visibility.Visible;
                    Use.IsEnabled = true;
                    Drink.IsEnabled = true;
                    Speed.Visibility = Visibility.Hidden;
                    Defence.Visibility = Visibility.Hidden;
                    
                    break;
                // Скорость
                case 1:
                    Info.Content = "Скорость = " + Speed.Text;
                    Speed.Visibility = Visibility.Visible;
                    Use.IsEnabled = true;
                    Drink.IsEnabled = true;
                    Damage.Visibility = Visibility.Hidden;
                    Defence.Visibility = Visibility.Hidden;
                    
                    break;
                // Защита
                case 2:
                    Info.Content = "Защита = " + Defence.Text;
                    Defence.Visibility = Visibility.Visible;
                    Use.IsEnabled = true;
                    Drink.IsEnabled = true;
                    Damage.Visibility = Visibility.Hidden;
                    Speed.Visibility = Visibility.Hidden;
                    
                    break;
            }

        }

        private void Damage_TextChanged(object sender, TextChangedEventArgs e)
        {
            int d = Convert.ToInt32(Damage.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PowerOfSourse.Value = 100;
            ALL.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ALL.Visibility = Visibility.Hidden;
            if (PowerOfSourse.Value == 0)
            {
                MessageBox.Show("Источником можно пользоваться только в том случае, если он не пуст!", "Упс", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                int d = Convert.ToInt32(Damage.Text);
                int s = Convert.ToInt32(Speed.Text);
                int h = Convert.ToInt32(Defence.Text);
                int v = Convert.ToInt32(Some.Text);
                if (Select.SelectedIndex == 0)
                {
                    d += v;
                    Damage.Text = d.ToString();
                    PowerOfSourse.Value -= v;
                }
                if (Select.SelectedIndex == 1)
                {
                    s += v;
                    Speed.Text = s.ToString();
                    PowerOfSourse.Value -= v;
                }
                if (Select.SelectedIndex == 2)
                {
                    h += v;
                    Defence.Text = h.ToString();
                    PowerOfSourse.Value -= v;
                }
                
            }
            if (Type.SelectedIndex == 1)
            {
                PowerOfSourse.Value += 100;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Image2.Visibility = Visibility.Hidden;
            Image3.Visibility = Visibility.Hidden;
            s = 0;
            Some.Text = Convert.ToString(0);
            Damage.Text = Convert.ToString(0);
            Speed.Text = Convert.ToString(0);
            Defence.Text = Convert.ToString(0);
            sos.nowUss = 0;
            Speed.Visibility = Visibility.Hidden;
            Damage.Visibility = Visibility.Hidden;
            Defence.Visibility = Visibility.Hidden;
            PowerOfSourse.Value = 0;
            PowerOfSourse.Maximum = power;
            Use.IsEnabled = false;
            Drink.IsEnabled = false;
            Info.Visibility = Visibility.Hidden;
            ALL.Visibility = Visibility.Hidden;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ALL.Visibility = Visibility.Visible;
            ALL.Content = $"ВЫВОД ВСЕЙ ИНФОРМАЦИИ \n Скорость =  {Speed.Text} \n Атака =  {Damage.Text} \n Защита =  { Defence.Text}";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            switch (Background.SelectedIndex)
            {
                case 0:
                    First.Visibility = Visibility.Visible;
                    Thirt.Visibility = Visibility.Hidden;
                    Second.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Second.Visibility = Visibility.Visible;
                    First.Visibility = Visibility.Hidden;
                    Thirt.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Thirt.Visibility = Visibility.Visible;
                    Second.Visibility = Visibility.Hidden;
                    First.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            switch(Type.SelectedIndex)
            {
                case 0:
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
