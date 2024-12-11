using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
    /// Interaction logic for StringEG.xaml
    /// </summary>
    public partial class StringEG : Window
    {
        public StringEG()
        {
            InitializeComponent();
        }

        private void btnname_Click(object sender, RoutedEventArgs e)
        {
            //String name = "Machine Learning And AI";

            //SUBSTRING AND REMOVE
            //String second = name.Substring(7);
            //MessageBox.Show(second);
            //String first = name.Remove(8);
            //MessageBox.Show(first);

            //INDEXOF METHOD
            //  int index1 = name.IndexOf(" ");
            //  if(index1>0)
            //  {
            //      String second = name.Substring(index1);
            //      MessageBox.Show(second);
            //  }
            //if(index1>0)
            //  {
            //      String first = name.Remove(index1);
            //      MessageBox.Show(first);
            //  }

            //LASTINDEXOF METHOD
            //int index1 = name.LastIndexOf(" ");
            //if (index1 > 0)
            //{
            //    String second = name.Substring(index1);
            //    MessageBox.Show(second);
            //}
            //if (index1 > 0)
            //{
            //    String first = name.Remove(index1);
            //    MessageBox.Show(first);
            //}

            //THROUGH USER INPUT
            //int inde = txtname.Text.IndexOf(" ");
            //if (inde > 0)
            //{
            //    String first = txtname.Text.Substring(inde);
            //    MessageBox.Show(first);

            //}


            Char[] name = txtname.Text.ToCharArray();
            if (name.Length > 0)
            {
                String first = name[0].ToString().ToUpper();
                String remain = " ";

                if (name.Length > 1)
                {
                    remain = txtname.Text.Substring(1).ToLower();
                }
                txtname.Text = first + remain;
            }
        }
    }
}
