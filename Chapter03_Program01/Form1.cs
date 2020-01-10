using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03_Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;

            //check the first input
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if(flag == false)
            {
                MessageBox.Show("Enter a whole number first box", "Input error");
                txtOperand1.Focus();
                txtOperand1.Clear();
                return;
            }
            //check the second input
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number second box", "Input error");
                txtOperand2.Focus();
                txtOperand1.Clear();
                return;
            }
            answer = operand1 / operand2;
            txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() +" equals " + answer.ToString();
        }
    }
}
