using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add2NumsUsingClasses
{
    public partial class frmAddNums : Form
    {
        public frmAddNums()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calcs doCalcs = new Calcs();

            try {
                int sum = doCalcs.calcSum(int.Parse(txtNo1.Text), int.Parse(txtNo2.Text), int.Parse(txtNo3.Text));
                lblAvg.Text = doCalcs.calcAvg(sum).ToString("F2");
                lblSum.Text = sum.ToString();
            }
            catch {
                MessageBox.Show("Err, enter whole numbers in the textboxes", "Err. Invalid Datatype");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNo1.Text = txtNo2.Text = txtNo3.Text = lblAvg.Text = lblSum.Text = " ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
