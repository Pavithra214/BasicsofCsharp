using System;
using System.Collections;
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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        Boolean start = false;
        int count = 0;
        public Game()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
          
            if (start)
            {
                
                if (count>=3)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Your total score is: ");
                    sb.Append(lblamt.Content);
                    MessageBox.Show(sb.ToString());
                }
                else
                {
                    Button btn = (Button)sender;
                    if(btn.IsEnabled==true)
                    {   
                        count++;
                        btn.Content = btn.Tag;
                     
                      btn.IsEnabled = false;
                        int value = Convert.ToInt32(lblamt.Content);
                        value = value + Convert.ToInt32(btn.Tag);
                        lblamt.Content = value;
                    }
                    else
                    {
                        MessageBox.Show("Choose the unselected box");
                    }
                }
          

            }
            else
            {
                MessageBox.Show("Kindly click the start button before entering the game");
            }
        }
        private void Startbtn_Click(object sender, RoutedEventArgs e)
        {
            start = true;
           
            
                MessageBox.Show("Game started.All the best!" +
                    "");
            
        }

        private void Stopbtn_Click(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                MessageBoxResult msg = MessageBox.Show("Are you sure to quit the game ?", "Lucky Draw", MessageBoxButton.YesNo);
                if (msg == MessageBoxResult.Yes)
                {
                    start = false;
                    lblamt.Content = 0;
                    count = 0;
                }
            }
            else
            {
                MessageBox.Show("Kindly click on start before exiting the game");
            }
        }

        private void Newbtn_Click(object sender, RoutedEventArgs e)
        {
            UIElementCollection buttons = mainstack.Children;
            int count = buttons.Count;
            for (int i = 0; i < count; i++)
            {
                if (buttons[i] is Button)
                {
                    Button btn = (Button)buttons[i];
                    String val = btn.Tag.ToString();
                    MessageBox.Show("Your Tag value is "+val);
                    btn.IsEnabled = true;
                }
            }
        }
    }

}    
    
