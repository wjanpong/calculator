using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAL
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operator_perform = "";
        bool isperform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((TextShow.Text == "0") || (isperform))
            {
                TextShow.Clear();
            }
            isperform = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TextShow.Text.Contains("."))
                {
                    TextShow.Text = TextShow.Text + button.Text;
                }
            }
            else
            {
                TextShow.Text = TextShow.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(result != 0)
            {
                button2.PerformClick();
                operator_perform = button.Text;
                current.Text = result + " " + operator_perform;
                isperform = true;
            }
            operator_perform = button.Text;
            result = Double.Parse(TextShow.Text);
            current.Text = result + " " + operator_perform;
            isperform = true;

        }

        private void CE_click(object sender, EventArgs e)
        {
            TextShow.Text= "0";
            result = 0;
        }

        private void C_click(object sender, EventArgs e)
        {
            TextShow.Text = "0";
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch(operator_perform)
            {
                case "+":
                    TextShow.Text = (result + Double.Parse(TextShow.Text)).ToString();
                    break;
                case "-":
                    TextShow.Text = (result - Double.Parse(TextShow.Text)).ToString();
                    break;
                case "*":
                    TextShow.Text = (result * Double.Parse(TextShow.Text)).ToString();
                    break;
                case "/":
                    TextShow.Text = (result / Double.Parse(TextShow.Text)).ToString();
                    break;
             
                default:
                    break;
            }
            operator_perform = " ";
            result = Double.Parse(TextShow.Text);
            current.Text = "";
        }
    }
}
