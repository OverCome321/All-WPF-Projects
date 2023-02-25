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
    /// Логика взаимодействия для SettingOfSource.xaml
    /// </summary>
    public partial class SettingOfSource : Page
    {
        Random random = new Random();
        int improveFirst;
        int improveSecond;
        double PriceFirst;
        double PriceSecond;
        KnightStats23 kn = new KnightStats23();
        public SettingOfSource(int damageOfHero, double gold, int damageOfSecondHero, double SecondGold, int HpFirstHero, int HpSecondHero, int HealsFirstHero, int HealsSecondHero, int LivesFirstHero, int LivesSecondHero)
        {
            InitializeComponent();
            PowerOfFirstSource.Visibility = Visibility.Hidden;
            lBpowerFirst.Visibility = Visibility.Hidden;
            PressFirst.Visibility = Visibility.Hidden;
            PBOfFirstSource.Visibility=Visibility.Hidden;
            CursedOfFirstSource.Visibility = Visibility.Hidden;
            DefoltFirstSource.Visibility = Visibility.Hidden;
            EverOfFirstSource.Visibility = Visibility.Hidden;
            AgainSurceFirst.Visibility = Visibility.Hidden;
            PowerOfSecondSource.Visibility = Visibility.Hidden;
            lBpowerSecond.Visibility = Visibility.Hidden;
            PressSecond.Visibility = Visibility.Hidden;
            PBOfSecondSource.Visibility = Visibility.Hidden;
            CursedOfSecondSource.Visibility = Visibility.Hidden;
            DefoltSecondSource.Visibility = Visibility.Hidden;
            EverOfSecondSource.Visibility = Visibility.Hidden;
            AgainSurceSecond.Visibility = Visibility.Hidden;
            kn.GoldenFirstKnight += gold;
            GoldOfFirstKnight.Text = Convert.ToString(gold);
            improveFirst += damageOfHero;
            kn.DamageFirstKnight += damageOfHero;
            DamageFirstKnight.Text = Convert.ToString(damageOfHero);
            DamageFirstKnight.IsEnabled = false;
            GoldOfFirstKnight.IsEnabled = false;
            GoldOfSecondKnight.IsEnabled=false;
            DamageSecondKnight.IsEnabled=false;
            kn.DamageSecondKnight += damageOfSecondHero;
            kn.GoldenSecondKnight += SecondGold;
            GoldOfSecondKnight.Text = Convert.ToString(SecondGold);
            DamageSecondKnight.Text = Convert.ToString(damageOfSecondHero);
            kn.hpOfFirstKnight += HpFirstHero;
            kn.hpOfSecondKnight += HpSecondHero;
            kn.HealsFirstKnight += HealsFirstHero;
            kn.HealsSecondKnight += HealsSecondHero;
            kn.LivesOfFirstKnights += LivesFirstHero;
            kn.LivesOfSecondKnights += LivesSecondHero;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch(TypeOfFirstSource.SelectedIndex)
            {
                case 0:
                    PowerOfFirstSource.Visibility = Visibility.Visible;
                    lBpowerFirst.Visibility = Visibility.Visible;
                    PressFirst.Visibility = Visibility.Visible;
                    PBOfFirstSource.Visibility = Visibility.Visible;
                    DefoltFirstSource.Visibility = Visibility.Visible;
                    PBOfFirstSource.Maximum = 1000;
                    PBOfFirstSource.Value = 1000;
                    AgainSurceFirst.Visibility = Visibility.Visible;
                    CursedOfFirstSource.Visibility = Visibility.Hidden;
                    EverOfFirstSource.Visibility = Visibility.Hidden;
                    ImproveFirst.IsEnabled = false;
                    break;
                case 1:
                    PowerOfFirstSource.Visibility = Visibility.Visible;
                    lBpowerFirst.Visibility = Visibility.Visible;
                    PressFirst.Visibility = Visibility.Visible;
                    PBOfFirstSource.Visibility = Visibility.Visible;
                    CursedOfFirstSource.Visibility = Visibility.Visible;
                    PBOfFirstSource.Maximum = 1000;
                    PBOfFirstSource.Value = 1000;
                    AgainSurceFirst.Visibility = Visibility.Visible;
                    DefoltFirstSource.Visibility = Visibility.Hidden;
                    EverOfFirstSource.Visibility = Visibility.Hidden;
                    ImproveFirst.IsEnabled = false;
                    break;
                case 2:
                    PowerOfFirstSource.Visibility = Visibility.Visible;

                    lBpowerFirst.Visibility = Visibility.Visible;
                    PressFirst.Visibility = Visibility.Visible;
                    PBOfFirstSource.Visibility = Visibility.Visible;
                    EverOfFirstSource.Visibility = Visibility.Visible;
                    PBOfFirstSource.Maximum = 1000;
                    PBOfFirstSource.Value = 1000;
                    DefoltFirstSource.Visibility = Visibility.Hidden;
                    CursedOfFirstSource.Visibility= Visibility.Hidden;
                    AgainSurceFirst.Visibility = Visibility.Hidden;
                    ImproveFirst.IsEnabled = false;
                    break;
            }
        }



        private void ImproveFirst_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeOfFirstSource.SelectedIndex)
            {
                case 0:
                    if (kn.GoldenFirstKnight < PriceFirst)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenFirstKnight <= 0)
                        {
                            GoldOfFirstKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            if (PBOfFirstSource.Value <= 0)
                            {
                                ImproveFirst.IsEnabled = false;
                            }
                            else
                            {
                                kn.GoldenFirstKnight -= PriceFirst;
                                GoldOfFirstKnight.Text = Convert.ToString(kn.GoldenFirstKnight);
                                improveFirst += kn.DamageFirstKnight;
                                MessageBox.Show(Convert.ToString(improveFirst));
                                DamageFirstKnight.Text = Convert.ToString(improveFirst);
                                PBOfFirstSource.Value -= kn.DamageFirstKnight;

                            }
                        }
                    }
                    break;
                case 1:
                    if (kn.GoldenFirstKnight < PriceFirst)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenFirstKnight <= 0)
                        {
                            GoldOfFirstKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            int rnd = random.Next(1, 6);
                            if (PBOfFirstSource.Value <= 0)
                            {
                                ImproveFirst.IsEnabled = false;
                            }
                            else
                            {
                                if (rnd == 2)
                                {
                                    kn.GoldenFirstKnight -= PriceFirst;
                                    GoldOfFirstKnight.Text = Convert.ToString(kn.GoldenFirstKnight);
                                    improveFirst -= kn.DamageFirstKnight;
                                    PBOfFirstSource.Value -= kn.DamageFirstKnight;
                                }
                                else
                                {
                                    kn.GoldenFirstKnight -= PriceFirst;
                                    GoldOfFirstKnight.Text = Convert.ToString(kn.GoldenFirstKnight);
                                    improveFirst += kn.DamageFirstKnight;
                                    MessageBox.Show(Convert.ToString(improveFirst));
                                    DamageFirstKnight.Text = Convert.ToString(improveFirst);
                                    PBOfFirstSource.Value -= kn.DamageFirstKnight;

                                }
                            }
                        }
                    }
                    break;
                case 2:
                    if (kn.GoldenFirstKnight < PriceFirst)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenFirstKnight <= 0)
                        {
                            GoldOfFirstKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            kn.GoldenFirstKnight -= PriceFirst;
                            GoldOfFirstKnight.Text = Convert.ToString(kn.GoldenFirstKnight);
                            improveFirst += kn.DamageFirstKnight;
                            MessageBox.Show(Convert.ToString(improveFirst));
                            DamageFirstKnight.Text = Convert.ToString(improveFirst);
                        }
                    }
                    break;
            }
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1(improveFirst, kn.GoldenFirstKnight, improveSecond, kn.GoldenSecondKnight, kn.hpOfFirstKnight, kn.hpOfSecondKnight, kn.HealsFirstKnight, kn.HealsSecondKnight,kn.LivesOfFirstKnights, kn.LivesOfSecondKnights));
        }

        private void SecondSourceButt_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeOfSecondSource.SelectedIndex)
            {
                case 0:
                    PowerOfSecondSource.Visibility = Visibility.Visible;
                    lBpowerSecond.Visibility = Visibility.Visible;
                    PressSecond.Visibility = Visibility.Visible;
                    PBOfSecondSource.Visibility = Visibility.Visible;
                    DefoltSecondSource.Visibility = Visibility.Visible;
                    PBOfSecondSource.Maximum = 1000;
                    PBOfSecondSource.Value = 1000;
                    AgainSurceSecond.Visibility = Visibility.Visible;
                    CursedOfSecondSource.Visibility = Visibility.Hidden;
                    EverOfSecondSource.Visibility = Visibility.Hidden;
                    ImproveSecond.IsEnabled = false;
                    break;
                case 1:
                    PowerOfSecondSource.Visibility = Visibility.Visible;
                    lBpowerSecond.Visibility = Visibility.Visible;
                    PressSecond.Visibility = Visibility.Visible;
                    PBOfSecondSource.Visibility = Visibility.Visible;
                    CursedOfSecondSource.Visibility = Visibility.Visible;
                    PBOfSecondSource.Maximum = 1000;
                    PBOfSecondSource.Value = 1000;
                    AgainSurceSecond.Visibility = Visibility.Visible;
                    DefoltSecondSource.Visibility = Visibility.Hidden;
                    EverOfSecondSource.Visibility = Visibility.Hidden;
                    ImproveSecond.IsEnabled = false;
                    break;
                case 2:
                    PowerOfSecondSource.Visibility = Visibility.Visible;

                    lBpowerSecond.Visibility = Visibility.Visible;
                    PressSecond.Visibility = Visibility.Visible;
                    PBOfSecondSource.Visibility = Visibility.Visible;
                    EverOfSecondSource.Visibility = Visibility.Visible;
                    PBOfSecondSource.Maximum = 1000;
                    PBOfSecondSource.Value = 1000;
                    DefoltSecondSource.Visibility = Visibility.Hidden;
                    CursedOfSecondSource.Visibility = Visibility.Hidden;
                    AgainSurceSecond.Visibility = Visibility.Hidden;
                    ImproveSecond.IsEnabled = false;
                    break;
            }
        }

        private void PressFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                kn.DamageFirstKnight = Convert.ToInt32(PowerOfFirstSource.Text);
                PriceFirst = Convert.ToInt32(FirstPrice.Text);
                ImproveFirst.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PressSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                kn.DamageSecondKnight = Convert.ToInt32(PowerOfSecondSource.Text);
                PriceSecond = Convert.ToInt32(SecondPrice.Text);
                ImproveSecond.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Неккоректно введены данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ImproveSecond_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeOfSecondSource.SelectedIndex)
            {
                case 0:
                    if (kn.GoldenSecondKnight < PriceSecond)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenSecondKnight <= 0)
                        {
                            GoldOfSecondKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            if (PBOfSecondSource.Value <= 0)
                            {
                                ImproveSecond.IsEnabled = false;
                            }
                            else
                            {
                                kn.GoldenSecondKnight -= PriceSecond;
                                GoldOfSecondKnight.Text = Convert.ToString(kn.GoldenSecondKnight);
                                improveSecond += kn.DamageSecondKnight;
                                MessageBox.Show(Convert.ToString(improveSecond));
                                DamageSecondKnight.Text = Convert.ToString(improveSecond);
                                PBOfSecondSource.Value -= kn.DamageSecondKnight;

                            }
                        }
                    }
                    break;
                case 1:
                    if (kn.GoldenSecondKnight < PriceSecond)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenSecondKnight <= 0)
                        {
                            GoldOfSecondKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            int rnd = random.Next(1, 6);
                            if (PBOfSecondSource.Value <= 0)
                            {
                                ImproveSecond.IsEnabled = false;
                            }
                            else
                            {
                                if (rnd == 2)
                                {
                                    kn.GoldenSecondKnight -= PriceSecond;
                                    GoldOfSecondKnight.Text = Convert.ToString(kn.GoldenSecondKnight);
                                    improveSecond -= kn.DamageSecondKnight;
                                    PBOfSecondSource.Value -= kn.DamageSecondKnight;
                                }
                                else
                                {
                                    kn.GoldenSecondKnight -= PriceSecond;
                                    GoldOfSecondKnight.Text = Convert.ToString(kn.GoldenSecondKnight);
                                    improveSecond += kn.DamageSecondKnight;
                                    MessageBox.Show(Convert.ToString(improveSecond));
                                    DamageSecondKnight.Text = Convert.ToString(improveSecond);
                                    PBOfSecondSource.Value -= kn.DamageSecondKnight;

                                }
                            }
                        }
                    }
                    break;
                case 2:
                    if (kn.GoldenSecondKnight < PriceSecond)
                    {
                        MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        if (kn.GoldenSecondKnight <= 0)
                        {
                            GoldOfSecondKnight.Text = "0";
                            MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            kn.GoldenSecondKnight -= PriceSecond;
                            GoldOfSecondKnight.Text = Convert.ToString(kn.GoldenSecondKnight);
                            improveSecond += kn.DamageSecondKnight;
                            MessageBox.Show(Convert.ToString(improveSecond));
                            DamageSecondKnight.Text = Convert.ToString(improveSecond);
                        }
                    }
                    break;
            }
        }

        private void AgainSurceFirst_Click(object sender, RoutedEventArgs e)
        {
            PBOfFirstSource.Value += 1000;
            ImproveFirst.IsEnabled = true;
        }

        private void AgainSurceSecond_Click(object sender, RoutedEventArgs e)
        {
            PBOfSecondSource.Value += 1000;
            ImproveSecond.IsEnabled = true;
        }
    }
    
}
