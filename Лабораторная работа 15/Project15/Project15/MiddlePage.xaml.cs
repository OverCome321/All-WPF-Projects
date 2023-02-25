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
    /// Логика взаимодействия для MiddlePage.xaml
    /// </summary>
    public partial class MiddlePage : Page
    {
        int indexFirst = 0;
        int indexSecond = 0;
        KnightStatsAndMethods ks = new KnightStatsAndMethods();
        public MiddlePage(double GoldFirst, double GoldSecond, int HpFirst, int HpSecond, int DamageFirst, int DamageSecond, int LivesFirst, int LivesSecond, int HealsFirst, int HealsSecond, int IndexFirst, int IndexSecond)
        {
            InitializeComponent();
            LabelFirstGold.Visibility = Visibility.Hidden;
            LabelSecondGold.Visibility= Visibility.Hidden;
            CbOfSource.Visibility = Visibility.Hidden;
            EverSource.Visibility = Visibility.Hidden;
            DefoltSource.Visibility = Visibility.Hidden;
            CursedCource.Visibility = Visibility.Hidden;
            PressButt.Visibility = Visibility.Hidden;
            PbOfSource.Visibility = Visibility.Hidden;
            TbGoldFirst.Visibility = Visibility.Hidden;
            TbGoldSecond.Visibility = Visibility.Hidden;
            AgainSource.Visibility = Visibility.Hidden;
            CbOfStatsFirst.Visibility = Visibility.Hidden;
            CbOfStatsSecond.Visibility = Visibility.Hidden;
            ImproveStatsFirst.Visibility = Visibility.Hidden;
            ImproveStatsSecond.Visibility = Visibility.Hidden;
            LabelFirstCost.Visibility = Visibility.Hidden;
            LabelSecondCost.Visibility = Visibility.Hidden;
            LabelFirstImprove.Visibility = Visibility.Hidden;
            LabelSecondImprove.Visibility = Visibility.Hidden;
            CostOfFirst.Visibility = Visibility.Hidden;
            CostOfSecond.Visibility = Visibility.Hidden;
            ImproveFirstKnight.Visibility = Visibility.Hidden;
            ImproveSecondKnight.Visibility = Visibility.Hidden;
            TbGoldFirst.IsEnabled = false;
            TbGoldSecond.IsEnabled = false;
            TbGoldFirst.Text = Convert.ToString(GoldFirst);
            TbGoldSecond.Text = Convert.ToString(GoldSecond);
            ks.DamageFirstKnight = DamageFirst;
            ks.DamageSecondKnight = DamageSecond;
            ks.hpOfFirstKnight = HpFirst;
            ks.hpOfSecondKnight = HpSecond;
            ks.LivesOfFirstKnights = LivesFirst;
            ks.LivesOfSecondKnights = LivesSecond;
            ks.HealsFirstKnight = HealsFirst;
            ks.HealsSecondKnight = HealsSecond;
            indexFirst = IndexFirst;
            indexSecond = IndexSecond;
        }

        private void BtYes_Click(object sender, RoutedEventArgs e)
        {
            LabelImprove.Visibility = Visibility.Hidden;
            BtYes.Visibility = Visibility.Hidden;
            PressButt.Visibility = Visibility.Visible;
            CbOfSource.Visibility = Visibility.Visible;
            TbGoldFirst.Visibility = Visibility.Visible;
            TbGoldSecond.Visibility = Visibility.Visible;
            LabelFirstGold.Visibility = Visibility.Visible;
            LabelSecondGold.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (CbOfSource.SelectedIndex)
            {
                case 0:
                    CursedCource.Visibility = Visibility.Hidden;
                    EverSource.Visibility = Visibility.Hidden;
                    DefoltSource.Visibility = Visibility.Visible;
                    PbOfSource.Visibility = Visibility.Visible;
                    AgainSource.Visibility = Visibility.Visible;
                    CbOfStatsFirst.Visibility = Visibility.Visible;
                    CbOfStatsSecond.Visibility = Visibility.Visible;
                    ImproveStatsFirst.Visibility = Visibility.Visible;
                    ImproveStatsSecond.Visibility = Visibility.Visible;
                    LabelFirstCost.Visibility = Visibility.Visible;
                    LabelSecondCost.Visibility = Visibility.Visible;
                    LabelFirstImprove.Visibility = Visibility.Visible;
                    LabelSecondImprove.Visibility = Visibility.Visible;
                    CostOfFirst.Visibility = Visibility.Visible;
                    CostOfSecond.Visibility = Visibility.Visible;
                    ImproveFirstKnight.Visibility = Visibility.Visible;
                    ImproveSecondKnight.Visibility = Visibility.Visible;
                    PbOfSource.Maximum = 1000;
                    PbOfSource.Value = 1000;
                    break;
                case 1:
                    CursedCource.Visibility = Visibility.Hidden;
                    EverSource.Visibility = Visibility.Visible;
                    DefoltSource.Visibility = Visibility.Hidden;
                    PbOfSource.Visibility = Visibility.Visible;
                    AgainSource.Visibility = Visibility.Visible;
                    CbOfStatsFirst.Visibility = Visibility.Visible;
                    CbOfStatsSecond.Visibility = Visibility.Visible;
                    ImproveStatsFirst.Visibility = Visibility.Visible;
                    ImproveStatsSecond.Visibility = Visibility.Visible;
                    LabelFirstCost.Visibility = Visibility.Visible;
                    LabelSecondCost.Visibility = Visibility.Visible;
                    LabelFirstImprove.Visibility = Visibility.Visible;
                    LabelSecondImprove.Visibility = Visibility.Visible;
                    CostOfFirst.Visibility = Visibility.Visible;
                    CostOfSecond.Visibility = Visibility.Visible;
                    ImproveFirstKnight.Visibility = Visibility.Visible;
                    ImproveSecondKnight.Visibility = Visibility.Visible;
                    PbOfSource.Maximum = 1000;
                    PbOfSource.Value = 1000;
                    break;
                case 2:
                    CursedCource.Visibility = Visibility.Visible;
                    EverSource.Visibility = Visibility.Hidden;
                    DefoltSource.Visibility = Visibility.Hidden;
                    PbOfSource.Visibility = Visibility.Visible;
                    AgainSource.Visibility = Visibility.Visible;
                    CbOfStatsFirst.Visibility = Visibility.Visible;
                    CbOfStatsSecond.Visibility = Visibility.Visible;
                    ImproveStatsFirst.Visibility = Visibility.Visible;
                    ImproveStatsSecond.Visibility = Visibility.Visible;
                    LabelFirstCost.Visibility = Visibility.Visible;
                    LabelSecondCost.Visibility = Visibility.Visible;
                    LabelFirstImprove.Visibility = Visibility.Visible;
                    LabelSecondImprove.Visibility = Visibility.Visible;
                    CostOfFirst.Visibility = Visibility.Visible;
                    CostOfSecond.Visibility = Visibility.Visible;
                    ImproveFirstKnight.Visibility = Visibility.Visible;
                    ImproveSecondKnight.Visibility = Visibility.Visible;
                    PbOfSource.Maximum = 1000;
                    PbOfSource.Value = 1000;
                    break;
            }

        }

        private void ImproveFirstKnight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ks.GoldenFirstKnight = Convert.ToDouble(TbGoldFirst.Text);
                switch (CbOfStatsFirst.SelectedIndex)
                {
                    case 0:
                        if (PbOfSource.Value <= 0)
                        {
                            ImproveFirstKnight.IsEnabled = false;
                        }
                        else
                        {
                            if (ks.GoldenFirstKnight < Convert.ToDouble(CostOfFirst.Text))
                            {
                                MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                            else
                            {
                                if (ks.GoldenFirstKnight <= 0)
                                {
                                    TbGoldFirst.Text = "0";
                                    MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                else
                                {
                                    ks.GoldenFirstKnight -= Convert.ToDouble(CostOfFirst.Text);
                                    TbGoldFirst.Text = Convert.ToString(ks.GoldenFirstKnight);
                                    ks.DamageFirstKnight += Convert.ToInt32(ImproveStatsFirst.Text);
                                    MessageBox.Show($"Атака рыцаря - {Convert.ToString(ks.DamageFirstKnight)}");
                                    PbOfSource.Value -= Convert.ToInt32(ImproveStatsFirst.Text);
                                }
                            }
                        }
                        break;
                    case 1:
                        if (PbOfSource.Value <= 0)
                        {
                            ImproveFirstKnight.IsEnabled = false;
                        }
                        else
                        {
                            if (ks.GoldenFirstKnight < Convert.ToDouble(CostOfFirst.Text))
                            {
                                MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                            else
                            {
                                if (ks.GoldenFirstKnight <= 0)
                                {
                                    TbGoldFirst.Text = "0";
                                    MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                else
                                {
                                    ks.GoldenFirstKnight -= Convert.ToDouble(CostOfFirst.Text);
                                    TbGoldFirst.Text = Convert.ToString(ks.GoldenFirstKnight);
                                    ks.hpOfFirstKnight += Convert.ToInt32(ImproveStatsFirst.Text);
                                    MessageBox.Show($"Здоровье рыцаря - {Convert.ToString(ks.hpOfFirstKnight)}");
                                    PbOfSource.Value -= Convert.ToInt32(ImproveStatsFirst.Text);
                                }
                            }
                        }
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Золота нет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void AgainSource_Click(object sender, RoutedEventArgs e)
        {
            PbOfSource.Value = 1000;
            ImproveFirstKnight.IsEnabled = true;
        }

        private void ImproveSecondKnight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ks.GoldenSecondKnight = Convert.ToDouble(TbGoldSecond.Text);
                switch (CbOfStatsSecond.SelectedIndex)
                {
                    case 0:
                        if (PbOfSource.Value <= 0)
                        {
                            ImproveSecondKnight.IsEnabled = false;
                        }
                        else
                        {
                            if (ks.GoldenSecondKnight < Convert.ToDouble(CostOfSecond.Text))
                            {
                                MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                            else
                            {
                                if (ks.GoldenSecondKnight <= 0)
                                {
                                    TbGoldSecond.Text = "0";
                                    MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                else
                                {
                                    ks.GoldenSecondKnight -= Convert.ToDouble(CostOfSecond.Text);
                                    TbGoldSecond.Text = Convert.ToString(ks.GoldenSecondKnight);
                                    ks.DamageSecondKnight += Convert.ToInt32(ImproveStatsSecond.Text);
                                    MessageBox.Show($"Атака рыцаря - {Convert.ToString(ks.DamageSecondKnight)}");
                                    PbOfSource.Value -= Convert.ToInt32(ImproveStatsSecond.Text);
                                }
                            }
                        }
                        break;
                    case 1:
                        if (PbOfSource.Value <= 0)
                        {
                            ImproveSecondKnight.IsEnabled = false;
                        }
                        else
                        {
                            if (ks.GoldenSecondKnight < Convert.ToDouble(CostOfSecond.Text))
                            {
                                MessageBox.Show("Недостаточно золота!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                            else
                            {
                                if (ks.GoldenSecondKnight <= 0)
                                {
                                    TbGoldSecond.Text = "0";
                                    MessageBox.Show("Золото кончилось", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                else
                                {
                                    ks.GoldenSecondKnight -= Convert.ToDouble(CostOfSecond.Text);
                                    TbGoldSecond.Text = Convert.ToString(ks.GoldenSecondKnight);
                                    ks.hpOfSecondKnight += Convert.ToInt32(ImproveStatsSecond.Text);
                                    MessageBox.Show($"Здоровье рыцаря - {Convert.ToString(ks.hpOfSecondKnight)}");
                                    PbOfSource.Value -= Convert.ToInt32(ImproveStatsSecond.Text);
                                }
                            }
                        }
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Золота нет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void PlayBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Game(ks.DamageFirstKnight, ks.DamageSecondKnight, ks.hpOfFirstKnight, ks.hpOfSecondKnight, ks.LivesOfFirstKnights, ks.LivesOfSecondKnights, ks.HealsFirstKnight, ks.HealsSecondKnight, indexFirst, indexSecond));
        }
    }
}
