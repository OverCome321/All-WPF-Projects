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
using ClassLibrary1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SourseOfStrengh sos = new SourseOfStrengh();
        public int power = 100;
        CursedOfSource cur = new CursedOfSource();
        EverOfSource ever = new EverOfSource();
        Random r = new Random();
        public bool btn = false;
        public bool btn2 = false;
        public bool btn3 = false;


        public MainWindow()
        {
            MessageBox.Show("Приветствую в игре", "Для того чтобы начать выбери источник!", MessageBoxButton.OK, MessageBoxImage.None);
            InitializeComponent();
            sos.maxUss = 10;
            sos.nowUss = 0;
            int power = 100;
            TBPlusDamage.Text = "0";
            Damage1.Text = "0";
            SourceCursed.Text = "0";
            PBSource.Maximum = power;
            PBSource2.Maximum = power;
            PBSource3.Maximum = power;
            UseSourse.Visibility = Visibility.Hidden;
            Source1.Visibility = Visibility.Hidden;
            Source2.Visibility = Visibility.Hidden;
            Source3.Visibility = Visibility.Hidden;
            PowerOfHero.Visibility = Visibility.Hidden;
            Damage1.Visibility = Visibility.Hidden;
            PBSource3.Visibility = Visibility.Hidden;
            CursedOff.IsEnabled = false;
            PBSource2.Visibility = Visibility.Hidden;
            PBSource.Visibility = Visibility.Hidden;
            PBSource3.IsEnabled = false;
            PBSource2.IsEnabled = false;
            PBSource.IsEnabled = false;
            UssSours.IsEnabled = false;
            UseSourse.IsEnabled = false;
            UssSourse2.Visibility = Visibility.Hidden;
            SourceCursed.IsEnabled = false;
            UssSours.Visibility = Visibility.Hidden;
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
            TBPlusDamage.IsEnabled = false;
            UssSours3.Visibility = Visibility.Hidden;
            CursedOff.Visibility = Visibility.Hidden;
            ButtonLast.Visibility = Visibility.Hidden;
            LabelLast2.Visibility = Visibility.Hidden;
            Cursedbutton.Visibility = Visibility.Hidden;
            Drink.Visibility = Visibility.Hidden;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            cur.K = Convert.ToInt32(SourceCursed.Text);
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ты выбрал проклятый источник!, чтобы его активировать ты должен снять проклятие, источник будет доступен если степень проклятия равна 1!", "Привет", MessageBoxButton.OK, MessageBoxImage.Information);btn = true;

            btn = true;
            Drink.Visibility = Visibility.Visible;
            UssSourse2.Visibility = Visibility.Visible;
            DefoltSourse.Visibility = Visibility.Hidden;
            EverSourse1.Visibility = Visibility.Hidden;
            CursedOff.Visibility = Visibility.Visible;
            Source3.Visibility = Visibility.Visible;
            Button2.Visibility = Visibility.Hidden;
            Button3.Visibility = Visibility.Hidden;
            UssSours.Visibility = Visibility.Hidden;
            UseSourse.IsEnabled = true;
            SourceCursed.IsEnabled = true;
            TBPlusDamage.IsEnabled = true;
            TBPlusDamage.IsEnabled = true;
            TBPlusDamage.Visibility = Visibility.Hidden;
            _12.Visibility = Visibility.Hidden;
            UssSourse2.Visibility = Visibility.Hidden;
            GiveBT.Visibility = Visibility.Hidden;
        }

        private void TBPlusDamage_TextChanged(object sender, TextChangedEventArgs e)
        {
            sos.maxUss = Convert.ToInt32(TBPlusDamage.Text);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            sos.damage = Convert.ToInt32(Damage1.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GiveBT.Visibility = Visibility.Visible;
            GiveBT.IsEnabled = true;
            btn3 = false;
            btn2 = false;
            btn = false;
            UssSours.Visibility = Visibility.Hidden;
            CursedOff.IsEnabled = false;
            Button2.Visibility = Visibility.Visible;
            LabelLast2.Visibility = Visibility.Hidden;
            Button3.Visibility = Visibility.Visible;
            Source3.Visibility = Visibility.Hidden;
            UseSourse.Visibility = Visibility.Hidden;
            Cursed.Visibility = Visibility.Hidden;
            Button1.IsEnabled = true;
            sos.nowUss = 0;
            cur.K = 0;
            Damage1.Visibility = Visibility.Hidden;
            PowerOfHero.Visibility = Visibility.Hidden;
            PBSource3.Visibility = Visibility.Hidden;
            PBSource2.Visibility = Visibility.Hidden;
            PBSource.Visibility = Visibility.Hidden;
            Button1.Visibility = Visibility.Visible;
            Step2.Visibility = Visibility.Visible;
            SourceCursed.Visibility = Visibility.Visible;
            CursedOff.Visibility = Visibility.Visible;
            Button2.IsEnabled = true;
            Label1.Visibility = Visibility.Hidden;
            Source2.Visibility = Visibility.Hidden;
            UssSours.IsEnabled = true;
            UssSours.Visibility = Visibility.Hidden;
            UssSourse2.Visibility = Visibility.Hidden;
            UssSourse2.IsEnabled = true;
            SourceCursed.Text = Convert.ToString(0);
            TBPlusDamage.IsEnabled = false;
            TBPlusDamage.Text = Convert.ToString(0);
            SourceCursed.IsEnabled = false;
            UssSours3.Visibility = Visibility.Hidden;
            Button3.IsEnabled = true;
            Damage1.Text = Convert.ToString(0);
            Label3.Visibility = Visibility.Hidden;
            Cursed.Visibility = Visibility.Hidden;
            DefoltSourse.Visibility = Visibility.Visible;
            CursedSourse3.Visibility = Visibility.Visible;
            EverSourse1.Visibility = Visibility.Visible;
            CursedOff.Visibility = Visibility.Hidden;
            SourceCursed.Visibility = Visibility.Visible;
            Step2.Visibility = Visibility.Visible;
            ButtonLast.Visibility = Visibility.Hidden;
            Source1.Visibility = Visibility.Hidden;
            UssSours3.IsEnabled = true;
            LabelLast2.Visibility = Visibility.Hidden;
            Cursedbutton.Visibility = Visibility.Hidden;
            Button1.Visibility = Visibility.Visible;
            Cursedbutton.IsEnabled = true;
            ButtonLast.IsEnabled = true;
            Label3.Visibility = Visibility.Hidden;
            TBPlusDamage.Visibility = Visibility.Visible;
            _12.Visibility = Visibility.Visible;
            
            Drink.Visibility = Visibility.Hidden;
            GiveBT.Visibility = Visibility.Visible;
        }


        private void CursedOff_Click(object sender, RoutedEventArgs e)
        {
            
            SourceCursed.Visibility = Visibility.Hidden;
            string cursed2 = Convert.ToString(Math.Sign(cur.K));
            //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
            //enb = Convert.ToBoolean(sign.Replace("0", "false"));
            bool C;
            cursed2 = cursed2.Replace("0", "true");
            cursed2 = cursed2.Replace("1", "false");
            C = Convert.ToBoolean(cursed2);
            Button1.IsEnabled = C;
            PBSource3.IsEnabled = true;
            UssSours.IsEnabled = true;
            UssSours.Visibility = Visibility.Visible;
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GiveBT.Visibility = Visibility.Visible;
            CursedOff.Visibility = Visibility.Hidden;
            ButtonLast.Visibility = Visibility.Visible;
            TBPlusDamage.Text = Convert.ToString(0);
            Cursed.Visibility = Visibility.Hidden;
            UseSourse.Visibility = Visibility.Hidden;
            SourceCursed.Visibility = Visibility.Hidden;
            Step2.Visibility = Visibility.Hidden;
            Damage1.Visibility = Visibility.Visible;
            PowerOfHero.Visibility = Visibility.Visible;
            PBSource3.Visibility = Visibility.Visible;
            sos.nowUss = 0;
            cur.K = 0;
            UssSourse2.Visibility = Visibility.Hidden;
            Cursedbutton.Visibility = Visibility.Visible;
            Button1.Visibility = Visibility.Hidden;
            Drink.Visibility = Visibility.Hidden;
            TBPlusDamage.Visibility = Visibility.Visible;
            _12.Visibility = Visibility.Visible;
            PBSource3.Value = 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Damage1.Text == Convert.ToString(0) || TBPlusDamage.Text == Convert.ToString(0) || PBSource2.Value == 0)
            {
                MessageBox.Show("Вы либо забыли ввести данные либо забыли наполнить источник!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                sos.damage = Convert.ToInt32(Damage1.Text);
                int bonus2 = 20;
                sos.damage += bonus2;
                Damage1.Text = sos.damage.ToString();
                PBSource2.Value -= bonus2;
                sos.maxUss--;
                sos.nowUss++;
                Label1.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
                Label1.Visibility = Visibility.Visible;
                string cursed = Convert.ToString(Math.Sign(sos.maxUss));
                //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
                //enb = Convert.ToBoolean(sign.Replace("0", "false"));
                bool b;
                cursed = cursed.Replace("1", "true");
                cursed = cursed.Replace("0", "false");
                b = Convert.ToBoolean(cursed);
                UssSours.IsEnabled = b;
                Button2.IsEnabled = b;
                if (PBSource2.Value == 0)
                {
                    UssSours.IsEnabled = false;
                }
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ты выбрал обычный источник!", "Привет", MessageBoxButton.OK, MessageBoxImage.Information);
            UssSours.Visibility = Visibility.Hidden;
            CursedSourse3.Visibility = Visibility.Hidden;
            EverSourse1.Visibility = Visibility.Hidden;
            PBSource2.Visibility = Visibility.Visible;
            PBSource2.IsEnabled = true;
            Button3.Visibility = Visibility.Hidden;
            Button1.Visibility = Visibility.Hidden;
            UssSours.IsEnabled = true;
            Source2.Visibility = Visibility.Visible;
            Damage1.Visibility = Visibility.Visible;
            PowerOfHero.Visibility = Visibility.Visible;
            UssSours.Visibility = Visibility.Visible;
            TBPlusDamage.IsEnabled = true;
            GiveBT.IsEnabled = true;
            btn2 = true;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ты выбрал бесконечный источник, из него ты можешь испить сколько угодно раз","Привет", MessageBoxButton.OK, MessageBoxImage.Information);
            btn3 = true;
            DefoltSourse.Visibility = Visibility.Hidden;
            Source1.Visibility = Visibility.Visible;
            CursedSourse3.Visibility = Visibility.Hidden;
            TBPlusDamage.IsEnabled = true;
            UssSours3.Visibility = Visibility.Visible;
            PowerOfHero.Visibility = Visibility.Visible;
            Damage1.Visibility = Visibility.Visible;
            PBSource.Visibility = Visibility.Visible;
            PBSource.IsEnabled = true;
            Button1.Visibility = Visibility.Hidden;
            Button2.Visibility = Visibility.Hidden;
            GiveBT.Visibility = Visibility.Hidden;
        }

        private void UssSourse2_Click(object sender, RoutedEventArgs e)
        {
            sos.damage = Convert.ToInt32(Damage1.Text);
            int bonus = 20;
            sos.damage += bonus;
            Damage1.Text = sos.damage.ToString();
            PBSource3.Value -= bonus;
            sos.maxUss--;
            sos.nowUss++;
            UseSourse.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";

            string cursed = Convert.ToString(Math.Sign(sos.maxUss));
            //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
            //enb = Convert.ToBoolean(sign.Replace("0", "false"));
            bool b;
            cursed = cursed.Replace("1", "true");
            cursed = cursed.Replace("0", "false");
            b = Convert.ToBoolean(cursed);
            UssSourse2.IsEnabled = b;
            Button1.IsEnabled = b;
            UseSourse.Visibility = Visibility.Visible;
            
        }

        private void UssSours3_Click(object sender, RoutedEventArgs e)
        {
            if (Damage1.Text == Convert.ToString(0) || TBPlusDamage.Text == Convert.ToString(0))
            {
                MessageBox.Show("Вы либо забыли ввести данные либо забыли наполнить источник!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                sos.damage = Convert.ToInt32(Damage1.Text);
                int bonus = 20;
                sos.damage += bonus;
                Damage1.Text = sos.damage.ToString();
                PBSource.Value -= bonus;
                sos.maxUss--;
                sos.nowUss++;
                Label3.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
                Label3.Visibility = Visibility.Visible;
                string cursed = Convert.ToString(Math.Sign(sos.maxUss));
                //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
                //enb = Convert.ToBoolean(sign.Replace("0", "false"));            
                if (sos.maxUss == 0)
                {
                    Label3.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
                }
            }
        }

        private void PBSource_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PBSource.Value = 100;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Damage1.Text == Convert.ToString(0) || TBPlusDamage.Text == Convert.ToString(0) || PBSource3.Value == 0)
            {
                MessageBox.Show("Вы либо забыли ввести данные либо забыли наполнить источник!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                sos.damage = Convert.ToInt32(Damage1.Text);
                int bonus = 20;
                sos.damage += bonus;
                Damage1.Text = sos.damage.ToString();
                PBSource3.Value -= bonus;
                sos.maxUss--;
                sos.nowUss++;
                LabelLast2.Content = $"Оставшееся количество использований: {sos.maxUss} Использовано: {sos.nowUss} раз";
                LabelLast2.Visibility = Visibility.Visible;
                string cursed = Convert.ToString(Math.Sign(sos.maxUss));
                //bool enb = Convert.ToBoolean(sign.Replace("1", "true"));
                //enb = Convert.ToBoolean(sign.Replace("0", "false"));
                bool b;
                cursed = cursed.Replace("1", "true");
                cursed = cursed.Replace("0", "false");
                b = Convert.ToBoolean(cursed);
                ButtonLast.IsEnabled = b;
                Button1.IsEnabled = b;
                Cursedbutton.IsEnabled = b;
                if (PBSource3.Value == 0)
                {
                    ButtonLast.IsEnabled = false;
                }
            }
        }

        private void PBSource3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void PBSource2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void Cursedbutton_Click(object sender, RoutedEventArgs e)
        {
            
            GiveBT.IsEnabled = true;
            UseSourse.IsEnabled = true;
            SourceCursed.IsEnabled = true;
            TBPlusDamage.IsEnabled = true;
            TBPlusDamage.IsEnabled = true;
            
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            if (SourceCursed.Text == Convert.ToString(0))
            {
                MessageBox.Show("Введите степень проклятия!", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                if (cur.K > 1)
                {
                    cur.K--;
                    Cursed.Content = $"Степень проклятия : { cur.K }";
                    Cursed.Visibility = Visibility.Visible;
                    string usscursed = Convert.ToString(Math.Sign(cur.K));
                    bool d;

                    usscursed = usscursed.Replace("1", "true");
                    usscursed = usscursed.Replace("0", "false");
                    d = Convert.ToBoolean(usscursed);
                    Button1.IsEnabled = d;
                    UssSourse2.IsEnabled = d;
                }
                if (cur.K == 1)
                {
                    CursedOff.IsEnabled = true;
                    
                }
                if (cur.K <= 0)
                {
                    MessageBox.Show("Упс вводите степень проклятия заново", "Ошибочка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    SourceCursed.Text = Convert.ToString(0);
                    CursedOff.IsEnabled = false;
                }   
            }
        }

        private void GiveBT_Click(object sender, RoutedEventArgs e)
        {
            if (btn2 == true)
            {
                
                PBSource2.Value += 100;
                UssSours.IsEnabled = true;
                
            }
            if (btn == true)
            {
                PBSource3.Value += 100;
                ButtonLast.IsEnabled = true;
            }
            if (Button2.IsEnabled == false)
            {
                Label1.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
            }
            if (btn3 == true)
            {
                GiveBT.IsEnabled = false;
                UssSours3.IsEnabled = true;
                Button3.IsEnabled = true;
                LabelLast2.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
            }
            if (Cursedbutton.IsEnabled == false)
            {
                LabelLast2.Content = $"Оставшееся количество использований: {sos.maxUss = sos.nowUss} Использовано: {sos.nowUss = 0} раз";
            }
        }  
    }
}
