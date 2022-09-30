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

namespace Wpf_Yshakow_PR2INS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KNOPKA1_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 1;
        }

        private void KNOPKA2_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 2;
        }

        private void KNOPKA3_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 3;
        }

        private void KNOPKA4_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 4;
        }

        private void KNOPKA5_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 5;
        }

        private void KNOPKA6_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 6;
        }

        private void KNOPKA7_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 7;
        }

        private void KNOPKA8_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 8;
        }

        private void KNOPKA9_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 9;
        }

        private void KNOPKA0_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + 0;
        }

        private void KNOPKATOCHKA_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + ".";
        }

        private void KNOPKAPARDE_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + "/";
        }

        private void KNOPKAYMHOJ_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + "*";
        }

        private void KNOPKAMINYS_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + "-";
        }

        private void KNOPKAPLUS_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = Textblock1.Text + "+";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = "";
        }

        private void KNOPKAYD1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
