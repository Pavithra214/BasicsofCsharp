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
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {
        Boolean start = false;
        int questions = 15;
        int answers = 0;
        public Questions()
        {
            InitializeComponent();
            
        }

        private void CommonRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (start)
            {
                RadioButton rbval = (RadioButton)sender;
                if (rbval.Tag.ToString() == "Y")
                {
                    int val = Convert.ToInt32(lblscore.Content);
                    val++;
                    lblscore.Content = val.ToString();
                }
                StackPanel stp = (StackPanel)rbval.Parent;
                int count = stp.Children.Count;
                for (int i = 0; i < count; i++)
                {
                    RadioButton rbbutton = (RadioButton)stp.Children[i];
                    rbbutton.IsEnabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kindly click on start before entering the quiz");
            }
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            start=true;
            MessageBox.Show("Quiz started.All the best");
        }

        private void endbtn_Click(object sender, RoutedEventArgs e)
        {
            Button rbans= (Button)sender;
            int val = Convert.ToInt32(rbans);
            answers = val;
          
                
                if (questions == answers)
                {
                    start = false;
                    MessageBox.Show("Your Score: " + lblscore.Content);
                    lblscore.Content = "0";
                }
            
            else
            {
                MessageBox.Show("Kindly answer all the questions");
            }
                  
            }
          

        }
    }

