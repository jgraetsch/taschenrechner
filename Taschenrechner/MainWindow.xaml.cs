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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x = 0;
        int y = 0;
        enum Operation { Keine,Plus,Minus,Mal,Geteilt }
        Operation op= Operation.Keine;

        public MainWindow()
        {
            InitializeComponent();
        }

        void ziffer(int z)
        {
            x = x * 10 + z;
            txtAnzeige.Text = x.ToString();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            ziffer(0);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ziffer(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ziffer(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ziffer(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ziffer(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            ziffer(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ziffer(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            ziffer(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            ziffer(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            ziffer(9);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            op = Operation.Plus;
            y = x;
            x = 0;
            txtAnzeige.Text = x.ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGeteilt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGleich_Click(object sender, RoutedEventArgs e)
        {
            Ausrechnen();
            txtAnzeige.Text = x.ToString();
        }

        private void Ausrechnen()
        {
            switch (op)
            {
                case Operation.Keine:
                    break;
                case Operation.Plus:
                    x = x + y;
                    break;
                case Operation.Minus:
                    x = y - x;
                    break;
                case Operation.Mal:
                    x = x * y;
                    break;
                case Operation.Geteilt:
                    x = y / x;
                    break;
                default:
                    break;
            }
        }
    }
}
