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

namespace wpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int btnNo = Int32.Parse(btn.Content.ToString());
            if(op=="")
            {
                num1 = btnNo + num1 * 10;
                txtBox.Text = num1.ToString();
            }
            else
            {
                num2 = btnNo + num2 * 10;
                txtBox.Text = num2.ToString();
            }
        }

        
        private void btn_op_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Content.ToString();
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "Avg":
                    result = (num1 + num2)/2;
                    break;
                case "Min":
                    result = num1 < num2 ? num1 : num2;
                    break;
                case "Max":
                    result = num1 > num2 ? num2 : num1;
                    break;
                case "x^y":
                    result = Pow(num1, num2);
                    break;
            }
            txtBox.Text = result.ToString();
            op = "";
            num1 = result;
            num2 = 0;

        }

        private int Pow(int x, int y)
        {
            if (y == 0)
                return 1;
            return Pow(x, y - 1) * x;
        }

        private void btn_ce_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                num1 = 0;
            else
                num2 = 0;
            txtBox.Text = "0";
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtBox.Text = "0";
        }

        private void btn_bsp_Click(object sender, RoutedEventArgs e)
        {
            if(op=="")
            {
                num1 = num1 / 10;
                txtBox.Text = num1.ToString();
            }
            else
            {
                num2 = num2 / 10;
                txtBox.Text = num2.ToString();
            }
        }

        private void btn_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if(op=="")
            {
                num1 = -num1;
                txtBox.Text = num1.ToString();
            }
            else
            {
                num2 = -num2;
                txtBox.Text = num2.ToString();
            }
        }
    }
}
