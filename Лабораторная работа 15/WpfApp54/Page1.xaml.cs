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
using KnightStats;
namespace WpfApp54
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        KnightStats23 knightStat = new KnightStats23();
        public Page1(int damageOfFirstKnight, double GoldenOfFirstKnight, int damageOfSecondKnight, double GoldenOfSecondKnight, int HpFirst, int HpSecond, int HealsFirst, int HealsSecond, int LivesFirst, int LivesSecond)
        {
            InitializeComponent();
            if (damageOfFirstKnight > knightStat.DamageFirstKnight || damageOfSecondKnight > knightStat.DamageSecondKnight)
            {
                knightStat.DamageSecondKnight = damageOfSecondKnight;
                knightStat.GoldenSecondKnight = GoldenOfSecondKnight;
                MoneyTbSecondKnight.Text = Convert.ToString(GoldenOfSecondKnight);
                DamageSecondKnight.Text = Convert.ToString(damageOfSecondKnight);
                knightStat.DamageFirstKnight = damageOfFirstKnight;
                knightStat.GoldenFirstKnight = GoldenOfFirstKnight;
                MoneyTbFirstKnight.Text = Convert.ToString(GoldenOfFirstKnight);
                DamageFirstKnight.Text = Convert.ToString(damageOfFirstKnight);
                knightStat.hpOfFirstKnight = HpFirst;
                knightStat.hpOfSecondKnight = HpSecond;
                HpOfFirstKnight.Text = Convert.ToString(HpFirst);
                HpSecondKnight.Text = Convert.ToString(HpSecond);
                knightStat.HealsFirstKnight = HealsFirst;
                knightStat.HealsSecondKnight = HealsSecond;
                HealsOfFirstKnight.Text = Convert.ToString(HealsFirst);
                HealsOfSecondKnight.Text = Convert.ToString(HealsSecond);
                knightStat.LivesOfFirstKnights = LivesFirst;
                knightStat.LivesOfSecondKnights = LivesSecond;
                LivesOfFirstKnight.Text = Convert.ToString(LivesFirst);
                LivesOfSecondKnights.Text = Convert.ToString(LivesSecond);
            }
            else
            {
                knightStat.GoldenSecondKnight = GoldenOfSecondKnight;
                MoneyTbSecondKnight.Text = Convert.ToString(GoldenOfSecondKnight);
                DamageSecondKnight.Text = Convert.ToString(knightStat.DamageSecondKnight);
                knightStat.GoldenFirstKnight = GoldenOfFirstKnight;
                MoneyTbFirstKnight.Text = Convert.ToString(GoldenOfFirstKnight);
                DamageFirstKnight.Text = Convert.ToString(knightStat.DamageFirstKnight);
                knightStat.hpOfFirstKnight = HpFirst;
                knightStat.hpOfSecondKnight = HpSecond;
                HpOfFirstKnight.Text = Convert.ToString(HpFirst);
                HpSecondKnight.Text = Convert.ToString(HpSecond);
                knightStat.HealsFirstKnight = HealsFirst;
                knightStat.HealsSecondKnight = HealsSecond;
                HealsOfFirstKnight.Text = Convert.ToString(HealsFirst);
                HealsOfSecondKnight.Text = Convert.ToString(HealsSecond);
                knightStat.LivesOfFirstKnights = LivesFirst;
                knightStat.LivesOfSecondKnights = LivesSecond;
                LivesOfFirstKnight.Text = Convert.ToString(LivesFirst);
                LivesOfSecondKnights.Text = Convert.ToString(LivesSecond);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.GoldenFirstKnight = Convert.ToDouble(MoneyTbFirstKnight.Text);
            }
            catch 
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void MoneyButtSecondKnight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.GoldenSecondKnight = Convert.ToDouble(MoneyTbSecondKnight.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CountOfFirstHeals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.HealsFirstKnight = Convert.ToInt32(HealsOfFirstKnight.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CountOfSecondHeals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.HealsSecondKnight = Convert.ToInt32(HealsOfSecondKnight.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.HealsFirstKnight = Convert.ToInt32(HealsOfFirstKnight.Text);
                knightStat.HealsSecondKnight = Convert.ToInt32(HealsOfSecondKnight.Text);
                knightStat.DamageFirstKnight = Convert.ToInt32(DamageFirstKnight.Text);
                knightStat.DamageSecondKnight = Convert.ToInt32(DamageSecondKnight.Text);
                knightStat.hpOfFirstKnight = Convert.ToInt32(HpOfFirstKnight.Text);
                knightStat.hpOfSecondKnight = Convert.ToInt32(HpSecondKnight.Text);
                knightStat.LivesOfFirstKnights = Convert.ToInt32(LivesOfFirstKnight.Text);
                knightStat.LivesOfSecondKnights = Convert.ToInt32(LivesOfSecondKnights.Text);
                GameInWindow gameInWindow = new GameInWindow(knightStat.HealsFirstKnight, knightStat.HealsSecondKnight, TypeOfFirstKnight.SelectedIndex, TypeOfSecondKnight.SelectedIndex, knightStat.DamageFirstKnight, knightStat.DamageSecondKnight, knightStat.hpOfFirstKnight, knightStat.hpOfSecondKnight, knightStat.LivesOfFirstKnights, knightStat.LivesOfSecondKnights);
                gameInWindow.Show();
                //NavigationService.Navigate(new Game2(knightStat.HealsFirstKnight, knightStat.HealsSecondKnight, TypeOfFirstKnight.SelectedIndex, TypeOfSecondKnight.SelectedIndex, knightStat.DamageFirstKnight, knightStat.DamageSecondKnight, knightStat.hpOfFirstKnight, knightStat.hpOfSecondKnight, knightStat.LivesOfFirstKnights, knightStat.LivesOfSecondKnights));
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void SettingsOfFirstSource_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingOfSource(knightStat.DamageFirstKnight, knightStat.GoldenFirstKnight, knightStat.DamageSecondKnight, knightStat.GoldenSecondKnight,knightStat.hpOfFirstKnight, knightStat.hpOfSecondKnight, knightStat.HealsFirstKnight, knightStat.HealsSecondKnight, knightStat.LivesOfFirstKnights, knightStat.LivesOfSecondKnights));
        }
        private void TypeButtOfFirstKnight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.DamageFirstKnight = Convert.ToInt32(DamageFirstKnight.Text);
                knightStat.hpOfFirstKnight = Convert.ToInt32(HpOfFirstKnight.Text);
                knightStat.LivesOfFirstKnights = Convert.ToInt32(LivesOfFirstKnight.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TypeButtOfSecondKnight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                knightStat.DamageSecondKnight = Convert.ToInt32(DamageSecondKnight.Text);
                knightStat.hpOfSecondKnight = Convert.ToInt32(HpSecondKnight.Text);
                knightStat.LivesOfSecondKnights = Convert.ToInt32(LivesOfSecondKnights.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
