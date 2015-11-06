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

        
        //Button New
        private void btNew_Click(object sender, EventArgs e)
        {
            this.tabContactInfo.Visible = true;
            this.btPreview.Visible = true;
            this.btSave.Visible = true;
            this.lbChoice.Visible = false;
        }
        //ComboBox ShowAs  --> Auswahl geändert
        private void combobShowAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.combobShowAs.SelectedIndex)
            {
                case 0:
                    this.lbExample.Text = "Beispiel " + this.tbName.Text + ", " + this.tbVname.Text;
                    break;
                case 1:
                    this.lbExample.Text = "Beispiel " + this.tbVname.Text + " " + this.tbName.Text;
                    break;
                case 2:
                    this.lbExample.Text = "Beispiel " + this.tbName.Text + ", " + this.tbVname.Text + " " + this.tbNickname.Text;
                    break;
                case 3:
                    this.lbExample.Text = "Beispiel "+this.tbTitle.Text+ " " + this.tbName.Text + ", " + this.tbVname.Text + " " + this.tbNickname.Text;
                    break;
                default:
                    break;
            }
        }
        //Load Picture
        private void btPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Bitte Bild auswählen";
            of.Multiselect = false;
            of.Filter = "Bilder|*.png;*.jpg|PNG-Bilder|*.png|JPG-Bilder|*.jpg";
            of.ShowDialog();
        }


       


    }
}
