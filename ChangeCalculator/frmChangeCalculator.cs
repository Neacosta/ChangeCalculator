using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class frmChangeCalculator : Form
    {
        public frmChangeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int changeDue = Convert.ToInt32(txtChangeDue.Text);

            int quarter = changeDue / 25;
            txtQuarters.Text = quarter.ToString();


            int dimes = (changeDue % 25) / 10;
            txtDimes.Text = dimes.ToString();


            int nickels = (changeDue % 25) % 10 / 5;
            txtNickels.Text = nickels.ToString();


            int Pennies = (changeDue % 25) % 10 % 5;
            txtPennies.Text = Pennies.ToString();

            txtChangeDue.Focus();
            txtChangeDue.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
