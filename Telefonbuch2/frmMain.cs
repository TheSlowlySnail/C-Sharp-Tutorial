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


        public frmMain()
        {
            InitializeComponent();
        }
         

        private void btSave_Click(object sender, EventArgs e)
        {
            
            this.rtbEntries.Text += saveText("Save BUtton");

        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if (this.cbAll.Checked)
            {
                DialogResult dr = MessageBox.Show("Wirklich löschen", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    deleteAll();
                }
               
                
            }
            else
            {
                deleteFields();
            }
        }
  

        

        public string saveText(string sBt)
        {

            return "Gedrückt wurde " + sBt + "\nVorname:\t\t\t " + this.tbVname.Text + "\nNachname:\t\t " + this.tbName.Text + "\nTelefonnummer:\t " + this.tbNbr.Text + "\n\n";
        }

        public void deleteFields()
        {
            this.tbName.Text = "";
            this.tbVname.Text = "";
            this.tbNbr.Text = "";
            

        }

        public void deleteAll()
        {
            
            deleteFields();
            this.rtbEntries.Text = "";
        }
        



       
    }
}
