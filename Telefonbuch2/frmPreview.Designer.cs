namespace Telefonbuch2
{
    partial class frmPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPvName = new System.Windows.Forms.Label();
            this.lbPvFName = new System.Windows.Forms.Label();
            this.lbPvNick = new System.Windows.Forms.Label();
            this.lbPvTitle = new System.Windows.Forms.Label();
            this.lbPvBirth = new System.Windows.Forms.Label();
            this.lbPvGender = new System.Windows.Forms.Label();
            this.grBAdress = new System.Windows.Forms.GroupBox();
            this.lbPrevStreet = new System.Windows.Forms.Label();
            this.lbPrevPLZ = new System.Windows.Forms.Label();
            this.lbPrevTown = new System.Windows.Forms.Label();
            this.lbPrevCountry = new System.Windows.Forms.Label();
            this.gpBNumb = new System.Windows.Forms.GroupBox();
            this.lbPrevNr3 = new System.Windows.Forms.Label();
            this.lbPrevNr4 = new System.Windows.Forms.Label();
            this.lbPrevNr2 = new System.Windows.Forms.Label();
            this.lbPrevNr1 = new System.Windows.Forms.Label();
            this.gpBMail = new System.Windows.Forms.GroupBox();
            this.lbPrevMail2 = new System.Windows.Forms.Label();
            this.lbPrevMail1 = new System.Windows.Forms.Label();
            this.lbPvNameC = new System.Windows.Forms.Label();
            this.lbPvFNameC = new System.Windows.Forms.Label();
            this.lbPvNickC = new System.Windows.Forms.Label();
            this.lbPvTitleC = new System.Windows.Forms.Label();
            this.lbPvGenderC = new System.Windows.Forms.Label();
            this.lbPvBirthC = new System.Windows.Forms.Label();
            this.lbPrevTownC = new System.Windows.Forms.Label();
            this.lbPrevStreetC = new System.Windows.Forms.Label();
            this.lbPrevPLZC = new System.Windows.Forms.Label();
            this.lbPrevCountryC = new System.Windows.Forms.Label();
            this.lbPrevNr1C = new System.Windows.Forms.Label();
            this.lbPrevNr2C = new System.Windows.Forms.Label();
            this.lbPrevNr3C = new System.Windows.Forms.Label();
            this.lbPrevNr4C = new System.Windows.Forms.Label();
            this.lbPrevMail1C = new System.Windows.Forms.Label();
            this.lbPrevMail2C = new System.Windows.Forms.Label();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grBAdress.SuspendLayout();
            this.gpBNumb.SuspendLayout();
            this.gpBMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPvName
            // 
            this.lbPvName.AutoSize = true;
            this.lbPvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvName.Location = new System.Drawing.Point(36, 41);
            this.lbPvName.Name = "lbPvName";
            this.lbPvName.Size = new System.Drawing.Size(89, 20);
            this.lbPvName.TabIndex = 0;
            this.lbPvName.Text = "Nachname";
            // 
            // lbPvFName
            // 
            this.lbPvFName.AutoSize = true;
            this.lbPvFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvFName.Location = new System.Drawing.Point(36, 77);
            this.lbPvFName.Name = "lbPvFName";
            this.lbPvFName.Size = new System.Drawing.Size(76, 20);
            this.lbPvFName.TabIndex = 1;
            this.lbPvFName.Text = "Vorname";
            // 
            // lbPvNick
            // 
            this.lbPvNick.AutoSize = true;
            this.lbPvNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvNick.Location = new System.Drawing.Point(36, 113);
            this.lbPvNick.Name = "lbPvNick";
            this.lbPvNick.Size = new System.Drawing.Size(88, 20);
            this.lbPvNick.TabIndex = 2;
            this.lbPvNick.Text = "Spitzname";
            // 
            // lbPvTitle
            // 
            this.lbPvTitle.AutoSize = true;
            this.lbPvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvTitle.Location = new System.Drawing.Point(36, 149);
            this.lbPvTitle.Name = "lbPvTitle";
            this.lbPvTitle.Size = new System.Drawing.Size(41, 20);
            this.lbPvTitle.TabIndex = 3;
            this.lbPvTitle.Text = "Titel";
            // 
            // lbPvBirth
            // 
            this.lbPvBirth.AutoSize = true;
            this.lbPvBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvBirth.Location = new System.Drawing.Point(199, 185);
            this.lbPvBirth.Name = "lbPvBirth";
            this.lbPvBirth.Size = new System.Drawing.Size(92, 20);
            this.lbPvBirth.TabIndex = 4;
            this.lbPvBirth.Text = "Geburtstag";
            this.lbPvBirth.Click += new System.EventHandler(this.lbPvBirth_Click);
            // 
            // lbPvGender
            // 
            this.lbPvGender.AutoSize = true;
            this.lbPvGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPvGender.Location = new System.Drawing.Point(36, 185);
            this.lbPvGender.Name = "lbPvGender";
            this.lbPvGender.Size = new System.Drawing.Size(94, 20);
            this.lbPvGender.TabIndex = 5;
            this.lbPvGender.Text = "Geschlecht";
            // 
            // grBAdress
            // 
            this.grBAdress.Controls.Add(this.lbPrevTownC);
            this.grBAdress.Controls.Add(this.lbPrevStreetC);
            this.grBAdress.Controls.Add(this.lbPrevPLZC);
            this.grBAdress.Controls.Add(this.lbPrevCountryC);
            this.grBAdress.Controls.Add(this.lbPrevCountry);
            this.grBAdress.Controls.Add(this.lbPrevTown);
            this.grBAdress.Controls.Add(this.lbPrevPLZ);
            this.grBAdress.Controls.Add(this.lbPrevStreet);
            this.grBAdress.Location = new System.Drawing.Point(40, 227);
            this.grBAdress.Name = "grBAdress";
            this.grBAdress.Size = new System.Drawing.Size(368, 105);
            this.grBAdress.TabIndex = 6;
            this.grBAdress.TabStop = false;
            this.grBAdress.Text = "Adresse";
            // 
            // lbPrevStreet
            // 
            this.lbPrevStreet.AutoSize = true;
            this.lbPrevStreet.Location = new System.Drawing.Point(6, 27);
            this.lbPrevStreet.Name = "lbPrevStreet";
            this.lbPrevStreet.Size = new System.Drawing.Size(51, 17);
            this.lbPrevStreet.TabIndex = 7;
            this.lbPrevStreet.Text = "Straße";
            // 
            // lbPrevPLZ
            // 
            this.lbPrevPLZ.AutoSize = true;
            this.lbPrevPLZ.Location = new System.Drawing.Point(6, 48);
            this.lbPrevPLZ.Name = "lbPrevPLZ";
            this.lbPrevPLZ.Size = new System.Drawing.Size(34, 17);
            this.lbPrevPLZ.TabIndex = 8;
            this.lbPrevPLZ.Text = "PLZ";
            // 
            // lbPrevTown
            // 
            this.lbPrevTown.AutoSize = true;
            this.lbPrevTown.Location = new System.Drawing.Point(171, 48);
            this.lbPrevTown.Name = "lbPrevTown";
            this.lbPrevTown.Size = new System.Drawing.Size(41, 17);
            this.lbPrevTown.TabIndex = 9;
            this.lbPrevTown.Text = "Stadt";
            // 
            // lbPrevCountry
            // 
            this.lbPrevCountry.AutoSize = true;
            this.lbPrevCountry.Location = new System.Drawing.Point(6, 69);
            this.lbPrevCountry.Name = "lbPrevCountry";
            this.lbPrevCountry.Size = new System.Drawing.Size(40, 17);
            this.lbPrevCountry.TabIndex = 10;
            this.lbPrevCountry.Text = "Land";
            
            // 
            // gpBNumb
            // 
            this.gpBNumb.Controls.Add(this.lbPrevNr1C);
            this.gpBNumb.Controls.Add(this.lbPrevNr2C);
            this.gpBNumb.Controls.Add(this.lbPrevNr3C);
            this.gpBNumb.Controls.Add(this.lbPrevNr4C);
            this.gpBNumb.Controls.Add(this.lbPrevNr3);
            this.gpBNumb.Controls.Add(this.lbPrevNr4);
            this.gpBNumb.Controls.Add(this.lbPrevNr2);
            this.gpBNumb.Controls.Add(this.lbPrevNr1);
            this.gpBNumb.Location = new System.Drawing.Point(40, 350);
            this.gpBNumb.Name = "gpBNumb";
            this.gpBNumb.Size = new System.Drawing.Size(368, 117);
            this.gpBNumb.TabIndex = 11;
            this.gpBNumb.TabStop = false;
            this.gpBNumb.Text = "Telefon";
            // 
            // lbPrevNr3
            // 
            this.lbPrevNr3.AutoSize = true;
            this.lbPrevNr3.Location = new System.Drawing.Point(6, 65);
            this.lbPrevNr3.Name = "lbPrevNr3";
            this.lbPrevNr3.Size = new System.Drawing.Size(73, 17);
            this.lbPrevNr3.TabIndex = 10;
            this.lbPrevNr3.Text = "Nummer 3";
            // 
            // lbPrevNr4
            // 
            this.lbPrevNr4.AutoSize = true;
            this.lbPrevNr4.Location = new System.Drawing.Point(6, 84);
            this.lbPrevNr4.Name = "lbPrevNr4";
            this.lbPrevNr4.Size = new System.Drawing.Size(73, 17);
            this.lbPrevNr4.TabIndex = 9;
            this.lbPrevNr4.Text = "Nummer 4";
            // 
            // lbPrevNr2
            // 
            this.lbPrevNr2.AutoSize = true;
            this.lbPrevNr2.Location = new System.Drawing.Point(6, 46);
            this.lbPrevNr2.Name = "lbPrevNr2";
            this.lbPrevNr2.Size = new System.Drawing.Size(73, 17);
            this.lbPrevNr2.TabIndex = 8;
            this.lbPrevNr2.Text = "Nummer 2";
            // 
            // lbPrevNr1
            // 
            this.lbPrevNr1.AutoSize = true;
            this.lbPrevNr1.Location = new System.Drawing.Point(6, 27);
            this.lbPrevNr1.Name = "lbPrevNr1";
            this.lbPrevNr1.Size = new System.Drawing.Size(73, 17);
            this.lbPrevNr1.TabIndex = 7;
            this.lbPrevNr1.Text = "Nummer 1";
            // 
            // gpBMail
            // 
            this.gpBMail.Controls.Add(this.lbPrevMail1C);
            this.gpBMail.Controls.Add(this.lbPrevMail2C);
            this.gpBMail.Controls.Add(this.lbPrevMail2);
            this.gpBMail.Controls.Add(this.lbPrevMail1);
            this.gpBMail.Location = new System.Drawing.Point(40, 491);
            this.gpBMail.Name = "gpBMail";
            this.gpBMail.Size = new System.Drawing.Size(368, 105);
            this.gpBMail.TabIndex = 11;
            this.gpBMail.TabStop = false;
            this.gpBMail.Text = "E-Mails";
            // 
            // lbPrevMail2
            // 
            this.lbPrevMail2.AutoSize = true;
            this.lbPrevMail2.Location = new System.Drawing.Point(6, 48);
            this.lbPrevMail2.Name = "lbPrevMail2";
            this.lbPrevMail2.Size = new System.Drawing.Size(59, 17);
            this.lbPrevMail2.TabIndex = 8;
            this.lbPrevMail2.Text = "E-Mail 2";
            // 
            // lbPrevMail1
            // 
            this.lbPrevMail1.AutoSize = true;
            this.lbPrevMail1.Location = new System.Drawing.Point(6, 27);
            this.lbPrevMail1.Name = "lbPrevMail1";
            this.lbPrevMail1.Size = new System.Drawing.Size(59, 17);
            this.lbPrevMail1.TabIndex = 7;
            this.lbPrevMail1.Text = "E-Mail 1";
            // 
            // lbPvNameC
            // 
            this.lbPvNameC.AutoSize = true;
            this.lbPvNameC.Location = new System.Drawing.Point(200, 44);
            this.lbPvNameC.Name = "lbPvNameC";
            this.lbPvNameC.Size = new System.Drawing.Size(43, 17);
            this.lbPvNameC.TabIndex = 11;
            this.lbPvNameC.Text = "-------";
            // 
            // lbPvFNameC
            // 
            this.lbPvFNameC.AutoSize = true;
            this.lbPvFNameC.Location = new System.Drawing.Point(200, 80);
            this.lbPvFNameC.Name = "lbPvFNameC";
            this.lbPvFNameC.Size = new System.Drawing.Size(43, 17);
            this.lbPvFNameC.TabIndex = 12;
            this.lbPvFNameC.Text = "-------";
            // 
            // lbPvNickC
            // 
            this.lbPvNickC.AutoSize = true;
            this.lbPvNickC.Location = new System.Drawing.Point(200, 113);
            this.lbPvNickC.Name = "lbPvNickC";
            this.lbPvNickC.Size = new System.Drawing.Size(43, 17);
            this.lbPvNickC.TabIndex = 13;
            this.lbPvNickC.Text = "-------";
            // 
            // lbPvTitleC
            // 
            this.lbPvTitleC.AutoSize = true;
            this.lbPvTitleC.Location = new System.Drawing.Point(200, 149);
            this.lbPvTitleC.Name = "lbPvTitleC";
            this.lbPvTitleC.Size = new System.Drawing.Size(43, 17);
            this.lbPvTitleC.TabIndex = 14;
            this.lbPvTitleC.Text = "-------";
            // 
            // lbPvGenderC
            // 
            this.lbPvGenderC.AutoSize = true;
            this.lbPvGenderC.Location = new System.Drawing.Point(136, 185);
            this.lbPvGenderC.Name = "lbPvGenderC";
            this.lbPvGenderC.Size = new System.Drawing.Size(43, 17);
            this.lbPvGenderC.TabIndex = 15;
            this.lbPvGenderC.Text = "-------";
            // 
            // lbPvBirthC
            // 
            this.lbPvBirthC.AutoSize = true;
            this.lbPvBirthC.Location = new System.Drawing.Point(315, 188);
            this.lbPvBirthC.Name = "lbPvBirthC";
            this.lbPvBirthC.Size = new System.Drawing.Size(43, 17);
            this.lbPvBirthC.TabIndex = 16;
            this.lbPvBirthC.Text = "-------";
            // 
            // lbPrevTownC
            // 
            this.lbPrevTownC.AutoSize = true;
            this.lbPrevTownC.Location = new System.Drawing.Point(275, 48);
            this.lbPrevTownC.Name = "lbPrevTownC";
            this.lbPrevTownC.Size = new System.Drawing.Size(43, 17);
            this.lbPrevTownC.TabIndex = 17;
            this.lbPrevTownC.Text = "-------";
            // 
            // lbPrevStreetC
            // 
            this.lbPrevStreetC.AutoSize = true;
            this.lbPrevStreetC.Location = new System.Drawing.Point(96, 27);
            this.lbPrevStreetC.Name = "lbPrevStreetC";
            this.lbPrevStreetC.Size = new System.Drawing.Size(43, 17);
            this.lbPrevStreetC.TabIndex = 18;
            this.lbPrevStreetC.Text = "-------";
            // 
            // lbPrevPLZC
            // 
            this.lbPrevPLZC.AutoSize = true;
            this.lbPrevPLZC.Location = new System.Drawing.Point(96, 48);
            this.lbPrevPLZC.Name = "lbPrevPLZC";
            this.lbPrevPLZC.Size = new System.Drawing.Size(43, 17);
            this.lbPrevPLZC.TabIndex = 19;
            this.lbPrevPLZC.Text = "-------";
           
            // 
            // lbPrevCountryC
            // 
            this.lbPrevCountryC.AutoSize = true;
            this.lbPrevCountryC.Location = new System.Drawing.Point(96, 69);
            this.lbPrevCountryC.Name = "lbPrevCountryC";
            this.lbPrevCountryC.Size = new System.Drawing.Size(43, 17);
            this.lbPrevCountryC.TabIndex = 20;
            this.lbPrevCountryC.Text = "-------";
            // 
            // lbPrevNr1C
            // 
            this.lbPrevNr1C.AutoSize = true;
            this.lbPrevNr1C.Location = new System.Drawing.Point(96, 27);
            this.lbPrevNr1C.Name = "lbPrevNr1C";
            this.lbPrevNr1C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevNr1C.TabIndex = 21;
            this.lbPrevNr1C.Text = "-------";
            // 
            // lbPrevNr2C
            // 
            this.lbPrevNr2C.AutoSize = true;
            this.lbPrevNr2C.Location = new System.Drawing.Point(96, 46);
            this.lbPrevNr2C.Name = "lbPrevNr2C";
            this.lbPrevNr2C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevNr2C.TabIndex = 22;
            this.lbPrevNr2C.Text = "-------";
            // 
            // lbPrevNr3C
            // 
            this.lbPrevNr3C.AutoSize = true;
            this.lbPrevNr3C.Location = new System.Drawing.Point(96, 63);
            this.lbPrevNr3C.Name = "lbPrevNr3C";
            this.lbPrevNr3C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevNr3C.TabIndex = 23;
            this.lbPrevNr3C.Text = "-------";
            // 
            // lbPrevNr4C
            // 
            this.lbPrevNr4C.AutoSize = true;
            this.lbPrevNr4C.Location = new System.Drawing.Point(96, 84);
            this.lbPrevNr4C.Name = "lbPrevNr4C";
            this.lbPrevNr4C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevNr4C.TabIndex = 24;
            this.lbPrevNr4C.Text = "-------";
            // 
            // lbPrevMail1C
            // 
            this.lbPrevMail1C.AutoSize = true;
            this.lbPrevMail1C.Location = new System.Drawing.Point(96, 27);
            this.lbPrevMail1C.Name = "lbPrevMail1C";
            this.lbPrevMail1C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevMail1C.TabIndex = 25;
            this.lbPrevMail1C.Text = "-------";
            // 
            // lbPrevMail2C
            // 
            this.lbPrevMail2C.AutoSize = true;
            this.lbPrevMail2C.Location = new System.Drawing.Point(96, 48);
            this.lbPrevMail2C.Name = "lbPrevMail2C";
            this.lbPrevMail2C.Size = new System.Drawing.Size(43, 17);
            this.lbPrevMail2C.TabIndex = 26;
            this.lbPrevMail2C.Text = "-------";
            // 
            // pbPrev
            // 
            this.pbPrev.Location = new System.Drawing.Point(318, 44);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(100, 122);
            this.pbPrev.TabIndex = 17;
            this.pbPrev.TabStop = false;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(439, 622);
            this.ControlBox = false;
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.lbPvBirthC);
            this.Controls.Add(this.lbPvGenderC);
            this.Controls.Add(this.lbPvTitleC);
            this.Controls.Add(this.lbPvNickC);
            this.Controls.Add(this.lbPvFNameC);
            this.Controls.Add(this.lbPvNameC);
            this.Controls.Add(this.gpBMail);
            this.Controls.Add(this.gpBNumb);
            this.Controls.Add(this.grBAdress);
            this.Controls.Add(this.lbPvGender);
            this.Controls.Add(this.lbPvBirth);
            this.Controls.Add(this.lbPvTitle);
            this.Controls.Add(this.lbPvNick);
            this.Controls.Add(this.lbPvFName);
            this.Controls.Add(this.lbPvName);
            this.Name = "frmPreview";
            this.Text = "Vorschau";
            this.toolTip1.SetToolTip(this, "Zum beenden Doppelklicken");
            this.DoubleClick += new System.EventHandler(this.frmPreview_DoubleClick);
            this.grBAdress.ResumeLayout(false);
            this.grBAdress.PerformLayout();
            this.gpBNumb.ResumeLayout(false);
            this.gpBNumb.PerformLayout();
            this.gpBMail.ResumeLayout(false);
            this.gpBMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPvName;
        private System.Windows.Forms.Label lbPvFName;
        private System.Windows.Forms.Label lbPvNick;
        private System.Windows.Forms.Label lbPvTitle;
        private System.Windows.Forms.Label lbPvBirth;
        private System.Windows.Forms.Label lbPvGender;
        private System.Windows.Forms.GroupBox grBAdress;
        private System.Windows.Forms.Label lbPrevStreet;
        private System.Windows.Forms.Label lbPrevCountry;
        private System.Windows.Forms.Label lbPrevTown;
        private System.Windows.Forms.Label lbPrevPLZ;
        private System.Windows.Forms.GroupBox gpBNumb;
        private System.Windows.Forms.Label lbPrevNr3;
        private System.Windows.Forms.Label lbPrevNr4;
        private System.Windows.Forms.Label lbPrevNr2;
        private System.Windows.Forms.Label lbPrevNr1;
        private System.Windows.Forms.GroupBox gpBMail;
        private System.Windows.Forms.Label lbPrevMail2;
        private System.Windows.Forms.Label lbPrevMail1;
        private System.Windows.Forms.Label lbPrevTownC;
        private System.Windows.Forms.Label lbPrevStreetC;
        private System.Windows.Forms.Label lbPrevPLZC;
        private System.Windows.Forms.Label lbPrevCountryC;
        private System.Windows.Forms.Label lbPrevNr1C;
        private System.Windows.Forms.Label lbPrevNr2C;
        private System.Windows.Forms.Label lbPrevNr3C;
        private System.Windows.Forms.Label lbPrevNr4C;
        private System.Windows.Forms.Label lbPrevMail1C;
        private System.Windows.Forms.Label lbPrevMail2C;
        private System.Windows.Forms.Label lbPvNameC;
        private System.Windows.Forms.Label lbPvFNameC;
        private System.Windows.Forms.Label lbPvNickC;
        private System.Windows.Forms.Label lbPvTitleC;
        private System.Windows.Forms.Label lbPvGenderC;
        private System.Windows.Forms.Label lbPvBirthC;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}