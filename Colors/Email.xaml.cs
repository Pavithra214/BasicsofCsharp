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

namespace Colors
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Window
    {
        public Email()
        {
            InitializeComponent();
            cmbcountry.Items.Add("India");
            cmbcountry.Items.Add("Germany");
            cmbcountry.Items.Add("France");
            cmbcountry.Items.Add("Italy");
            //string[] country = { "India", "Africa", "Thailand", "Bangkok" };
            //cmbcountry.ItemsSource = country;
            cmbcountry.SelectedIndex = 0;
        }
        private void btnsend_Click(object sender, RoutedEventArgs e)
        {
            //cmbcountry.Items.Clear();
            //cmbcountry.Items.Remove("France");
            //cmbcountry.Items.RemoveAt(0);
            cmbcountry.Items.Insert(0, txtsend.Text);
            //String[] email = txtto.Text.Split(";");
            //int count = email.Length;
            //for (int i = 0; i < count; i++)
            //{
            //    MessageBox.Show(email[i]);
            //}
        }
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            String[] product = txtproduct.Text.Split("\r\n");
            int count = product.Length;
            for(int i=0; i<count; i++)
            {
                String[] qty = product[i].Split(",");
                String val = $"Product Name: {qty[0]} \n Qty: {qty[1]}";
                MessageBox.Show(val);
            }
        }

        private void btnlist_Click(object sender, RoutedEventArgs e)
        {
            lstskill.Items.Add("Japan");
            lstskill.Items.Add("China");
            lstskill.Items.Add("Korea");
            lstskill.Items.Add("Scoltland");
            lstskill.SelectedIndex = 1;
        }

       
    }
}
