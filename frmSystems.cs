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
    public partial class frmSystems : Form
    {
        public frmSystems()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            // populates Today's date and shows it in the textbox txtCurrentDate
        }

       
       // returns to the home window and hides current window
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // calculates the late fee according to how many days late
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Generates the current date
            DateTime dCurrent = DateTime.Now;

            // Generates the due date based on user entry in textbox txtDue
            DateTime dDue = DateTime.Parse(txtDueDate.Text);

            // Calculates the number of days late
            TimeSpan days = (dCurrent.Date - dDue.Date);
            double numberOfDays = days.TotalDays;

            // Display the number of days late in the textbox txtnumberofDays
            txtNumberofDaysLate.Text = numberOfDays.ToString();


            // Calculates the late fee,
            double late_fee = 5 * numberOfDays;

            // Displays the late fee as currency in the textbox txtFee
            txtLateFee.Text = late_fee.ToString("c");

        }
    }
}
