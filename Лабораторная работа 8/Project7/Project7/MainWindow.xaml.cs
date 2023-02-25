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

namespace Project7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox[] DefoltSourceTB;
        TextBox[] CursedSourceTB;
        TextBox[] EverSourceTB;
        int Defolt;
        int Cursed;
        int Ever;

        Massiv TextB = new Massiv();
        public MainWindow()
        {
            InitializeComponent();
            TextBoxGenerate.Text = "0";
        }

        private void BtGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TextB.numberOfTextBox = Convert.ToInt32(TextBoxGenerate.Text);
                if (TextB.numberOfTextBox > 8)
                {
                    MessageBox.Show("Максимальное число TextBox - 8!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    DefoltSourceTB = new TextBox[TextB.numberOfTextBox];
                    for (Defolt = 0; Defolt < TextB.numberOfTextBox; Defolt++)
                    {
                        DefoltSourceTB[Defolt] = new TextBox();
                        DefoltSourceTB[Defolt].Width = 160;
                        DefoltSourceTB[Defolt].Height = 134;
                        DefoltSourceTB[Defolt].Text = "";
                        DefoltSourceTB[Defolt].TextAlignment = TextAlignment.Center;
                        DefoltSourceTB[Defolt].FontSize = 20;
                        DefoltMainGrid.Children.Add(DefoltSourceTB[Defolt]);
                        Thickness posDefoltSource = new Thickness(320 * (Defolt + 1) - 1400, 40, 0, 0);
                        DefoltSourceTB[Defolt].Margin = posDefoltSource;
                    }
                    CursedSourceTB = new TextBox[TextB.numberOfTextBox];
                    for (Cursed = 0; Cursed < TextB.numberOfTextBox; Cursed++)
                    {
                        CursedSourceTB[Cursed] = new TextBox();
                        CursedSourceTB[Cursed].Width = 160;
                        CursedSourceTB[Cursed].Height = 134;
                        CursedSourceTB[Cursed].Text = "";
                        CursedSourceTB[Cursed].TextAlignment = TextAlignment.Center;
                        CursedSourceTB[Cursed].FontSize = 20;
                        CursedtMainGrid.Children.Add(CursedSourceTB[Cursed]);
                        Thickness posCursedSource = new Thickness(320 * (Cursed + 1) - 1400, 40, 0, 0);
                        CursedSourceTB[Cursed].Margin = posCursedSource;
                    }
                    EverSourceTB = new TextBox[TextB.numberOfTextBox];
                    for (Ever = 0; Ever < TextB.numberOfTextBox; Ever++)
                    {
                        EverSourceTB[Ever] = new TextBox();
                        EverSourceTB[Ever].Width = 160;
                        EverSourceTB[Ever].Height = 134;
                        EverSourceTB[Ever].Text = "";
                        EverSourceTB[Ever].TextAlignment = TextAlignment.Center;
                        EverSourceTB[Ever].FontSize = 20;
                        EverMainGrid.Children.Add(EverSourceTB[Ever]);
                        Thickness posEverSource = new Thickness(320 * (Ever + 1) - 1400, 40, 0, 0);
                        EverSourceTB[Ever].Margin = posEverSource;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtClearAll_Click(object sender, RoutedEventArgs e)
        {
            DefoltMainGrid.Children.Clear();
            CursedtMainGrid.Children.Clear();
            EverMainGrid.Children.Clear();
            TextBoxGenerate.Text = "0";
        }

        private void BtResult_Click(object sender, RoutedEventArgs e)
        {
            string[] stringsOfDefolt = new string[TextB.numberOfTextBox];
            for(int StringOfDefolt = 0; StringOfDefolt < TextB.numberOfTextBox; StringOfDefolt++)
            {
                stringsOfDefolt[StringOfDefolt] = DefoltSourceTB[StringOfDefolt].Text;
            }
            string[] stringsOfCursed = new string[TextB.numberOfTextBox];
            for (int StringOfCursed = 0; StringOfCursed < TextB.numberOfTextBox; StringOfCursed++)
            {
                stringsOfCursed[StringOfCursed] = CursedSourceTB[StringOfCursed].Text;
            }
            string[] stringsOfEver = new string[TextB.numberOfTextBox];
            for (int StringOfEver = 0; StringOfEver < TextB.numberOfTextBox; StringOfEver++)
            {
                stringsOfEver[StringOfEver] = EverSourceTB[StringOfEver].Text;
            }
        }
    }
}
