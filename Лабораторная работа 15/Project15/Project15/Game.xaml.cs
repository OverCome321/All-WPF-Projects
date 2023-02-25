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
namespace Project15
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        KnightStatsAndMethods ks = new KnightStatsAndMethods();
        public Game(int damageFirst,int damageSecond,int hpFirst,int hpSecond,int livesFirst,int livesSecond, int healsFirst,int healsSecond, int indexFirst, int indexSecond)
        {
            InitializeComponent();
            PbFirstKnight.Maximum = hpFirst;
            PbFirstKnight.Value = hpFirst;
            PbSecondKnight.Maximum = hpSecond;
            PbSecondKnight.Value = hpSecond;
            ks.hpOfFirstKnight = hpFirst;
            ks.hpOfSecondKnight = hpSecond;
            ks.DamageFirstKnight = damageFirst;
            ks.DamageSecondKnight = damageSecond;
            ks.HealsFirstKnight = healsFirst;
            ks.HealsSecondKnight = healsSecond;
            ks.LivesOfFirstKnights = livesFirst;
            ks.LivesOfSecondKnights = livesSecond;
            LivesOfFirst.Text = Convert.ToString(ks.LivesOfFirstKnights);
            LivesOfFirst.IsEnabled = false;
            LivesOfSecond.Text = Convert.ToString(ks.LivesOfSecondKnights);
            LivesOfSecond.IsEnabled = false;
            CountFirstHeals.Text = Convert.ToString(ks.HealsFirstKnight);
            CountFirstHeals.IsEnabled = false;
            CountSecondHeals.Text = Convert.ToString(ks.HealsSecondKnight);
            CountSecondHeals.IsEnabled = false;
            switch (indexFirst)
            {
                case 0:
                    KnightOfAroundTableFirst.Visibility = Visibility.Hidden;
                    CrusaderFirst.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    KnightFirst.Visibility = Visibility.Hidden;
                    CrusaderFirst.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    KnightFirst.Visibility = Visibility.Hidden;
                    KnightOfAroundTableFirst.Visibility = Visibility.Hidden;
                    break;

            }
            switch (indexSecond)
            {
                case 0:
                    CrusaderSecond.Visibility = Visibility.Hidden;
                    KnightOfAroundTableSecond.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    CrusaderSecond.Visibility = Visibility.Hidden;
                    KnightSecond.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    KnightSecond.Visibility = Visibility.Hidden;
                    KnightOfAroundTableSecond.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void DamageSecond_Click(object sender, RoutedEventArgs e)
        {
            if (PbFirstKnight.Value <= 0)
            {
                PbFirstKnight.Value += ks.hpOfFirstKnight;
                ks.LivesOfFirstKnights -= 1;
                LivesOfFirst.Text = Convert.ToString(ks.LivesOfFirstKnights);
                if (ks.LivesOfFirstKnights == 0 || PbFirstKnight.Value <= 0)
                {
                    PbFirstKnight.Value = ks.hpOfFirstKnight;
                    MessageBox.Show("Второй рыцарь победил!");
                    NavigationService.Navigate(new MainPage());
                }
            }
            else
            {
                PbFirstKnight.Value -= ks.DamageSecondKnight;
            }
        }

        private void DamageFirst_Click(object sender, RoutedEventArgs e)
        {

            if (PbSecondKnight.Value <= 0)
            {
                PbSecondKnight.Value += ks.hpOfSecondKnight;
                ks.LivesOfSecondKnights -= 1;
                LivesOfSecond.Text = Convert.ToString(ks.LivesOfSecondKnights);
                if (ks.LivesOfSecondKnights == 0 || PbSecondKnight.Value <= 0)
                {
                    PbSecondKnight.Value = ks.hpOfSecondKnight;
                    MessageBox.Show("Первый рыцарь победил!");
                    NavigationService.Navigate(new MainPage());
                }
            }
            else
            {
                PbSecondKnight.Value -= ks.DamageFirstKnight;
            }
        }

        private void UseHealSecond_Click(object sender, RoutedEventArgs e)
        {
            if (ks.HealsSecondKnight == 0)
            {
                MessageBox.Show("Зелья кончились!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                PbSecondKnight.Value += ks.hpOfSecondKnight;
                ks.HealsSecondKnight -= 1;
                CountSecondHeals.Text = Convert.ToString(ks.HealsSecondKnight);
            }
        }

        private void UseHealFirst_Click(object sender, RoutedEventArgs e)
        {
            if (ks.HealsFirstKnight == 0)
            {
                MessageBox.Show("Зелья кончились!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                PbFirstKnight.Value += ks.hpOfFirstKnight;
                ks.HealsFirstKnight -= 1;
                CountFirstHeals.Text = Convert.ToString(ks.HealsFirstKnight);
            }
        }
    }
}
