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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1;
        double number2;
        double result;
        double type1;
        char point;
        bool addbtnclick = false;
        bool subbtnclick = false;
        bool multbtnclick = false;
        bool divbtnclick = false;
        bool powbtnclick = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (addbtnclick == true)
            {
                number2 = Convert.ToDouble(txtInsert.Text);
                lblChar.Content += Convert.ToString(number2);
                result = number1 + number2;
            }
            if (subbtnclick == true)
            {
                result = number1 - Convert.ToInt32(txtInsert.Text);
            }
            if (divbtnclick == true)
            {
                number2 = Convert.ToDouble(txtInsert.Text);
                result = number1 / number2;
            }
            if (multbtnclick == true)
            {
                result = number1 * Convert.ToDouble(txtInsert.Text);
            }
            if (powbtnclick == true)
            {
                result = 1;
                number2 = Convert.ToDouble(txtInsert.Text);
                for (double i = number2; i >= 1; i--)
                {
                    result *= number1;
                }
            }
            txtInsert.Text = Convert.ToString(result);
            result = 0;
            number2 = 0;
            lblChar.Content = String.Empty;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "";
            point = '-';
            lblChar.Content += Convert.ToString(number1) + Convert.ToString(point);
            subbtnclick = true;
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "";
            point = '+';
            lblChar.Content += Convert.ToString(number1)+ Convert.ToString(point);
            addbtnclick = true;
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "";
            point = '/';
            lblChar.Content += Convert.ToString(number1) + Convert.ToString(point);
            divbtnclick = true;
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "";
            point = '*';
            lblChar.Content += Convert.ToString(number1) + Convert.ToString(point);
            multbtnclick = true;
        }

        private void click_one_Click(object sender, RoutedEventArgs e)
        {
            Button but = (Button) sender;
            txtInsert.Text += but.Content.ToString();
        }

        private void click_frac_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            for (double i = number1-1; i > 0; i--)
            {
                number1 *= i;
            }
            txtInsert.Text = Convert.ToString(number1);

        }

        private void click_pow_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(txtInsert.Text);
            txtInsert.Text = "";
            point = '^';
            lblChar.Content += Convert.ToString(number1) + Convert.ToString(point);
            powbtnclick = true;
        }
    }
}
