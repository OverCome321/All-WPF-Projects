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
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        Random random = new Random();
        Knight kn = new Knight();
        int counterOfPrincess = 3;
        int princess = 0;
        int princessFirst = 0;
        int princessSecond = 0;
        int princessThirt = 0;
        int princessFour = 0;
        int princessFive = 0;
        int savedPrincess = 0;
        Tower tw = new Tower();
        public Map(int hpTower, int towerDamage, int KnightHp, int KnightDamage)
        {
            InitializeComponent();
            tw.MaxHP = hpTower;
            tw.towerDamage = towerDamage;
            kn.MaxHP = KnightHp;
            kn.MaxAtack = KnightDamage;
            PbFirst.Maximum = tw.MaxHP;
            PbFirst.Value = tw.MaxHP;
            PbSecond.Maximum = tw.MaxHP;
            PbSecond.Value = tw.MaxHP;
            PbThirt.Maximum = tw.MaxHP;
            PbThirt.Value = tw.MaxHP;
            PbFour.Maximum = tw.MaxHP;
            PbFour.Value = tw.MaxHP;
            PbFive.Maximum = tw.MaxHP;
            PbFive.Value = tw.MaxHP;
            PbKnights.Maximum = kn.MaxHP;
            PbKnights.Value = kn.MaxHP;
            tw.countOfPrincess = 0;
        }

        private void AtackFirstTower_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (counterOfPrincess > 0)
            {
                counterOfPrincess--;
                princess = random.Next(0, 2);
                if (princess == 1)
                {
                    princessFirst = 1;
                    tw.countOfPrincess += 1;
                    MessageBox.Show("Принцесса в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    AtackFirstTower_Copy.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    AtackFirstTower_Copy.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AtackFirstTower_Copy.Visibility = Visibility.Hidden;
            }
        }

        private void AtackSecondTower_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (counterOfPrincess > 0)
            {
                counterOfPrincess--;
                princess = random.Next(0, 2);
                if (princess == 1)
                {
                    princessSecond = 1;
                    tw.countOfPrincess += 1;
                    MessageBox.Show("Принцесса в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    AtackSecondTower_Copy.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    AtackSecondTower_Copy.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AtackSecondTower_Copy.Visibility = Visibility.Hidden;
            }
        }

        private void AtackThirtTower_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (counterOfPrincess > 0)
            {
                counterOfPrincess--;
                princess = random.Next(0, 2);
                if (princess == 1)
                {
                    princessThirt = 1;
                    tw.countOfPrincess += 1;
                    MessageBox.Show("Принцесса в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    AtackThirtTower_Copy.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    AtackThirtTower_Copy.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AtackThirtTower_Copy.Visibility = Visibility.Hidden;
            }
        }

        private void AtackFourTower_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (counterOfPrincess > 0)
            {
                counterOfPrincess--;
                princess = random.Next(0, 2);
                if (princess == 1)
                {
                    princessFour = 1;
                    tw.countOfPrincess += 1;
                    MessageBox.Show("Принцесса в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    AtackFourTower_Copy.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    AtackFourTower_Copy.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AtackFourTower_Copy.Visibility = Visibility.Hidden;
            }
        }

        private void AtackFiveTower_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (counterOfPrincess > 0)
            {
                counterOfPrincess--;
                princess = random.Next(0, 2);
                if (princess == 1)
                {
                    princessFive = 1;
                    tw.countOfPrincess += 1;
                    MessageBox.Show("Принцесса в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    AtackFiveTower_Copy.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    AtackFiveTower_Copy.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                MessageBox.Show("Принцессы нет в башне!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                AtackFiveTower_Copy.Visibility = Visibility.Hidden;
            }
        }

        private void AtackFirstTower_Click(object sender, RoutedEventArgs e)
        {
            if (PbFirst.Value <= 0)
            {
                if (princessFirst == 1)
                {
                    savedPrincess += 1;
                    MessageBox.Show("Вы уничтожили башню и спасли принцессу!");
                    AtackFirstTower.IsEnabled = false;
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    PbFirst.Value = 0;
                }
                else
                {
                    MessageBox.Show("Вы уничтожили башню но в ней не было принцессы!");
                    AtackFirstTower.IsEnabled = false;
                    PbFirst.Value = 0;
                }
            }
            else
            {
                PbFirst.Value -= kn.MaxAtack;
            }
        }

        private void AtackThirtTower_Click(object sender, RoutedEventArgs e)
        {
            if (PbThirt.Value <= 0)
            {
                if (princessThirt == 1)
                {
                    savedPrincess += 1;
                    MessageBox.Show("Вы уничтожили башню и спасли принцессу!");
                    AtackThirtTower.IsEnabled = false;
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    PbThirt.Value = 0;
                }
                else
                {
                    MessageBox.Show("Вы уничтожили башню но в ней не было принцессы!");
                    AtackThirtTower.IsEnabled = false;
                    PbThirt.Value = 0;
                }
            }
            else
            {
                PbThirt.Value -= kn.MaxAtack;
            }
        }

        private void AtackSecondTower_Click(object sender, RoutedEventArgs e)
        {
            if (PbSecond.Value <= 0)
            {
                if (princessSecond == 1)
                {
                    savedPrincess += 1;
                    MessageBox.Show("Вы уничтожили башню и спасли принцессу!");
                    AtackSecondTower.IsEnabled = false;
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    PbSecond.Value = 0;
                }
                else
                {
                    MessageBox.Show("Вы уничтожили башню но в ней не было принцессы!");
                    AtackSecondTower.IsEnabled = false;
                    PbSecond.Value = 0;
                }
            }
            else
            {
                PbSecond.Value -= kn.MaxAtack;
            }
        }

        private void AtackFourTower_Click(object sender, RoutedEventArgs e)
        {
            if (PbFour.Value <= 0)
            {
                if (princessFour == 1)
                {
                    savedPrincess += 1;
                    MessageBox.Show("Вы уничтожили башню и спасли принцессу!");
                    AtackFourTower.IsEnabled = false;
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    PbFour.Value += 0;
                }
                else
                {
                    MessageBox.Show("Вы уничтожили башню но в ней не было принцессы!");
                    AtackFourTower.IsEnabled = false;
                    PbFour.Value = 0;
                }
            }
            else
            {
                PbFour.Value -= kn.MaxAtack;
            }
        }

        private void AtackFiveTower_Click(object sender, RoutedEventArgs e)
        {
            if (PbFive.Value <= 0)
            {
                if (princessFive == 1)
                {
                    savedPrincess += 1;
                    MessageBox.Show("Вы уничтожили башню и спасли принцессу!");
                    AtackFiveTower.IsEnabled = false;
                    LabelPrincess.Content = $"Число спасенных принцесс {savedPrincess}/{tw.countOfPrincess}";
                    PbFive.Value = 0;
                }
                else
                {
                    MessageBox.Show("Вы уничтожили башню но в ней не было принцессы!");
                    AtackFiveTower.IsEnabled = false;
                    PbFive.Value = 0;
                }
            }
            else
            {
                PbFive.Value -= kn.MaxAtack;
            }
        }

        private void DamageForArmy_Click(object sender, RoutedEventArgs e)
        {
            if(PbKnights.Value <= 0)
            {
                PbKnights.Value = 0;
                MessageBox.Show("Ваше войско уничтожено!", "Поражение", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new Knights());
            }  
            else
            {
                PbKnights.Value -= tw.towerDamage;
            }
        }

        private void Again_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Вы спасли {savedPrincess}/{tw.countOfPrincess} принцесс", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new Knights());
        }
    }
}
