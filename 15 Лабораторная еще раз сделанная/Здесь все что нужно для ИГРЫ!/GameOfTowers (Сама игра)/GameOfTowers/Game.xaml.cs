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
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        //Здесь мы объявляем экземпляр класса от библиотек наших товарищей одногрупников (Сухой Дима и Ковальчук Максим)
        Unit un = new Unit();
        Mag mg = new Mag();
        Shooter sh = new Shooter();
        Tower tw = new Tower();
        int cheker = 0;
        // В строке ниже мы инициализируем переменные из страницы MainPage на страницу Game, если говорить по русски, то мы просто передаем значения которые мы указали на странице MainPage, странице Game, передавая через параметры!
        public Game(bool princess,int towerHp,int towerDamage, int armyHp,int armyDamage, int ManaOrArrow, int chek)
        {
            InitializeComponent();
            //Здесь идет проверка на класс, если маг то мы играем под мага, если стрелок то играем под стрелка, все просто
            switch(chek)
            {
                case 0:
                    tw.Princess = princess;
                    tw.MaxHP = towerHp;
                    tw.towerDamage = towerDamage;
                    un.hpUnit = armyHp;
                    un.damageUnit = armyDamage;
                    mg.mana = ManaOrArrow;
                    cheker = chek;
                    TowerOfBar.Maximum = tw.MaxHP;
                    TowerOfBar.Value = tw.MaxHP;
                    PbOfArmy.Maximum = un.hpUnit;
                    PbOfArmy.Value = un.hpUnit;
                    FirstShooter.Visibility = Visibility.Hidden;
                    SecondShoter.Visibility = Visibility.Hidden;
                    ThirtShoter.Visibility = Visibility.Hidden;
                    LabelManaOrArrow.Content = "Число маны";
                    ArrowOrMana.Text = Convert.ToString(mg.mana);
                    ArrowOrMana.IsEnabled = false;
                    break;
                case 1:
                    tw.Princess = princess;
                    tw.MaxHP = towerHp;
                    tw.towerDamage = towerDamage;
                    un.hpUnit = armyHp;
                    un.damageUnit = armyDamage;
                    sh.arrow = ManaOrArrow;
                    cheker = chek;
                    TowerOfBar.Maximum = tw.MaxHP;
                    TowerOfBar.Value = tw.MaxHP;
                    PbOfArmy.Maximum = un.hpUnit;
                    PbOfArmy.Value = un.hpUnit;
                    FirstMag.Visibility = Visibility.Hidden;
                    SecondMag.Visibility = Visibility.Hidden;
                    ThirtMag.Visibility = Visibility.Hidden;
                    LabelManaOrArrow.Content = "Число стрел";
                    ArrowOrMana.Text = Convert.ToString(sh.arrow);
                    ArrowOrMana.IsEnabled = false;
                    break;
            }
            //Здесь мы проверяем на наличие принцессы в башне, если она есть то мы будем видеть картинку Help me рядом с окном, а если ее нет, то и картинки тоже )
            switch(princess)
            {
                case true:
                    PrincessHere.Visibility = Visibility.Visible;
                    break;
                case false:
                    PrincessHere.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void DamageForTower_Click(object sender, RoutedEventArgs e)
        {
            //Здесь мы наносим урон по Башне, если здоровье башни меньше или равно 0, то мы проиграле, иначе  мы проверяем опять же класс нашего войска (либо маг либо стрелок) и если это маг ты проверяем количество маны, если мана меньше или равна 0 то мы проиграли, если нет то сносим хп у вышки и отнимаем ману (МАНА ВСЕГДА УМЕНЬШАЕТСЯ НА 10 ПРИ ИСПОЛЬЗОВАНИИ! Это константа) так же и со стрелком
            if (TowerOfBar.Value <= 0)
            {
                switch (tw.Princess)
                {
                    case true:
                        TowerOfBar.Value = 0;
                        MessageBox.Show("Вы уничтожили башню!\nИ к вашему счастью принцесса была внутри\nВы спасли ее, молодец!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new MainPage());
                        break;
                    case false:
                        TowerOfBar.Value = 0;
                        MessageBox.Show("Вы уничтожили башню!\nНо увы, принцессы не было в ней! Но вы все равно победили!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new MainPage());
                        break;
                }
            }
            else
            {
                switch (cheker)
                {
                    case 0:
                        if (mg.mana <= 0)
                        {
                            ArrowOrMana.Text = "0";
                            MessageBox.Show("К сожалению у вас кончилась мана!", "Поражение!", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new MainPage());
                        }
                        else
                        {
                            TowerOfBar.Value -= un.damageUnit;
                            mg.mana -= 10;
                            ArrowOrMana.Text = Convert.ToString(mg.mana);
                            DamageForTower.IsEnabled = false;
                            DamageForArmy.IsEnabled = true;

                        }
                        break;
                    case 1:
                        if (sh.arrow <= 0)
                        {
                            ArrowOrMana.Text = "0";
                            MessageBox.Show("К сожалению у вас кончились стрелы!", "Поражение!", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new MainPage());
                        }
                        else
                        {
                            TowerOfBar.Value -= un.damageUnit;
                            sh.arrow -= 1;
                            ArrowOrMana.Text = Convert.ToString(sh.arrow);
                            DamageForTower.IsEnabled = false;
                            DamageForArmy.IsEnabled = true;
                        }
                        break;
                }
            }
        }

        private void DamageForArmy_Click(object sender, RoutedEventArgs e)
        {
            // Тут мы атакуем армию и если Прогресс бар армии меньше или равен 0, то мы проиграли, иначе мы наносим урон по армии
            if (PbOfArmy.Value <=0)
            {
                switch (tw.Princess)
                {
                    case true:
                        PbOfArmy.Value = 0;
                        MessageBox.Show("Вы не смогли уничтожить башню!\nИ к вашему сожалению принцесса была внутри\nВы не смогли спасти ее!", "Не ваш день!", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new MainPage());
                        break;
                    case false:
                        PbOfArmy.Value = 0;
                        MessageBox.Show("Вы не смогли уничтожить башню!\nК счастью принцессы не было в ней! Но вы все равно проиграли!", "Не ваш день!", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new MainPage());
                        break;
                }
            }    
            else
            {
                PbOfArmy.Value -= tw.towerDamage;
                DamageForTower.IsEnabled = true;
                DamageForArmy.IsEnabled = false;
            }
        }
    }
}
