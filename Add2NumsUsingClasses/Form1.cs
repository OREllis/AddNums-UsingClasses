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
            //declare class file as doCalcs
            Calcs doCalcs = new Calcs();

            //code to check for errors
            try {
                //parse textboxes as int, pass them to calcSum in Calcs, assign returned int to int sum
                int sum = doCalcs.calcSum(int.Parse(txtNo1.Text), int.Parse(txtNo2.Text), int.Parse(txtNo3.Text));

                //pass sum to calcAvg in Calcs, convert returned val to string, set lblAvg text to coverted val
                lblAvg.Text = doCalcs.calcAvg(sum).ToString("F2");

                //convert sum to string, set lblSum text to converted sum
                lblSum.Text = sum.ToString();
            }
            catch {
                //show error if invalid entry
                MessageBox.Show("Err, enter whole numbers in the textboxes", "Err. Invalid Datatype");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //set textboxes and label text to " "
            txtNo1.Text = txtNo2.Text = txtNo3.Text = lblAvg.Text = lblSum.Text = " ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //exit program
            Application.Exit();
        }

        
    }
}
