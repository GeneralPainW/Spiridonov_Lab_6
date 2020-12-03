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

        double a;
        double b;

        enum Operations
        {
            NONE,
            SUM,
            MINUS,
            MULT,
            DIV,
            EXP_2,
            EXP_Y,
            ONE_DIV_X,
            SIN_X,
            COS_X,
            SQRT_X
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

        private void btnExponentiationY_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.EXP_Y;
        }

        private void btnCosX_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.COS_X;
            a = Math.Cos(a);
            tbOutInField.Text = a.ToString();
            
        }

        private void btnExponentiation2_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.EXP_2;
            a = Math.Pow(a, 2);
            tbOutInField.Text = a.ToString();
        }

        private void btnSinX_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.SIN_X;
            a = Math.Sin(a);
            tbOutInField.Text = a.ToString();
        }

        private void btn1DivideX_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.ONE_DIV_X;
            if (a != 0)
            {
                a = 1 / a;
            }
            else
                throw new Exception("Деление на 0 запрещено!");
            tbOutInField.Text = a.ToString();
        }

        private void btnSqrtX_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.SQRT_X;
            a = Math.Sqrt(a);
            tbOutInField.Text = a.ToString();
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
                    if (b != 0)
                    {
                        a /= b;
                    }
                    else
                        throw new Exception("Деление на 0 запрещено!");
                    break;
                case Operations.MULT:
                    a *= b;
                    break;
                case Operations.EXP_Y:
                    a = Math.Pow(a, b);
                    break;
            }
            b = 0;
            tbOutInField.Text = a.ToString();

        }
    }
}
