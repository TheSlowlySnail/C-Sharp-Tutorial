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
        Image iContactImg;
        string numberType1 ="";
        string numberType2 = "";
        string numberType3 = "";
        string numberType4 = "";
        string mailType1 = "";
        string mailType2 = "";


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
            of.FilterIndex = 0;
            DialogResult dr = of.ShowDialog();

            if(dr == DialogResult.OK)
            {
                iContactImg = Image.FromFile(of.FileName);
                this.picbContact.Image = iContactImg;
            }
            
        }

        private void cBoxesChanged(object sender, EventArgs e)
        {
            ComboBox cBox = new ComboBox();
            cBox = (ComboBox)sender;

            switch(cBox.Name)
            {
                case"combobNr1":
                    if (cBox.SelectedIndex != -1)
                    {
                        numberType1 = cBox.SelectedItem.ToString();
                        
                    }
                    
                    break;
                case "combobNr2":
                    if (cBox.SelectedIndex != -1)
                    {
                        numberType2 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "combobNr3":
                    if (cBox.SelectedIndex != -1)
                    {
                        numberType3 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "combobNr4":
                    if (cBox.SelectedIndex != -1)
                    {
                        numberType4 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "combobBMail1":
                    if (cBox.SelectedIndex != -1)
                    {
                        mailType1 = cBox.SelectedItem.ToString();
                    }
                    break;
                case "combobBMail2":
                    if (cBox.SelectedIndex != -1)
                    {
                        mailType2 = cBox.SelectedItem.ToString();
                    }
                    break;
                default:
                    break;
            }
        }


       


    }
}
