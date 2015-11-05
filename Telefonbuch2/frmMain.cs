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
            saveText();

        }

        private void btOne_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void btThree_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void btFour_Click(object sender, EventArgs e)
        {
            saveText();
        }

        public void saveText()
        {
            sVname = this.tbVname.Text;
            sName = this.tbName.Text;
            sNbr = this.tbNbr.Text;

            string sEntries = "Vorname:\t\t\t " + sVname + "\nNachname:\t\t " + sName + "\nTelefonnummer:\t " + sNbr + "\n\n";
            this.rtbEntries.Text += sEntries;
        }
    }
}
