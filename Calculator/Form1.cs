using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int selection = 0;
        double number1, number2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttons(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + ((Button)sender).Text;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            selection = 1;
            txtDisplay.Text = "0";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            selection = 2;
            txtDisplay.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            selection = 3;
            txtDisplay.Text = "0";
        }

        public void btnDivision_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            selection = 4;
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtDisplay.Text);
            if (selection == 1)
            {
                result = number1 + number2;
            }
            txtDisplay.Text = result.ToString();
            if (selection == 2)
            {
                result = number1 - number2;
            }
            txtDisplay.Text = result.ToString();
            if (selection == 3)
            {
                result = number1 * number2;
            }
            txtDisplay.Text = result.ToString();
            if (selection == 4)
            {
                result = number1 / number2;
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.IndexOf(".") < 1)
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                if (txtDisplay.Text.StartsWith("-"))
                {
                    txtDisplay.Text = txtDisplay.Text.Replace("-", "");
                }
                else if (txtDisplay.Text.StartsWith(""))
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            number1 = 0;
            number2 = 0;
            result = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}
