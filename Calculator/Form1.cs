using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {        
        public string LastNum = "0";
        public string LastOrder = "";
        public bool isNewNum = true;
        public bool NoError = true;
        

        public Calculator()
        { InitializeComponent(); }
        
        private void Calculator_Load(object sender, EventArgs e)
        { }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                Screen.Text = num;
                isNewNum = false;
            }

            else if (Screen.Text == "0")
            {
                Screen.Text = num;
            }

            else
            {
                Screen.Text = Screen.Text + num;
            }
        }

        public string Evaluate(string order, string num1, string num2)
        {
            if (order == "+")
            { return (float.Parse(num1) + float.Parse(num2)).ToString(); }
            else if (order == "-")
            { return (float.Parse(num1) - float.Parse(num2)).ToString(); }
            else if (order == "*")
            { return (float.Parse(num1) * float.Parse(num2)).ToString(); }
            else if (order == "/")
            {
                if (float.Parse(num2) == 0)
                {
                    NoError = false;
                    return "Cannot divide by ZERO, Press C."; 
                }
                else
                { return (float.Parse(num1) / float.Parse(num2)).ToString(); }
            }
            else
                return "";
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            if (NoError)
            { SetNum("1"); }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("2"); }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("3"); }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("4"); }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("5"); }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("6"); }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("7"); }
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("8"); }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("9"); }
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            if (NoError)
            { SetNum("0"); }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (Screen.Text == "0")
                {
                    Screen.Text = "0.";
                    isNewNum = false;
                }

                else if (Screen.Text.Contains(".") == false)
                { Screen.Text = Screen.Text + "."; }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            isNewNum = true;
            Screen.Text = "0";
            LastNum = "0";
            LastOrder = "";
            NoError = true;
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (Screen.Text.Length == 1)
                { Screen.Text = "0"; }
                else
                { Screen.Text = Screen.Text[..^1]; }
            }
        }
        
        private void Plus_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (LastOrder == "")
                {
                    LastOrder = "+";
                    LastNum = Screen.Text;
                    isNewNum = true;
                }
                else
                {
                    LastNum = Evaluate(LastOrder, LastNum, Screen.Text);
                    Screen.Text = LastNum;
                    LastOrder = "+";
                    isNewNum = true;
                }
            }
                      
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (LastOrder == "")
                {
                    LastOrder = "-";
                    LastNum = Screen.Text;
                    isNewNum = true;
                }
                else
                {
                    LastNum = Evaluate(LastOrder, LastNum, Screen.Text);
                    Screen.Text = LastNum;
                    LastOrder = "-";
                    isNewNum = true;
                }
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (LastOrder == "")
                {
                    LastOrder = "*";
                    LastNum = Screen.Text;
                    isNewNum = true;
                }
                else
                {
                    LastNum = Evaluate(LastOrder, LastNum, Screen.Text);
                    Screen.Text = LastNum;
                    LastOrder = "*";
                    isNewNum = true;
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (LastOrder == "")
                {
                    LastOrder = "/";
                    LastNum = Screen.Text;
                    isNewNum = true;
                }
                else
                {
                    LastNum = Evaluate(LastOrder, LastNum, Screen.Text);
                    Screen.Text = LastNum;
                    LastOrder = "/";
                    isNewNum = true;
                }
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (NoError)
            {
                if (LastOrder != "" & LastNum != "")
                {
                    LastNum = Evaluate(LastOrder, LastNum, Screen.Text);
                    Screen.Text = LastNum;
                    LastOrder = "";
                    isNewNum = true;
                }
            }
            
        }
    }
}
