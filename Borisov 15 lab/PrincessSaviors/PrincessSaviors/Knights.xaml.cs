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
using PlayerClass;
using _4;
namespace PrincessSaviors
{
    /// <summary>
    /// Логика взаимодействия для Knights.xaml
    /// </summary>
    public partial class Knights : Page
    {
        Knight kn = new Knight();
        Tower tw = new Tower();

        public Knights()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TbAtackOfTower.Text == "" || TbHpOfTower.Text == "" || HpOfKnight.Text == "" || AtackOfKnight.Text == "")
                {
                    MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    NavigationService.Navigate(new Map(tw.MaxHP, tw.towerDamage, kn.MaxHP, kn.MaxAtack));
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UseFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tw.MaxHP = Convert.ToInt32(TbHpOfTower.Text);
                tw.towerDamage = Convert.ToInt32(TbAtackOfTower.Text);
                UseFirst.IsEnabled = false;
                TbHpOfTower.IsEnabled = false;
                TbAtackOfTower.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UseSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kn.MaxHP = Convert.ToInt32(HpOfKnight.Text);
                kn.MaxAtack = Convert.ToInt32(AtackOfKnight.Text);
                UseSecond.IsEnabled = false;
                HpOfKnight.IsEnabled = false;
                AtackOfKnight.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
