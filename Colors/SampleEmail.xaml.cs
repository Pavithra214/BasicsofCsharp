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
    /// Interaction logic for SampleEmail.xaml
    /// </summary>
    public partial class SampleEmail : Window
    {
        public SampleEmail()
        {
            InitializeComponent();
        }

       
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            cmbname.Items.Add(txtuser.Text);
            MessageBox.Show("The name is added successfully");
            txtuser.Clear();
            
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            if ((txtindex.Text!="") && (txtuser.Text!=""))
            {
                int index = Convert.ToInt32(txtindex.Text);
                cmbname.Items.Insert(index, txtuser.Text);
                MessageBox.Show("The name is added at the specified index");
            }
            else
            {
                MessageBox.Show("Enter the value");
            }
        }

        private void btnbind_Click(object sender, RoutedEventArgs e)
        {
            String[] skills = txtmulti.Text.Split("\r\n");
            int count=skills.Length;
            for (int i = 0; i < count; i++)
            {

                String result=skills[i];
                lbskill.Items.Add(result);
                //lbskill.ItemsSource = skills;
            }
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {

            txtmulti.Text = "";
            lbskill.Items.Clear();

        }

        private void btnrmove_Click(object sender, RoutedEventArgs e)
        {
            if((txtremovename.Text!="") && (txtremoveindex.Text==""))
            {
                cmbname.Items.Remove(txtremovename.Text);
                MessageBox.Show("The specified username is removed successfully");
            }
            else if ((txtremovename.Text == "") && (txtremoveindex.Text != ""))
            {
                int index = Convert.ToInt32(txtremoveindex.Text);
                cmbname.Items.RemoveAt(index);
                MessageBox.Show("The specified index user name is removed successfully");
            }
             else
            {
                MessageBox.Show("Please enter the value to remove the item");
            }
        }
    }
}
