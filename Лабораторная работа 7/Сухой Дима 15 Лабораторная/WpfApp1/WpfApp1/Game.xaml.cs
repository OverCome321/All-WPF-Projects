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
using ClassLibrary5;
using Chemist;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        ChemistClass ch = new ChemistClass();
        Unit un = new Unit();
        Mag mg = new Mag();
        Shooter sh = new Shooter();
        public Game(int HpOfFirstArmy,int atackFirstArmy, int ArrowOrManaFirst, double hpOfChemistsFirst, int countoOfChemistFirst, int HpOfSecondArmy, int atackOfSecondArmy, int ManaOrArrowSecondArmy, double hpOfChemistsSecond, int countOfChemistsSecond, int typeOfFirst, int typeOfSecond)
        {
            InitializeComponent();
            switch (typeOfFirst)
            {
                case 0:
                    switch (typeOfSecond)
                    {
                        case 0:
                            FirstArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            SecondArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            ThirtArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            FirstArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            SecondArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            ThirtArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            un.hpOfFirstArmy = HpOfFirstArmy;
                            BpHpOfFirstArmy.Maximum = un.hpOfFirstArmy;
                            BpHpOfFirstArmy.Value = un.hpOfFirstArmy;
                            un.hpOfSecondArmy = HpOfSecondArmy;
                            BpHpOfSecondArmy.Maximum = un.hpOfSecondArmy;
                            BpHpOfSecondArmy.Value = un.hpOfSecondArmy;
                            un.AttackFirstArmy = atackFirstArmy;
                            un.AttackSecondArmy = atackOfSecondArmy;
                            mg.ManaFirst = ArrowOrManaFirst;
                            mg.ManaSecond = ManaOrArrowSecondArmy;
                            ch.HpOfChemistsFirst = hpOfChemistsFirst;
                            ch.CountOfChemistFirst = countoOfChemistFirst;
                            ch.HPOfChemistsSecond = hpOfChemistsSecond;
                            ch.CountOfChemistSecond = countOfChemistsSecond;
                            TbCountOfChemistFirst.Text = Convert.ToString(ch.CountOfChemistFirst);
                            TbCountOfChemistsSecond.Text = Convert.ToString(ch.CountOfChemistSecond);
                            TbCountOfManaFirst.Text = Convert.ToString(mg.ManaFirst);
                            TbCountOfManaSecond.Text = Convert.ToString(mg.ManaSecond);
                            TbCountOfArrowFirst.Visibility = Visibility.Hidden;
                            TbCountOfArrowSecond.Visibility = Visibility.Hidden;
                            LabelCountOfFirstArrow.Visibility = Visibility.Hidden;
                            LabelCountOfSecondArrow.Visibility = Visibility.Hidden;
                            TbCountOfManaFirst.IsEnabled = false;
                            TbCountOfManaSecond.IsEnabled = false;
                            TbCountOfChemistFirst.IsEnabled = false;
                            TbCountOfChemistsSecond.IsEnabled = false;
                            break;
                        case 1:
                            FirstArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            SecondArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            ThirtArrowOfFirstArmy.Visibility = Visibility.Hidden;
                            FirstMagOfSecondArmy.Visibility = Visibility.Hidden;
                            SecondMagOfSecondArmy.Visibility = Visibility.Hidden;
                            ThirtMagOfSecondArmy.Visibility = Visibility.Hidden;
                            un.hpOfFirstArmy = HpOfFirstArmy;
                            BpHpOfFirstArmy.Maximum = un.hpOfFirstArmy;
                            BpHpOfFirstArmy.Value = un.hpOfFirstArmy;
                            un.hpOfSecondArmy = HpOfSecondArmy;
                            BpHpOfSecondArmy.Maximum = un.hpOfSecondArmy;
                            BpHpOfSecondArmy.Value = un.hpOfSecondArmy;
                            un.AttackFirstArmy = atackFirstArmy;
                            un.AttackSecondArmy = atackOfSecondArmy;
                            mg.ManaFirst = ArrowOrManaFirst;
                            sh.ArrowSecond = ManaOrArrowSecondArmy;
                            ch.HpOfChemistsFirst = hpOfChemistsFirst;
                            ch.CountOfChemistFirst = countoOfChemistFirst;
                            ch.HPOfChemistsSecond = hpOfChemistsSecond;
                            ch.CountOfChemistSecond = countOfChemistsSecond;
                            TbCountOfChemistFirst.Text = Convert.ToString(ch.CountOfChemistFirst);
                            TbCountOfChemistsSecond.Text = Convert.ToString(ch.CountOfChemistSecond);
                            TbCountOfManaFirst.Text = Convert.ToString(mg.ManaFirst);
                            TbCountOfArrowSecond.Text = Convert.ToString(sh.ArrowSecond);
                            TbCountOfArrowFirst.Visibility = Visibility.Hidden;
                            LabelCountOfFirstArrow.Visibility = Visibility.Hidden;
                            TbCountOfManaSecond.Visibility = Visibility.Hidden;
                            LabelCountOfSecondMana.Visibility = Visibility.Hidden;
                            TbCountOfManaFirst.IsEnabled = false;
                            TbCountOfArrowSecond.IsEnabled = false;
                            TbCountOfChemistFirst.IsEnabled = false;
                            TbCountOfChemistsSecond.IsEnabled = false;
                            break;
                    }
                    break;
                case 1:
                    switch (typeOfSecond)
                    {
                        case 0:
                            FirstMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            SecondMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            ThirtMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            FirstArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            SecondArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            ThirtArrowOfSecondArmy.Visibility = Visibility.Hidden;
                            un.hpOfFirstArmy = HpOfFirstArmy;
                            BpHpOfFirstArmy.Maximum = un.hpOfFirstArmy;
                            BpHpOfFirstArmy.Value = un.hpOfFirstArmy;
                            un.hpOfSecondArmy = HpOfSecondArmy;
                            BpHpOfSecondArmy.Maximum = un.hpOfSecondArmy;
                            BpHpOfSecondArmy.Value = un.hpOfSecondArmy;
                            un.AttackFirstArmy = atackFirstArmy;
                            un.AttackSecondArmy = atackOfSecondArmy;
                            sh.ArrowFirst = ArrowOrManaFirst;
                            mg.ManaSecond = ManaOrArrowSecondArmy;
                            ch.HpOfChemistsFirst = hpOfChemistsFirst;
                            ch.CountOfChemistFirst = countoOfChemistFirst;
                            ch.HPOfChemistsSecond = hpOfChemistsSecond;
                            ch.CountOfChemistSecond = countOfChemistsSecond;
                            TbCountOfChemistFirst.Text = Convert.ToString(ch.CountOfChemistFirst);
                            TbCountOfChemistsSecond.Text = Convert.ToString(ch.CountOfChemistSecond);
                            TbCountOfArrowFirst.Text = Convert.ToString(sh.ArrowFirst);
                            TbCountOfManaSecond.Text = Convert.ToString(mg.ManaSecond);
                            TbCountOfManaFirst.Visibility = Visibility.Hidden;
                            LabelCountOfFirstMana.Visibility = Visibility.Hidden;
                            TbCountOfArrowSecond.Visibility = Visibility.Hidden;
                            LabelCountOfSecondArrow.Visibility = Visibility.Hidden;
                            TbCountOfArrowFirst.IsEnabled = false;
                            TbCountOfManaSecond.IsEnabled = false;
                            TbCountOfChemistFirst.IsEnabled = false;
                            TbCountOfChemistsSecond.IsEnabled = false;
                            break;
                        case 1:
                            FirstMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            SecondMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            ThirtMagOfFisrtArmy.Visibility = Visibility.Hidden;
                            FirstMagOfSecondArmy.Visibility = Visibility.Hidden;
                            SecondMagOfSecondArmy.Visibility = Visibility.Hidden;
                            ThirtMagOfSecondArmy.Visibility = Visibility.Hidden;
                            un.hpOfFirstArmy = HpOfFirstArmy;
                            BpHpOfFirstArmy.Maximum = un.hpOfFirstArmy;
                            BpHpOfFirstArmy.Value = un.hpOfFirstArmy;
                            un.hpOfSecondArmy = HpOfSecondArmy;
                            BpHpOfSecondArmy.Maximum = un.hpOfSecondArmy;
                            BpHpOfSecondArmy.Value = un.hpOfSecondArmy;
                            un.AttackFirstArmy = atackFirstArmy;
                            un.AttackSecondArmy = atackOfSecondArmy;
                            sh.ArrowFirst = ArrowOrManaFirst;
                            sh.ArrowSecond = ManaOrArrowSecondArmy;
                            ch.HpOfChemistsFirst = hpOfChemistsFirst;
                            ch.CountOfChemistFirst = countoOfChemistFirst;
                            ch.HPOfChemistsSecond = hpOfChemistsSecond;
                            ch.CountOfChemistSecond = countOfChemistsSecond;
                            TbCountOfChemistFirst.Text = Convert.ToString(ch.CountOfChemistFirst);
                            TbCountOfChemistsSecond.Text = Convert.ToString(ch.CountOfChemistSecond);
                            TbCountOfArrowFirst.Text = Convert.ToString(sh.ArrowFirst);
                            TbCountOfArrowSecond.Text = Convert.ToString(sh.ArrowSecond);
                            TbCountOfManaFirst.Visibility = Visibility.Hidden;
                            LabelCountOfFirstMana.Visibility = Visibility.Hidden;
                            TbCountOfManaSecond.Visibility = Visibility.Hidden;
                            LabelCountOfSecondMana.Visibility = Visibility.Hidden;
                            TbCountOfArrowFirst.IsEnabled = false;
                            TbCountOfArrowSecond.IsEnabled = false;
                            TbCountOfChemistFirst.IsEnabled = false;
                            TbCountOfChemistsSecond.IsEnabled = false;
                            break;
                    }
                    break;
            }
        }

        private void DamageFirst_Click(object sender, RoutedEventArgs e)
        {
            if (BpHpOfSecondArmy.Value <= 0)
            {
                MessageBox.Show("Первая армия победила!", "Поздравляю", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MainMenu());
            }
            else
            {
                BpHpOfSecondArmy.Value = un.DoAttackFirstArmy();
            }
        }

        private void UseChemistFirst_Click(object sender, RoutedEventArgs e)
        {
            if (ch.CountOfChemistFirst == 0)
            {
                UseChemistFirst.IsEnabled = false;
            }
            else
            {
                ch.CountOfChemistsFirstMethod();
                TbCountOfChemistFirst.Text = Convert.ToString(ch.CountOfChemistFirst);
                BpHpOfFirstArmy.Value = ch.HpOfChemistFirstMethod(BpHpOfFirstArmy.Value);
            }
        }

        private void DamageSecond_Click(object sender, RoutedEventArgs e)
        {
            if (BpHpOfFirstArmy.Value <= 0)
            {
                MessageBox.Show("Вторая армия победила!", "Поздравляю", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MainMenu());
            }
            else
            {
                BpHpOfFirstArmy.Value = un.DoAttackSecondArmy();
            }
        }

        private void UseChemistSecond_Click(object sender, RoutedEventArgs e)
        {
            if (ch.CountOfChemistSecond == 0)
            {
                UseChemistSecond.IsEnabled = false;
            }
            else
            {
                ch.CountOfChemistsSecondMethod();
                TbCountOfChemistsSecond.Text = Convert.ToString(ch.CountOfChemistSecond);
                BpHpOfSecondArmy.Value = ch.HpOfChemistsSecondMethod(BpHpOfSecondArmy.Value);
            }
        }
    }
}
