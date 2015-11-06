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
        #region "Variablen"
        Image iContactImg;
        string numberType1 = "";
        string numberType2 = "";
        string numberType3 = "";
        string numberType4 = "";
        string mailType1 = "";
        string mailType2 = "";
        
        
        #region"Tab Adresse"
        string sName = "";
        string sVname = "";
        string sNickname = "";
        string sTitle = "";
        string sStreet = "";
        string sStreetNr = "";
        string sPLZ = "";
        string sTown = "";
        string sCountry = "";
        #endregion
        #region"Tab Sonstiges"
        string sEmail1 = "";
        string sEmail2 = "";
        #endregion
        
        #endregion
        #region"Integer"
        int iCc1;
        int iAc1;
        int iNr1;
        int iCc2;
        int iAc2;
        int iNr2;
        int iCc3;
        int iAc3;
        int iNr3;
        int iCc4;
        int iAc4;
        int iNr4;
        #endregion

        #region"Sonstige"
        DateTime dtBirthday;
        bool isFemale;
        #endregion


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

        private void btnDeleteClicked(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnDelNr1":
                    this.maskBCC1.Text = "49";
                    this.tbNbrVw1.Text = "";
                    this.tbNr1.Text = "";
                    this.combobNr1.SelectedIndex = -1;
                    break;
                case "btnDelNr2":
                    this.maskBCC2.Text = "49";
                    this.tbNbrVw2.Text = "";
                    this.tbNr2.Text = "";
                    this.combobNr2.SelectedIndex = -1;
                    break;
                case "btnDelNr3":
                    this.maskBCC3.Text = "49";
                    this.tbNbrVw3.Text = "";
                    this.tbNr3.Text = "";
                    this.combobNr3.SelectedIndex = -1;
                    break;
                case "btnDelNr4":
                    this.maskBCC4.Text = "49";
                    this.tbNbrVw4.Text = "";
                    this.tbNr4.Text = "";
                    this.combobNr4.SelectedIndex = -1;
                    break;
                
            }
        }
        //Vorschau Anzeigen
        private void btPreview_Click(object sender, EventArgs e)
        {
            
            
            
             sName = this.tbName.Text;
             sVname = this.tbVname.Text;
             sNickname = this.tbNickname.Text;
             sTitle = this.tbTitle.Text;
             sStreet = this.tbStreet.Text;
             sStreetNr = this.tbHNr.Text;
             sPLZ = this.tbZIP.Text;
             sTown = this.tbTown.Text;
             sCountry = this.tbCountry.Text;

             sEmail1 = mailStringCheck(this.tbMail1.Text);
             sEmail2 = mailStringCheck(this.tbMail2.Text);

             if (this.rbFemale.Checked)
             {
                 isFemale = true;
             }
             else
             {
                 isFemale = false;
             }
             iCc1 = int.Parse(this.maskBCC1.Text);
             iCc2 = int.Parse(this.maskBCC2.Text);
             iCc3 = int.Parse(this.maskBCC3.Text);
             iCc4 = int.Parse(this.maskBCC4.Text);

             try
             {
                 if (this.tbNbrVw1.Text !="") iAc1 = int.Parse(this.tbNbrVw1.Text);
                 if (this.tbNbrVw2.Text != "") iAc2 = int.Parse(this.tbNbrVw2.Text);
                 if (this.tbNbrVw3.Text != "") iAc3 = int.Parse(this.tbNbrVw3.Text);
                 if (this.tbNbrVw4.Text != "") iAc4 = int.Parse(this.tbNbrVw4.Text);
                 if (this.tbNr1.Text != "") iNr1 = int.Parse(this.tbNr1.Text);
                 if (this.tbNr2.Text != "") iNr2 = int.Parse(this.tbNr2.Text);
                 if (this.tbNr3.Text != "") iNr3 = int.Parse(this.tbNr3.Text);
                 if (this.tbNr4.Text != "") iNr4 = int.Parse(this.tbNr4.Text);
             }
             catch
             {
                 MessageBox.Show("Nur Zahlen", "FEHLER", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
              frmPreview fPre = new frmPreview();
            

             dtBirthday = this.tbBirthday.Value;
             fPre.Text += " " + prepereShowPreview(sName, sVname, sNickname, sTitle, this.combobShowAs.SelectedIndex.ToString());
             
             //fPre.lbPvNameC.Text = "TEST";
             
            

             fPre.Show();

             //MessageBox.Show(dtBirthday.ToString(), "DATE", MessageBoxButtons.OK, MessageBoxIcon.None);
        


        }


        
        //Check on @
        string mailStringCheck(string sMail)
        {
            if (sMail != "")
            {
                if (sMail.IndexOf("@") == -1)
                {
                    MessageBox.Show("Keine Valide Emailadresse");
                    return sMail;
                }
                else
                {
                    return sMail;

                }
            }
            else
            {
                return sMail;

            }
            
        }

        string prepereShowPreview(string sName, string sFirstName, string sNickName, string sTitle, string sShowAs)
        {


            switch (sShowAs)
            {
                case "0":
                    return sName + ", " + sFirstName;
                    
                case "1":
                    return sFirstName + " " + sName;
                    
                case "2":
                    return sName + ", " + sFirstName + " " + sNickName;
                    
                case "3":
                    return sTitle + " " + sName + ", " + sFirstName + " " + sNickName;
                  
                default:
                    return sName + ", " + sFirstName;
                    
            }
        }

        string prepereMailPreview(string sMail)
        {
            if (sMail == "")
            {
                return "----";
            }
            else
            {
                return sMail;
            }

            
        }

       


       


    }
}
