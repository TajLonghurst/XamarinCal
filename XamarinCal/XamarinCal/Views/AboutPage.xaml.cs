using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCal.Views
{
    public partial class AboutPage : ContentPage
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double Answer = 0.0;

        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Plus(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Button_Divied(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Button_Minus(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Button_Multiply(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            Result.Text = "";
            operand1 = 0.ToString();
            operand2 = 0.ToString();
            Answer.ToString();
        }
        private void Button_Equal(object sender, EventArgs e)
        {

            operand2 = input;
            double NumOne, NumTwo;
            double.TryParse(operand1, out NumOne);
            double.TryParse(operand2, out NumTwo);

            ResultHistory.Text = NumOne.ToString() + " " + operation + " " + NumTwo.ToString();

            if (operation == '+')
            {
                Answer = NumOne + NumTwo;
                Result.Text = Answer.ToString();
            }
            else if (operation == '-')
            {
                Answer = NumOne - NumTwo;
                Result.Text = Answer.ToString();
            }
            else if (operation == 'x')
            {
                Answer = NumOne * NumTwo;
                Result.Text = Answer.ToString();
            }
            else if (operation == '/')
            {
                if (NumTwo != 0)
                {
                    Answer = NumOne / NumTwo;
                    Result.Text = Answer.ToString();
                }
                else
                {
                    Result.Text = "DIV/Zero!";
                }

            }
        }


        //Button Functions
        private void Button_Zero(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "0";
            this.Result.Text += input;
        }
        private void Button_One(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "1";
            this.Result.Text += input;
        }
        private void Button_Two(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "2";
            this.Result.Text += input;
        }
        private void Button_Three(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "3";
            this.Result.Text += input;
        }
        private void Button_Four(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "4";
            this.Result.Text += input;
        }
        private void Button_Five(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "5";
            this.Result.Text += input;
        }
        private void Button_Six(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "6";
            this.Result.Text += input;
        }
        private void Button_Seven(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "7";
            this.Result.Text += input; 
        }
        private void Button_Eight(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "8";
            this.Result.Text += input;
        }
        private void Button_Nine(object sender, EventArgs e)
        {
            this.Result.Text = "";
            input += "9";
            this.Result.Text += input; Result.Text = Result.Text + "9";
        }
    }
}