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

namespace Developer
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void acpbtn_Click(object sender, RoutedEventArgs e)
        {
            
            String html = $"<html><h3>SUB: OFFER LETTER</h3><body>Dear <b>{txtname.Text}</b>,<br><p>Congratulations!<b>{txtcompany.Text}</b> is excited to call you our new <b>{txtjobtitle.Text}</b>.<br>We will focus on wrapping up a few more formalities, including the successful completion of your background check, drug screening, reference check, etc. and aim to get you settled into <br>your new role by <b>{txtstart.Text}</b>.</p><br>Keep reading to learn more about this opportunity and hopefully answer any lingering questions you may have.<br><b>{txtcompany.Text}</b> will start you out at <b>{txtsalary.Text}</b> per year. You can expect to receive payment monthly starting on {txtstart.Text}.</p><br>Please keep in mind, this employment offer is in no way a legally binding contract. As an at-will employee, both you and {txtcompany.Text} are able to terminate employment for any reason at any time.<br> <p>The <b>{txtcompany.Text}</b> looks forward to bringing you on board! If you have any questions, please feel free to reach out at any time and we will be more than happy to help you.<br><br><b>Best Regards,</b><br>{txtyourname.Text}<br>{txturjobtitle.Text}</body></html>";
            //wel=wel.Replace("[Companyname]",txtcompany.Text);
            //wel = wel.Replace("[jobtitle]", txtjobtitle.Text);
            //wel = wel.Replace("[startdate]", txtstart.Text);
            //wel=wel.Replace("[Salary]",txtsalary.Text);
            //wel=wel.Replace("[YourName]",txtyourname.Text);
            //wel = wel.Replace("[YourJobTitle]", txturjobtitle.Text);

            //Offertxt.Text = wel;
            web.NavigateToString(html);
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            String[] candidates = { "Pavithra","Nithya","Ayesha","Pooja","Selvam" };
            int len = candidates.Length;
            for(int i=0;i<len;i++)
            {
                MessageBox.Show(candidates[i]);
            }
        }

        private void clearbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cleared");
        }

        private void txtdscr_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbllen.Content=$"Your remaining text length{250-txtdscr.Text.Length}/250";
            if (txtdscr.Text.Length > 50)
            {
                lbllen.Foreground = Brushes.Red;
            }
        }
    }
}
