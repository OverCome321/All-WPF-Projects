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
using Chemist;
using ClassLibrary5;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        ChemistClass ch = new ChemistClass();
        Unit un = new Unit();
        Mag mg = new Mag();
        Shooter sh = new Shooter();
        int TypeOfFirstArmy = 0;
        int TypeOfSecondArmy = 0;
        public MainMenu()
        {
            InitializeComponent();
            LabelHpOfFirstArmy.Visibility = Visibility.Hidden;
            TbHpOfFirstArmy.Visibility = Visibility.Hidden;
            LabelDamageOfFirstArmy.Visibility = Visibility.Hidden;
            TbDamageOfFirstArmy.Visibility = Visibility.Hidden;
            CountOfArrowFirstArmy.Visibility = Visibility.Hidden;
            TbOfCountArrowFirstArmy.Visibility = Visibility.Hidden;
            CountOfManaFirstArmy.Visibility = Visibility.Hidden;
            TbOfCountManaFirstArmy.Visibility = Visibility.Hidden;
            LabelHpOfSecondArmy.Visibility = Visibility.Hidden;
            TbHpOfSecondArmy.Visibility = Visibility.Hidden;
            LabelDamageOfSecondArmy.Visibility = Visibility.Hidden;
            TbDamageOfSecondArmy.Visibility = Visibility.Hidden;
            CountOfArrowSecondArmy.Visibility = Visibility.Hidden;
            TbOfCountArrowSecondArmy.Visibility = Visibility.Hidden;
            CountOfManaSecondArmy.Visibility = Visibility.Hidden;
            TbOfCountManaSecondArmy.Visibility = Visibility.Hidden;
            LabelHpOfFirstChemist.Visibility = Visibility.Hidden;
            LabelCountOfFirstChemist.Visibility = Visibility.Hidden;
            TbCountOfFirstChemist.Visibility = Visibility.Hidden;
            TbHpOfFirstChemist.Visibility = Visibility.Hidden;
            LabelHpOfSecondChemist.Visibility = Visibility.Hidden;
            LabelCountOfSecondChemist.Visibility = Visibility.Hidden;
            TbCountOfSecondChemist.Visibility = Visibility.Hidden;
            TbHpOfSecondChemist.Visibility = Visibility.Hidden;
        }

        private void UseTypeOfArmyFirst_Click(object sender, RoutedEventArgs e)
        {
            switch(CbTypesOfArmyFirst.SelectedIndex)
            {
                case 0:
                    LabelHpOfFirstArmy.Visibility = Visibility.Visible;
                    TbHpOfFirstArmy.Visibility = Visibility.Visible;
                    LabelDamageOfFirstArmy.Visibility = Visibility.Visible;
                    TbDamageOfFirstArmy.Visibility = Visibility.Visible;
                    CountOfManaFirstArmy.Visibility = Visibility.Visible;
                    TbOfCountManaFirstArmy.Visibility = Visibility.Visible;
                    LabelHpOfFirstChemist.Visibility = Visibility.Visible;
                    LabelCountOfFirstChemist.Visibility = Visibility.Visible;
                    TbCountOfFirstChemist.Visibility = Visibility.Visible;
                    TbHpOfFirstChemist.Visibility = Visibility.Visible;
                    UseTypeOfArmyFirst.IsEnabled = false;
                    CbTypesOfArmyFirst.IsEnabled = false;
                    TypeOfFirstArmy = 0;
                    break;
                    case 1:
                    LabelHpOfFirstArmy.Visibility = Visibility.Visible;
                    TbHpOfFirstArmy.Visibility = Visibility.Visible;
                    LabelDamageOfFirstArmy.Visibility = Visibility.Visible;
                    TbDamageOfFirstArmy.Visibility = Visibility.Visible;
                    CountOfArrowFirstArmy.Visibility = Visibility.Visible;
                    TbOfCountArrowFirstArmy.Visibility = Visibility.Visible;
                    LabelHpOfFirstChemist.Visibility = Visibility.Visible;
                    LabelCountOfFirstChemist.Visibility = Visibility.Visible;
                    TbCountOfFirstChemist.Visibility = Visibility.Visible;
                    TbHpOfFirstChemist.Visibility = Visibility.Visible;
                    UseTypeOfArmyFirst.IsEnabled = false;
                    CbTypesOfArmyFirst.IsEnabled = false;
                    TypeOfFirstArmy = 1;
                    break;
            }
        }

        private void UseTypeOfArmySecond_Click(object sender, RoutedEventArgs e)
        {
            switch (CbTypesOfArmySecond.SelectedIndex)
            {
                case 0:
                    LabelHpOfSecondArmy.Visibility = Visibility.Visible;
                    TbHpOfSecondArmy.Visibility = Visibility.Visible;
                    LabelDamageOfSecondArmy.Visibility = Visibility.Visible;
                    TbDamageOfSecondArmy.Visibility = Visibility.Visible;
                    CountOfManaSecondArmy.Visibility = Visibility.Visible;
                    TbOfCountManaSecondArmy.Visibility = Visibility.Visible;
                    LabelHpOfSecondChemist.Visibility = Visibility.Visible;
                    LabelCountOfSecondChemist.Visibility = Visibility.Visible;
                    TbCountOfSecondChemist.Visibility = Visibility.Visible;
                    TbHpOfSecondChemist.Visibility = Visibility.Visible;
                    UseTypeOfArmySecond.IsEnabled = false;
                    CbTypesOfArmySecond.IsEnabled = false;
                    TypeOfSecondArmy = 0;
                    break;
                case 1:
                    LabelHpOfSecondArmy.Visibility = Visibility.Visible;
                    TbHpOfSecondArmy.Visibility = Visibility.Visible;
                    LabelDamageOfSecondArmy.Visibility = Visibility.Visible;
                    TbDamageOfSecondArmy.Visibility = Visibility.Visible;
                    CountOfArrowSecondArmy.Visibility = Visibility.Visible;
                    TbOfCountArrowSecondArmy.Visibility = Visibility.Visible;
                    LabelHpOfSecondChemist.Visibility = Visibility.Visible;
                    LabelCountOfSecondChemist.Visibility = Visibility.Visible;
                    TbCountOfSecondChemist.Visibility = Visibility.Visible;
                    TbHpOfSecondChemist.Visibility = Visibility.Visible;
                    UseTypeOfArmySecond.IsEnabled = false;
                    CbTypesOfArmySecond.IsEnabled = false;
                    TypeOfSecondArmy = 1;
                    break;
            }
        }

        private void UseAllFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (CbTypesOfArmyFirst.SelectedIndex)
                {
                    case 0:
                        un.hpOfFirstArmy = Convert.ToInt32(TbHpOfFirstArmy.Text);
                        un.AttackFirstArmy = Convert.ToInt32(TbDamageOfFirstArmy.Text);
                        mg.ManaFirst = Convert.ToInt32(TbOfCountManaFirstArmy.Text);
                        ch.HpOfChemistsFirst = Convert.ToDouble(TbHpOfFirstChemist.Text);
                        ch.CountOfChemistFirst = Convert.ToInt32(TbCountOfFirstChemist.Text);
                        UseAllFirst.IsEnabled = false;
                        TbHpOfFirstArmy.IsEnabled = false;
                        TbDamageOfFirstArmy.IsEnabled = false;
                        TbOfCountManaFirstArmy.IsEnabled = false;
                        TbHpOfFirstChemist.IsEnabled = false;
                        TbCountOfFirstChemist.IsEnabled = false;
                        MessageBox.Show("Параметры применены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case 1:
                        un.hpOfFirstArmy = Convert.ToInt32(TbHpOfFirstArmy.Text);
                        un.AttackFirstArmy = Convert.ToInt32(TbDamageOfFirstArmy.Text);
                        sh.ArrowFirst = Convert.ToInt32(TbOfCountArrowFirstArmy.Text);
                        ch.HpOfChemistsFirst = Convert.ToDouble(TbHpOfFirstChemist.Text);
                        ch.CountOfChemistFirst = Convert.ToInt32(TbCountOfFirstChemist.Text);
                        UseAllFirst.IsEnabled = false;
                        TbHpOfFirstArmy.IsEnabled = false;
                        TbDamageOfFirstArmy.IsEnabled = false;
                        TbOfCountArrowFirstArmy.IsEnabled = false;
                        TbHpOfFirstChemist.IsEnabled = false;
                        TbCountOfFirstChemist.IsEnabled = false;
                        MessageBox.Show("Параметры применены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;


                }
                
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UseAllSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch(CbTypesOfArmySecond.SelectedIndex)
                {
                    case 0:
                        un.hpOfSecondArmy = Convert.ToInt32(TbHpOfSecondArmy.Text);
                        un.AttackSecondArmy = Convert.ToInt32(TbDamageOfSecondArmy.Text);
                        mg.ManaSecond = Convert.ToInt32(TbOfCountManaSecondArmy.Text);
                        ch.HPOfChemistsSecond = Convert.ToDouble(TbHpOfSecondChemist.Text);
                        ch.CountOfChemistSecond = Convert.ToInt32(TbCountOfSecondChemist.Text);
                        UseAllSecond.IsEnabled = false;
                        TbHpOfSecondArmy.IsEnabled = false;
                        TbDamageOfSecondArmy.IsEnabled = false;
                        TbOfCountManaSecondArmy.IsEnabled = false;
                        TbHpOfSecondChemist.IsEnabled = false;
                        TbCountOfSecondChemist.IsEnabled = false;
                        MessageBox.Show("Параметры применены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case 1:
                        un.hpOfSecondArmy = Convert.ToInt32(TbHpOfSecondArmy.Text);
                        un.AttackSecondArmy = Convert.ToInt32(TbDamageOfSecondArmy.Text);
                        sh.ArrowSecond = Convert.ToInt32(TbOfCountArrowSecondArmy.Text);
                        ch.HPOfChemistsSecond = Convert.ToDouble(TbHpOfSecondChemist.Text);
                        ch.CountOfChemistSecond = Convert.ToInt32(TbCountOfSecondChemist.Text);
                        UseAllSecond.IsEnabled = false;
                        TbHpOfSecondArmy.IsEnabled = false;
                        TbDamageOfSecondArmy.IsEnabled = false;
                        TbOfCountArrowSecondArmy.IsEnabled = false;
                        TbHpOfSecondChemist.IsEnabled = false;
                        TbCountOfSecondChemist.IsEnabled = false;
                        MessageBox.Show("Параметры применены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (TypeOfFirstArmy)
                {
                    case 0:
                        switch (TypeOfSecondArmy)
                        {
                            case 0:
                                NavigationService.Navigate(new Game(un.hpOfFirstArmy, un.AttackFirstArmy, mg.ManaFirst, ch.HpOfChemistsFirst, ch.CountOfChemistFirst, un.hpOfSecondArmy, un.AttackSecondArmy, mg.ManaSecond, ch.HPOfChemistsSecond, ch.CountOfChemistSecond, TypeOfFirstArmy, TypeOfSecondArmy));
                                break;
                            case 1:
                                NavigationService.Navigate(new Game(un.hpOfFirstArmy, un.AttackFirstArmy, mg.ManaFirst, ch.HpOfChemistsFirst, ch.CountOfChemistFirst, un.hpOfSecondArmy, un.AttackSecondArmy, sh.ArrowSecond, ch.HPOfChemistsSecond, ch.CountOfChemistSecond, TypeOfFirstArmy, TypeOfSecondArmy));
                                break;
                        }
                        break;
                    case 1:
                        switch (TypeOfSecondArmy)
                        {
                            case 0:
                                NavigationService.Navigate(new Game(un.hpOfFirstArmy, un.AttackFirstArmy, sh.ArrowFirst, ch.HpOfChemistsFirst, ch.CountOfChemistFirst, un.hpOfSecondArmy, un.AttackSecondArmy, mg.ManaSecond, ch.HPOfChemistsSecond, ch.CountOfChemistSecond, TypeOfFirstArmy, TypeOfSecondArmy));
                                break;
                            case 1:
                                NavigationService.Navigate(new Game(un.hpOfFirstArmy, un.AttackFirstArmy, sh.ArrowFirst, ch.HpOfChemistsFirst, ch.CountOfChemistFirst, un.hpOfSecondArmy, un.AttackSecondArmy, sh.ArrowSecond, ch.HPOfChemistsSecond, ch.CountOfChemistSecond, TypeOfFirstArmy, TypeOfSecondArmy));
                                break;
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
