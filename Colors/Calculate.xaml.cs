using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Colors
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        String firstnumber = "";
        String secondnumber= "";
        String opr = " ";
        int result = 0;
        String output = "";

        public Window1()
        {
            InitializeComponent();
        }


        private void Oper_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
           opr = button.Content.ToString();
            output = output + opr;
            txtrslt.Text = output;
        }

        //private void bttnsub_Click(object sender, RoutedEventArgs e)
        //{
        //    lblopr.Content = "-";
        //}

        //private void bttnmul_Click(object sender, RoutedEventArgs e)
        //{

        //    lblopr.Content = "*";

        //}

        //private void bttndiv_Click(object sender, RoutedEventArgs e)
        //{
        //    lblopr.Content = "/";
        //}

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            if (opr == " ")
            {
                firstnumber = firstnumber + button.Content;
                output = firstnumber;
                txtrslt.Text = output;
            }
            else
            {
                secondnumber = secondnumber + button.Content;
                output = firstnumber + opr + secondnumber;
                txtrslt.Text = output;
            }
        }

        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "2";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "2";
        //    }
        //}

        //private void btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "3";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "3";
        //    }
        //}

        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "4";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "4";
        //    }
        //}

        //private void btn5_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "5";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "5";
        //    }

        //}

        //private void btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "6";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "6";
        //    }
        //}

        //private void btn7_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "7";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "7";
        //    }
        //}

        //private void btn8_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "8";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "8";
        //    }
        //}

        //private void btn9_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "9";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "9";
        //    }
        //}

        //private void btn0_Click(object sender, RoutedEventArgs e)
        //{
        //    String opr = lblopr.Content.ToString();
        //    if (opr == " ")
        //    {
        //        txtfrst.Text = txtfrst.Text + "0";
        //    }
        //    if (opr != " ")
        //    {
        //        txtscnd.Text = txtscnd.Text + "0";
        //    }
        //}

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            //txtfrst.Text = " ";
            //txtscnd.Text = " ";
            firstnumber = "";
            secondnumber="";
            txtrslt.Text = " ";
            opr = " ";
            result = 0;
            output = "";
            
        }

        private void btneq_Click(object sender, RoutedEventArgs e)
        {

           
            int first = Convert.ToInt32(firstnumber);
            int second = Convert.ToInt32(secondnumber);
            output = output + "\n";
            if (opr == "+")
            {
               
                result = first + second;
                txtrslt.Text = result.ToString();
            }
            else if (opr == "-")
            {

                result = first - second;
                txtrslt.Text = result.ToString();
            }
            else if (opr == "*")
            {
               
                result = first * second;
                txtrslt.Text = result.ToString();
            }
            else if (opr == "/")
            {
                
                result = first / second;
                txtrslt.Text = result.ToString();

            }
            output = output + result.ToString();
            txtrslt.Text = output;
        }
    }
}
