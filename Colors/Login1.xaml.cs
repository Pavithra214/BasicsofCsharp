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
    /// Interaction logic for Login1.xaml
    /// </summary>
    public partial class Login1 : Window
    {
        int count = 0;
        String username="Pavithra";
        String password = "Amma@123";
        public Login1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            errusername.Content = "";
            if ((String.IsNullOrWhiteSpace(txtname.Text)) || (String.IsNullOrWhiteSpace(pbpwd.Password)))
            {
                errusername.Content = "Please enter the user name and password";
            }
            else
            {
                if ((txtname.Text == username) && (pbpwd.Password == password))
                {
                    MessageBox.Show("Valid user");
                    txtname.Clear();
                    pbpwd.Clear();
                }
                else
                {
                    if (count == 0)
                    {
                        MessageBox.Show("Invalid User");
                        txtname.Clear();
                        pbpwd.Clear();
                    }
                    else if (count == 1)
                    {
                        MessageBox.Show("Only one attempt is remaining");
                        txtname.Clear();
                        pbpwd.Clear();
                    }
                    else if (count == 2)
                    {
                        MessageBox.Show("Your account is locked due to 3 invalid attempts");
                        btn.IsEnabled = false;
                        txtname.IsReadOnly = true;
                        pbpwd.IsEnabled = false;
                        txtname.Clear();
                        pbpwd.Clear();
                    }
                    count++;
                    
                }
            }
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your request is accepted");
            count = 0;
            btnlogin.IsEnabled = true;
            txtname.IsReadOnly = false;
            pbpwd.IsEnabled = true;
            txtname.Clear();
            pbpwd.Clear();
        }
    }
}
