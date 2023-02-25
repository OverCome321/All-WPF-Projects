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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        KnightStatsAndMethods ks = new KnightStatsAndMethods();
        public MainPage()
        {
            InitializeComponent();
        }

        private void PressFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ks.GoldenFirstKnight = Convert.ToDouble(GoldOfFirstKnight.Text);
                ks.hpOfFirstKnight = Convert.ToInt32(HpOfFirstKnight.Text);
                ks.DamageFirstKnight = Convert.ToInt32(DamageOfFirstKnight.Text);
                ks.LivesOfFirstKnights = Convert.ToInt32(CountOfLivesFirst.Text);
                ks.HealsFirstKnight = Convert.ToInt32(CountOfHealsFirst.Text);
                GoldOfFirstKnight.IsEnabled = false;
                HpOfFirstKnight.IsEnabled = false;
                DamageOfFirstKnight.IsEnabled = false;
                CountOfLivesFirst.IsEnabled = false;
                CountOfHealsFirst.IsEnabled = false;
                CbOfTypesFirstKnight.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PressSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ks.GoldenSecondKnight = Convert.ToDouble(GoldOfSecondKnight.Text);
                ks.hpOfSecondKnight = Convert.ToInt32(HpOfSecondKnight.Text);
                ks.DamageSecondKnight = Convert.ToInt32(DamageOfSecondKnight.Text);
                ks.LivesOfSecondKnights = Convert.ToInt32(CountOfLivesSecond.Text);
                ks.HealsSecondKnight = Convert.ToInt32(CountOfHealsSecond.Text);
                GoldOfSecondKnight.IsEnabled = false;
                HpOfSecondKnight.IsEnabled = false;
                DamageOfSecondKnight.IsEnabled = false;
                CountOfLivesSecond.IsEnabled = false;
                CountOfHealsSecond.IsEnabled = false;
                CbOfTypesSecondKnight.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MiddlePage(ks.GoldenFirstKnight,ks.GoldenSecondKnight,ks.hpOfFirstKnight,ks.hpOfSecondKnight,ks.DamageFirstKnight,ks.DamageSecondKnight,ks.LivesOfFirstKnights,ks.LivesOfSecondKnights,ks.HealsFirstKnight,ks.HealsSecondKnight, CbOfTypesFirstKnight.SelectedIndex, CbOfTypesSecondKnight.SelectedIndex));
        }
    }
}
