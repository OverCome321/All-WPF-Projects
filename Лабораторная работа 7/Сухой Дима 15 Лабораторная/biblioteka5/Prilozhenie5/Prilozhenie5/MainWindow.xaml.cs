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

namespace Prilozhenie5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            fight.Visibility = Visibility.Hidden;
        }

       Unit voin1;
        Unit voin2;

        private void dobav1_Click(object sender, RoutedEventArgs e)
        {
            
            switch (Unit1.SelectedIndex)
            {
                case 0: 
                        voin1 = new Unit();
                        break;
                
                case 1:
                    
                         voin1 = new Shooter();
                        break;
                    
                case 2:
                    
                         voin1 = new Mag();
                        break;
                
            }

            voin1.MaxHp = Convert.ToInt32(MaxHp1.Text);
            voin1.CurrHp = Convert.ToInt32(Hp1.Text);
            voin1.Defence = Convert.ToInt32(Defence1.Text);
            voin1.Attack = Convert.ToInt32(Attack1.Text);


            Unit1MaxHp.Text = Convert.ToString(voin1.MaxHp);
            Unit1Hp.Text = Convert.ToString(voin1.CurrHp);
            Unit1Defence.Text = Convert.ToString(voin1.Defence);
            Unit1Attack.Text = Convert.ToString(voin1.Attack);

            dobav1.IsEnabled = false;

            if (dobav1.IsEnabled == false && dobav2.IsEnabled == false)
            {
                fight.Visibility = Visibility.Visible;
            }
        }


        private void dobav2_Click(object sender, RoutedEventArgs e)
        {
            switch (Unit2.SelectedIndex)
            {
                case 0:
                    
                        voin2 = new Unit();
                        break;
                    
                case 1:
                    
                        voin2 = new Shooter();
                        break;
                    
                case 2:
                    
                        voin2 = new Mag();
                        break;
                    
            }

            voin2.MaxHp = Convert.ToInt32(MaxHp2.Text);
            voin2.CurrHp = Convert.ToInt32(Hp2.Text);
            voin2.Defence = Convert.ToInt32(Defence2.Text);
            voin2.Attack = Convert.ToInt32(Attack2.Text);

            Unit2MaxHp.Text = Convert.ToString(voin2.MaxHp);
            Unit2Hp.Text = Convert.ToString(voin2.CurrHp);
            Unit2Defence.Text = Convert.ToString(voin2.Defence);
            Unit2Attack.Text = Convert.ToString(voin2.Attack);

            dobav2.IsEnabled = false;

            if (dobav1.IsEnabled == false && dobav2.IsEnabled == false)
            {
                fight.Visibility = Visibility.Visible;
            }
        }

        

        private void Fight(object sender, RoutedEventArgs e)
        {

            voin1.TakeDamage(voin2.DoAttack(), voin2.Defence);
            Unit1Hp.Text = Convert.ToString(voin1.CurrHp);

            voin2.TakeDamage(voin1.DoAttack(), voin1.Defence);
            Unit2Hp.Text = Convert.ToString(voin2.CurrHp);
        }
    }
}
