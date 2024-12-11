using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Colors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void y_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = y.Background;
        }

        private void y_MouseLeave(object sender, MouseEventArgs e)
        {
            y.Background = Brushes.Yellow;
        }


        private void g_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = g.Background;
        }

        private void g_MouseLeave(object sender, MouseEventArgs e)
        {
            g.Background = Brushes.Green;
        }
        

        private void b_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = b.Background;
        }
        private void b_MouseLeave(object sender, MouseEventArgs e)
        {
            b.Background = Brushes.DarkBlue;
        }

        private void main_MouseLeave(object sender, MouseEventArgs e)
        {
            main.Background = Brushes.Gray;
        }

        private void main_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void o_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = o.Background;
        }

        private void o_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void a_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = a.Background;
        }

        private void a_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void c_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = c.Background;
        }

        private void c_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void f_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = f.Background;
        }

        private void h_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = h.Background;
        }

    
        private void l_MouseEnter(object sender, MouseEventArgs e)
        {
            main.Background = l.Background;
        }
    }
}