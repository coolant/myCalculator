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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Char currentOperator;
        Brush defaultBackground;
        bool itDoesnotContainsOperator = false;



        public MainWindow()
        {
            InitializeComponent();
            String outp = Output.Text = "0";
            defaultBackground = BTN1.Background;
        }
        

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            if(Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "1";

            BTN1.Background = Brushes.Red;
        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "2";
       

        }

        private void BTN3_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "3";
           

        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "4";
       
        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "8";
          

        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "7";
          

        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "6";
          

        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "5";
        

        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "9";
        }

        private void BTN0_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text.Equals("0"))
                Output.Text = "";
            Output.Text = Output.Text + "0";
        }

        private void BTNMinus_Click(object sender, RoutedEventArgs e)
        {
            
            if(itDoesnotContainsOperator){
             Output.Text = Output.Text + "-";
             currentOperator = '-';
                }
              itContainsOperator=true;      

        }

        private void BTNPlus_Click(object sender, RoutedEventArgs e)
        {
             if(itDoesnotContainsOperator){
             Output.Text = Output.Text + "+";
             currentOperator = '+';
                }
              itContainsOperator=true; 

        }

        private void BTNDiv_Click(object sender, RoutedEventArgs e)
        {
            if(itDoesnotContainsOperator){
             Output.Text = Output.Text + "/";
             currentOperator = '/';
                }
              itContainsOperator=true; 

        }

        private void BTNMul_Click(object sender, RoutedEventArgs e)
        {
              if(itDoesnotContainsOperator){
             Output.Text = Output.Text + "*";
             currentOperator = '*';
                }
              itContainsOperator=true; 

        }

        private void BTNEq_Click(object sender, RoutedEventArgs e)
        {
            
            String myText = Output.Text;
            Char lastElement = myText.ElementAt(Output.Text.Length - 1);
            Char min = '-';
            Char plus = '+';
            Char multip = '*';
            Char divide = '/';
            String[] numbers;
            int nr0;
            int nr1;
            int result;
            numbers = myText.Split(currentOperator);
            nr0 = Int32.Parse(numbers[0]);

            if (!myText.Contains(currentOperator))
            {
                nr1 = 0;
            }
            else if (lastElement.Equals(currentOperator))
            {
                nr1 = 0;

            }
            else
            {
                nr1 = Int32.Parse(numbers[1]);
            }




            if (currentOperator.Equals(min))
            {
                result = nr0 - nr1;
            } else if (currentOperator.Equals(plus)) {
                result = nr0 + nr1;
            } else if (currentOperator.Equals(divide))
            {
                result = nr0 / nr1;
            }
            else {
                result = nr0 * nr1;
            }

            Output.Text = result.ToString();



        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = "0";
            

        }

      

        private void BTN9_MouseLeave(object sender, MouseEventArgs e)
        {
            BTN9.Background = Brushes.Gray;
        }
    }
}
