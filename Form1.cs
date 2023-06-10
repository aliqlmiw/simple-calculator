using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double answer;
            if (txtNum1.Text != string.Empty)
            {
                if (txtNum2.Text != string.Empty)
                {
                    if (txtSymbol.Text != string.Empty)
                    {
                        if (txtSymbol.Text == "+")
                        {
                            answer = num1 + num2;
                            lblAnswer.Text = "= " + answer;
                        }
                        else if (txtSymbol.Text == "-")
                        {
                            answer = num1 - num2;
                            lblAnswer.Text = "= " + answer;
                        }
                        else if (txtSymbol.Text == "*")
                        {
                            answer = num1 * num2;
                            lblAnswer.Text = "= " + answer;
                        }
                        else if (txtSymbol.Text == "/")
                        {
                            answer = num1 / num2;
                            lblAnswer.Text = "= " + answer;
                        }
                        else 
                            MessageBox.Show("Please insert correct symbols!","Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("please insert symbol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("please insert number 2!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please insert number 1!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtSymbol.Clear();
            lblAnswer.Text = "= ...";
            txtNum1.Focus();
        }
    }
}
