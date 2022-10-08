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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //instance creation for frmNew class
        frmNew newRelease = new frmNew();

        //instance creation for frmLibrary class
        frmLibrary newLibrary = new frmLibrary();

        //instance creation for frmSystem class
        frmSystems nwsys = new frmSystems();
       
       
        // opens the frmmain window
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void BtnSystems_Click(object sender, EventArgs e)
        {  
            // opens new window and layout of game system
            nwsys.ShowDialog();

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // opens new window and layout of newRelease
            newRelease.ShowDialog();

        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            // opens new window and layout of library
            newLibrary.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // closes the window 
            this.Close();
        }
       
    }
}
