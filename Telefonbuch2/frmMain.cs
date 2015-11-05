using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch2
{
    public partial class frmMain : Form
    {
        string sVname;
        string sName;
        string sNbr;

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            sVname = this.tbVname.Text;
            sName = this.tbName.Text;
            sNbr = this.tbNbr.Text;

            string sEntries = "Vorname:\t\t\t " + sVname + "\nNachname:\t\t " + sName + "\nTelefonnummer:\t " + sNbr;
            this.rtbEntries.Text = sEntries;

        }
    }
}
