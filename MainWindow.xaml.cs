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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number1 = "";
        string number2 = "";
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 0;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 0;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 1;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 1;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 2;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 2;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 3;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 3;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 4;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 4;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 5;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 5;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 6;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 6;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 7;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 7;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 8;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 8;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += "" + 9;
                txt_ToShow.Text = number1;
            }
            else
            {
                number2 += "" + 9;
                txt_ToShow.Text = number2;
            }
        }

        private void btn_Sum_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txt_ToShow2.Text = number1 + " +";
        }

        private void ntn_Subtraction_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txt_ToShow2.Text = number1 + " -";
        }

        private void btn_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txt_ToShow2.Text = number1 + " *";
        }

        private void btn_Division_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txt_ToShow2.Text = number1 + " /";
        }

        private void btn_Result_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txt_ToShow.Text = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                    txt_ToShow2.Text = $"{number1} {operation} {number2} =";
                    number1 = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                    break;
                case "-":
                    txt_ToShow.Text = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
                    txt_ToShow2.Text = $"{number1} {operation} {number2} =";
                    number1 = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
                    break;

                case "*":
                    txt_ToShow.Text = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
                    txt_ToShow2.Text = $"{number1} {operation} {number2} =";
                    number1 = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
                    break;

                case "/":
                    txt_ToShow.Text = (Convert.ToInt32(number1) / Convert.ToInt32(number2)).ToString();
                    txt_ToShow2.Text = $"{number1} {operation} {number2} =";
                    number1 = (Convert.ToInt32(number1) / Convert.ToInt32(number2)).ToString();
                    break;
            }

            operation = "";
            number2 = "";
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1.Remove(number1.Length - 1);

                txt_ToShow.Text = number1;
            }
            else
            {
                number2 = number2.Remove(number2.Length - 1);

                txt_ToShow.Text = number2;
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            number1 = "";
            number2 = "";
            operation = "";

            txt_ToShow.Text = "0";
            txt_ToShow2.Text = "";
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            
            if (number1 != "" && operation == "")
            {
                number1 = "";

                txt_ToShow.Text = "J0";
            }
            else if (number1 != "" && operation != "" && number2 != "")
            {
                number2 = "";

                txt_ToShow.Text = "H0";
            }
            else/* if (number1 != "" && operation == "" && number2 == "")*/
            {
                number1 = "";
                number2 = "";
                operation = "";

                txt_ToShow.Text = "0gfdg";
                txt_ToShow2.Text = "";
            }
        }
    }
}
