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

namespace Spiridonov_Lab_6
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

        long a;
        long b;

        enum Operations
        {
            NONE,
            SUM,
            MINUS,
            MULT,
            DIV
        }

        Operations operation;

        private void btnNumb1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == Operations.NONE)
            {
                a = a * 10 + int.Parse(((Button)sender).Content.ToString());
                tbOutInField.Text = a.ToString();
            }
            else
            {
                b = b * 10 + int.Parse(((Button)sender).Content.ToString());
                tbOutInField.Text = b.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.SUM;
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.MULT;
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.DIV;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.MINUS;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case Operations.SUM:
                    a += b;
                    break;
                case Operations.MINUS:
                    a -= b;
                    break;
                case Operations.DIV:
                    a /= b;
                    break;
                case Operations.MULT:
                    a *= b;
                    break;
            }
            b = 0;
            tbOutInField.Text = a.ToString();
        }
    }
}
