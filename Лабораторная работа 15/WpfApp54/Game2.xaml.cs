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
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    /// 
    public partial class Game2 : Page
    {
        KnightStats23 kn = new KnightStats23();
        public Game2(int healsFirst, int healsSecond, int indexFirstHero, int indexSecondHero, int damageFirstHero, int damageSecondHero, int HpFirstHero, int HpSecondHero, int livesFirstHero, int LivesSecondHero)
        {
            InitializeComponent();
            if (healsFirst == 0)
            {
                UseHealFirst.IsEnabled = false;
            }
            if (healsSecond == 0)
            {
                UseHealSecond.IsEnabled = false;
            }
            switch (indexFirstHero)
            {
                case 0:
                    KnightOfRoundTableFirst.Visibility = Visibility.Hidden;
                    CrusaderFirst.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    KnightFirst.Visibility = Visibility.Hidden;
                    KnightOfRoundTableFirst.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    KnightFirst.Visibility = Visibility.Hidden;
                    CrusaderFirst.Visibility = Visibility.Hidden;
                    break;
            }
            switch (indexSecondHero)
            {
                case 0:
                    KnightOfRoundTableSecond.Visibility = Visibility.Hidden;
                    CrusaderSecond.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    KnightSecond.Visibility = Visibility.Hidden;
                    KnightOfRoundTableSecond.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    CrusaderSecond.Visibility = Visibility.Hidden;
                    KnightSecond.Visibility = Visibility.Hidden;
                    break;

            }
            PbOfFirstHero.Maximum = HpFirstHero;
            PbOfSecondHero.Maximum = HpSecondHero;
            PbOfFirstHero.Value = HpFirstHero;
            PbOfSecondHero.Value = HpSecondHero;
            kn.hpOfFirstKnight = HpFirstHero;
            kn.hpOfSecondKnight = HpSecondHero;
            kn.HealsFirstKnight = healsFirst;
            kn.HealsSecondKnight = healsSecond;
            kn.LivesOfFirstKnights = livesFirstHero;
            kn.LivesOfSecondKnights = LivesSecondHero;
            kn.DamageFirstKnight = damageFirstHero;
            kn.DamageSecondKnight = damageSecondHero;
            HealsOfFirstHero.Content = $"Зелья лечения - {kn.HealsFirstKnight}";
            HealsOfSecondHero.Content = $"Зелья лечения - {kn.HealsSecondKnight}";
            LivesOfFirstHero.Content = $"Число жизней - {kn.LivesOfFirstKnights}";
            LivesOfSecondHero.Content = $"Число жизней - {kn.LivesOfSecondKnights}";
        }

        private void AttackFirst_Click(object sender, RoutedEventArgs e)
        {
            if (kn.LivesOfSecondKnights == 0 || PbOfSecondHero.Value == 0)
            {
                Window2 wn2 = new Window2();
                wn2.Show();
                PbOfSecondHero.Value = kn.hpOfSecondKnight;
            }
            else if (PbOfSecondHero.Value == 0)
            {
                PbOfSecondHero.Value += kn.hpOfSecondKnight;
                kn.LivesOfSecondKnights -= 1;
                LivesOfSecondHero.Content = $"Число жизней - {kn.LivesOfSecondKnights}";
            }
            else
            {
                PbOfSecondHero.Value -= kn.DamageFirstKnight;
            }
        }

        private void AttackSecond_Click(object sender, RoutedEventArgs e)
        {
            if (kn.LivesOfFirstKnights == 0 || PbOfFirstHero.Value == 0)
            {
                Window1 wn = new Window1();
                wn.Show();
                PbOfFirstHero.Value = kn.hpOfFirstKnight;

            }
            else if (PbOfFirstHero.Value == 0)
            {
                PbOfFirstHero.Value += kn.hpOfFirstKnight;
                kn.LivesOfFirstKnights -= 1;
                LivesOfFirstHero.Content = $"Число жизней - {kn.LivesOfFirstKnights}";
            }
            else
            {
                PbOfFirstHero.Value -= kn.DamageSecondKnight;
            }
        }

        private void UseHealSecond_Click(object sender, RoutedEventArgs e)
        {
            if (kn.HealsSecondKnight == 0)
            {
                MessageBox.Show("Зелья кончились!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                PbOfSecondHero.Value += PbOfSecondHero.Value / 0.25;
                kn.HealsSecondKnight -= 1;
                HealsOfSecondHero.Content = $"Зелья лечения - {kn.HealsSecondKnight}";
            }
        }

        private void UseHealFirst_Click(object sender, RoutedEventArgs e)
        {
            if (kn.HealsFirstKnight == 0)
            {
                MessageBox.Show("Зелья кончились!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                PbOfFirstHero.Value += PbOfFirstHero.Value / 0.25;
                kn.HealsFirstKnight -= 1;
                HealsOfFirstHero.Content = $"Зелья лечения - {kn.HealsFirstKnight}";
            }
        }
    }
}
