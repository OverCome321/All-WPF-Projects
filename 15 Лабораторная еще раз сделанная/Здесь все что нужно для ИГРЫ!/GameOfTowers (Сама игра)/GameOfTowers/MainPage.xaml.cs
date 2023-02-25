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
using ClassLibrary5Unit;
using _4;
namespace GameOfTowers
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        //Объявляем эксземпляры классов библиотек (Макса и Димы)
        Tower tw = new Tower(); // Основной класс библиотеки макса 
        Unit un = new Unit(); // Основной класс библиотеки димы
        Mag mg = new Mag(); // Наследуемый класс библиотеки димы
        Shooter sh = new Shooter(); // Наследуемый класс библиотеки димы
        public MainPage()
        {
            // Здесь мы делаем все объекты которые находятся ниже комбобокса с выбором типа войска, невидемыми, чтобы после нажатия кнопки использовать в окне с армией мы эти объекты показали, все просто
            InitializeComponent();
            TbHpOfArmy.Visibility = Visibility.Hidden;
            TbDamageOfArmy.Visibility = Visibility.Hidden;
            TbCountOfArrow.Visibility = Visibility.Hidden;
            TbCountOfMana.Visibility = Visibility.Hidden;
            LabelCountOfArrow.Visibility = Visibility.Hidden;
            LabelCountOfMana.Visibility = Visibility.Hidden;
            LabelDamageOfArmy.Visibility = Visibility.Hidden;
            LabelHpOfArmy.Visibility = Visibility.Hidden;
            UseFirst.Visibility = Visibility.Hidden;
        }
        // Селим прицнессу в башню
        private void PrincessYes_Click(object sender, RoutedEventArgs e)
        {
            tw.Princess = true;
            MessageBox.Show("Вы поселили принцессу в башню!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        // Выселяем принцессу из башни
        private void PrincessNo_Click(object sender, RoutedEventArgs e)
        {
            tw.Princess = false;
            MessageBox.Show("Вы выселили принцессу из башню!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Применяем параметры для башни, все параметры обязательно должны подходить под условия и параметры, если же они не подходят то у нас обрабатывается исключение cathc где нам выдаст messagebox с ошибкой!
        private void UseSecond_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tw.MaxHP = Convert.ToInt32(HpOfTower.Text);
                tw.towerDamage = Convert.ToInt32(DamageOfTower.Text);
                HpOfTower.IsEnabled = false;
                DamageOfTower.IsEnabled = false;
                UseSecond.IsEnabled = false;
                PrincessYes.IsEnabled = false;
                PrincessNo.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Это кнопка отвечает за выбор класса нашего войска и показа дальнейших объектов которые в самом начале нам были недоступны 
        private void UseArmyCb_Click(object sender, RoutedEventArgs e)
        {
            switch (CbOfArmy.SelectedIndex)
            {
                case 0:
                    TbHpOfArmy.Visibility = Visibility.Visible;
                    TbDamageOfArmy.Visibility = Visibility.Visible;
                    TbCountOfMana.Visibility = Visibility.Visible;
                    LabelCountOfMana.Visibility = Visibility.Visible;
                    LabelDamageOfArmy.Visibility = Visibility.Visible;
                    LabelHpOfArmy.Visibility = Visibility.Visible;
                    UseFirst.Visibility = Visibility.Visible;
                    UseArmyCb.IsEnabled = false;
                    CbOfArmy.IsEnabled = false;
                    break;
                case 1:
                    TbHpOfArmy.Visibility = Visibility.Visible;
                    TbDamageOfArmy.Visibility = Visibility.Visible;
                    TbCountOfArrow.Visibility = Visibility.Visible;
                    LabelCountOfArrow.Visibility = Visibility.Visible;
                    LabelDamageOfArmy.Visibility = Visibility.Visible;
                    LabelHpOfArmy.Visibility = Visibility.Visible;
                    UseFirst.Visibility = Visibility.Visible;
                    UseArmyCb.IsEnabled = false;
                    CbOfArmy.IsEnabled = false;
                    break;
            }
        }
        // Здесь мы применяем все параметры для нашей армии и если опять же мы ввели что-то некорректно, то он обработает исключение catch и выдаст нам ошибку, а если все будет верно то обработает try
        private void UseFirst_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch(CbOfArmy.SelectedIndex)
                {
                    case 0:
                        mg.mana = Convert.ToInt32(TbCountOfMana.Text);
                        un.hpUnit = Convert.ToInt32(TbHpOfArmy.Text);
                        un.damageUnit = Convert.ToInt32(TbDamageOfArmy.Text);
                        TbHpOfArmy.IsEnabled = false;
                        TbDamageOfArmy.IsEnabled = false;
                        TbCountOfMana.IsEnabled = false;
                        UseFirst.IsEnabled = false;
                        break;
                    case 1:
                        sh.arrow = Convert.ToInt32(TbCountOfArrow.Text);
                        un.hpUnit = Convert.ToInt32(TbHpOfArmy.Text);
                        un.damageUnit = Convert.ToInt32(TbDamageOfArmy.Text);
                        TbHpOfArmy.IsEnabled = false;
                        TbDamageOfArmy.IsEnabled = false;
                        TbCountOfArrow.IsEnabled = false;
                        UseFirst.IsEnabled = false;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // Здесь мы идем в бой
        private void NextStep_Click(object sender, RoutedEventArgs e)
        {
            switch(CbOfArmy.SelectedIndex)
            {
                case 0:
                    int mag = 0;
                    NavigationService.Navigate(new Game(tw.Princess,tw.MaxHP, tw.towerDamage,un.hpUnit,un.damageUnit,mg.mana, mag)); // Эта строка отвечает за переход между страницами, то есть чтобы перейти с текущей страницы на следующую мы должны прописать это и в скобках передать те параметры которые будет принимать страница Game
                    break;
                case 1:
                    int shooter = 1;
                    NavigationService.Navigate(new Game(tw.Princess, tw.MaxHP, tw.towerDamage, un.hpUnit, un.damageUnit, sh.arrow, shooter));
                    break;
            }
        }
    }
}
