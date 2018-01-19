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

                //pass sum to calcAvg in Calcs, assign returned val to avg
                double avg = doCalcs.calcAvg(sum);

                //pass sum & avg to method that sets labels to passed values
                displayDetails(sum, avg);
            }
            catch {
                //show error if invalid entry
                MessageBox.Show("Err, enter whole numbers in the textboxes", "Err. Invalid Datatype");
            }
        }

        public void displayDetails(int sumTotal, double average) {
            //set lblSum.Text to .ToString(); converted int sumTotal
            lblSum.Text = sumTotal.ToString();

            //set lblAvg to .ToString("F2"); converted double average
            lblAvg.Text = average.ToString("F2");
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
