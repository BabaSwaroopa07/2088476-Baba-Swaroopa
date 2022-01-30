using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalc
{
    public partial class lblInputs : Form
    {
        public lblInputs()
        {
            InitializeComponent();
            Text = "Calculator";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int input1 = Convert.ToInt32 (textinput1.Text);
            int input2 = Convert.ToInt32(textinput2.Text);   
            if (rbtnAdd.Checked)
            {
               int Addition = input1 + input2;
                MessageBox.Show("Result: "+Addition);
            }else if (rbtnSub.Checked)
            {
                int  Subtraction = input1 - input2;
                MessageBox.Show("Result: " + Subtraction);
            }
            else if (rbtnMul.Checked)
            {
                int Multiplication = input1 * input2;
                MessageBox.Show("Result" + Multiplication);
            }
            else if(rbtnDiv.Checked)
            {
                int Division = input1 / input2;
                MessageBox.Show("Result" + Division);

            }
            else
            {
                MessageBox.Show(" Please enter valid input for operands");
            }

                

            }

        private void lblInputs_Load(object sender, EventArgs e)
        {

        }
    }
   
}
