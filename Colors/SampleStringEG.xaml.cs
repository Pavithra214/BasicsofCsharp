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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Colors
{
    /// <summary>
    /// Interaction logic for SampleStringEG.xaml
    /// </summary>
    public partial class SampleStringEG : Window
    {
        public SampleStringEG()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int ind = pboxpwd.Password.IndexOf("*");
            if (ind == -1)
            {
                MessageBox.Show(this,"Invalid Password");
            }
            else if ((ind > 0) && (pboxpwd.Password.Length > 8))
            {
                MessageBox.Show(this,"Valid Password");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            String[] fullname = txtname.Text.Split(" ");
            txtname.Clear();
            int count = fullname.Length;
            for (int i = 0; i < count; i++)
            {

                String result = fullname[i];
                Char[] name = result.ToCharArray();
            if (name.Length > 0)
            {
                String first = name[0].ToString().ToUpper();
                String remain = " ";

                if (name.Length > 1)
                {
                    remain = result.Substring(1).ToLower();
                }
                    result = first + remain;

                    
                }
                txtname.Text =txtname.Text+" "+result;
            }
            
        }
    }
}
           
