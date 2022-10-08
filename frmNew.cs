using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaveensLateFeeCalculator
{
    public partial class frmNew : Form
    {
        

        public frmNew()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            // populates Today's date and  shows it in the textbox txtCurrentDate
        }
        // opens the frmnewrelease window and its layout

        private void frmNew_Load(object sender, EventArgs e)
        {

        }
        // calculates the late fee
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Generates the current date
            DateTime dCurrent = DateTime.Now;
            // Generates the due date based on user entry in textbox txtDue
            DateTime dDue = DateTime.Parse(txtDueDate.Text);
            // Calculates the number of days late
            TimeSpan days = (dCurrent.Date - dDue.Date);
            double numberOfDays = days.TotalDays;
            // Displays the number of days late in the textbox txtNumberofDays
            txtNumberofDaysLate.Text = numberOfDays.ToString();
            // Calculates the late fee, t
            double late_fee = 2 * numberOfDays;
            // Displays the late fee as currency in the textbox txtlatefee
            txtLateFee.Text = late_fee.ToString("c");

        }

        // returns to the home window or frmmain window.
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
