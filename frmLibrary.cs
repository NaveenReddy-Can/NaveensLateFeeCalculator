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
    public partial class frmLibrary : Form
    {
        public frmLibrary()
        {
            InitializeComponent();
            txtCurrentDate.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            // populates Today's date and shows it in the textbox txtCurrent
        }

        // opens the Library window and its layout
        private void frmLibrary_Load(object sender, EventArgs e)
        {

        }
      
        // button calculates the late fee accordingly
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Generate the current date
            DateTime dCurrent = DateTime.Now;
            // Generate the due date based on user entry in textbox txtDue
            DateTime dDue = DateTime.Parse(txtDueDate.Text);
            // Calculate the number of days late
            TimeSpan days = (dCurrent.Date - dDue.Date);
            double numberOfDays = days.TotalDays;
            // Display the number of days late in the textbox txtNum
            txtNumberofDaysLate.Text = numberOfDays.ToString();
            // Calculate the late fee, the ‘2’ will change for each of the types of game
            double late_fee = 0.77 * numberOfDays;
            // Displays the late fee as currency in the textbox txtFee
            txtLateFee.Text = late_fee.ToString("c");
        }

        // returns to home window
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
