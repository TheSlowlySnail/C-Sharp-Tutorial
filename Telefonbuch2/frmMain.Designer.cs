namespace Telefonbuch2
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btNew = new System.Windows.Forms.Button();
            this.ilbuttons = new System.Windows.Forms.ImageList(this.components);
            this.btOpen = new System.Windows.Forms.Button();
            this.btPreview = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ttButtons = new System.Windows.Forms.ToolTip(this.components);
            this.tabContactInfo = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabNumbers = new System.Windows.Forms.TabPage();
            this.tabAdress = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbVname = new System.Windows.Forms.Label();
            this.tbVname = new System.Windows.Forms.TextBox();
            this.lbNickname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbShowAs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobShowAs = new System.Windows.Forms.ComboBox();
            this.picbContact = new System.Windows.Forms.PictureBox();
            this.lbPic = new System.Windows.Forms.Label();
            this.btPic = new System.Windows.Forms.Button();
            this.tabContactInfo.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbShowAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.ImageIndex = 0;
            this.btNew.ImageList = this.ilbuttons;
            this.btNew.Location = new System.Drawing.Point(12, 12);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(43, 40);
            this.btNew.TabIndex = 0;
            this.ttButtons.SetToolTip(this.btNew, "Neuer Kontakt");
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // ilbuttons
            // 
            this.ilbuttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilbuttons.ImageStream")));
            this.ilbuttons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilbuttons.Images.SetKeyName(0, "1446763737_add-80px.png");
            this.ilbuttons.Images.SetKeyName(1, "1446763763_eye_preview_see_seen_view.png");
            this.ilbuttons.Images.SetKeyName(2, "1446763779_Download_save_down.png");
            this.ilbuttons.Images.SetKeyName(3, "1446763800_opened_folder.png");
            // 
            // btOpen
            // 
            this.btOpen.ImageIndex = 3;
            this.btOpen.ImageList = this.ilbuttons;
            this.btOpen.Location = new System.Drawing.Point(61, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(43, 40);
            this.btOpen.TabIndex = 1;
            this.btOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttButtons.SetToolTip(this.btOpen, "Öffnen");
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btPreview
            // 
            this.btPreview.ImageIndex = 1;
            this.btPreview.ImageList = this.ilbuttons;
            this.btPreview.Location = new System.Drawing.Point(110, 12);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(43, 40);
            this.btPreview.TabIndex = 2;
            this.ttButtons.SetToolTip(this.btPreview, "Vorschau");
            this.btPreview.UseVisualStyleBackColor = true;
            this.btPreview.Click += new System.EventHandler(this.btPreview_Click);
            // 
            // btSave
            // 
            this.btSave.ImageIndex = 2;
            this.btSave.ImageList = this.ilbuttons;
            this.btSave.Location = new System.Drawing.Point(159, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(43, 40);
            this.btSave.TabIndex = 3;
            this.ttButtons.SetToolTip(this.btSave, "Speichern");
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ttButtons
            // 
            this.ttButtons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttButtons.ToolTipTitle = "Information";
            this.ttButtons.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tabContactInfo
            // 
            this.tabContactInfo.Controls.Add(this.tabGeneral);
            this.tabContactInfo.Controls.Add(this.tabNumbers);
            this.tabContactInfo.Controls.Add(this.tabAdress);
            this.tabContactInfo.Controls.Add(this.tabOther);
            this.tabContactInfo.Location = new System.Drawing.Point(12, 58);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.SelectedIndex = 0;
            this.tabContactInfo.Size = new System.Drawing.Size(851, 760);
            this.tabContactInfo.TabIndex = 4;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.DarkRed;
            this.tabGeneral.Controls.Add(this.btPic);
            this.tabGeneral.Controls.Add(this.lbPic);
            this.tabGeneral.Controls.Add(this.picbContact);
            this.tabGeneral.Controls.Add(this.gbShowAs);
            this.tabGeneral.Controls.Add(this.gbGender);
            this.tabGeneral.Controls.Add(this.tbTitle);
            this.tabGeneral.Controls.Add(this.tbNickname);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.lbNickname);
            this.tabGeneral.Controls.Add(this.tbVname);
            this.tabGeneral.Controls.Add(this.lbVname);
            this.tabGeneral.Controls.Add(this.tbName);
            this.tabGeneral.Controls.Add(this.lbName);
            this.tabGeneral.Location = new System.Drawing.Point(4, 34);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(843, 722);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Allgemeines";
            // 
            // tabNumbers
            // 
            this.tabNumbers.BackColor = System.Drawing.Color.LightCoral;
            this.tabNumbers.Location = new System.Drawing.Point(4, 34);
            this.tabNumbers.Name = "tabNumbers";
            this.tabNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.tabNumbers.Size = new System.Drawing.Size(843, 436);
            this.tabNumbers.TabIndex = 1;
            this.tabNumbers.Text = "Telefonnummern";
            // 
            // tabAdress
            // 
            this.tabAdress.Location = new System.Drawing.Point(4, 34);
            this.tabAdress.Name = "tabAdress";
            this.tabAdress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdress.Size = new System.Drawing.Size(843, 436);
            this.tabAdress.TabIndex = 2;
            this.tabAdress.Text = "Adresse";
            this.tabAdress.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            this.tabOther.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabOther.Location = new System.Drawing.Point(4, 34);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(843, 436);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Sonstiges";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(18, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 32);
            this.tbName.TabIndex = 1;
            // 
            // lbVname
            // 
            this.lbVname.AutoSize = true;
            this.lbVname.Location = new System.Drawing.Point(18, 54);
            this.lbVname.Name = "lbVname";
            this.lbVname.Size = new System.Drawing.Size(112, 25);
            this.lbVname.TabIndex = 2;
            this.lbVname.Text = "Vorname";
            // 
            // tbVname
            // 
            this.tbVname.Location = new System.Drawing.Point(183, 54);
            this.tbVname.Name = "tbVname";
            this.tbVname.Size = new System.Drawing.Size(288, 32);
            this.tbVname.TabIndex = 3;
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(18, 100);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(129, 25);
            this.lbNickname.TabIndex = 4;
            this.lbNickname.Text = "Spitzname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tetel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(183, 100);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(288, 32);
            this.tbNickname.TabIndex = 6;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(183, 146);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(288, 32);
            this.tbTitle.TabIndex = 7;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(17, 264);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(454, 100);
            this.gbGender.TabIndex = 8;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Geschlecht";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(6, 46);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(135, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "männlich";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(225, 46);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(127, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "weiblich";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbShowAs
            // 
            this.gbShowAs.Controls.Add(this.combobShowAs);
            this.gbShowAs.Controls.Add(this.label1);
            this.gbShowAs.Location = new System.Drawing.Point(17, 408);
            this.gbShowAs.Name = "gbShowAs";
            this.gbShowAs.Size = new System.Drawing.Size(454, 120);
            this.gbShowAs.TabIndex = 9;
            this.gbShowAs.TabStop = false;
            this.gbShowAs.Text = "Anzeigen als";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beispiel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combobShowAs
            // 
            this.combobShowAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobShowAs.FormattingEnabled = true;
            this.combobShowAs.Items.AddRange(new object[] {
            "Name, Vorname",
            "Vorname, Name",
            "Name, Vorname (Spitzname)",
            "Titel Vorname Name"});
            this.combobShowAs.Location = new System.Drawing.Point(6, 31);
            this.combobShowAs.Name = "combobShowAs";
            this.combobShowAs.Size = new System.Drawing.Size(442, 33);
            this.combobShowAs.TabIndex = 1;
            // 
            // picbContact
            // 
            this.picbContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbContact.Location = new System.Drawing.Point(616, 8);
            this.picbContact.Name = "picbContact";
            this.picbContact.Size = new System.Drawing.Size(186, 253);
            this.picbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbContact.TabIndex = 10;
            this.picbContact.TabStop = false;
            // 
            // lbPic
            // 
            this.lbPic.AutoSize = true;
            this.lbPic.Location = new System.Drawing.Point(616, 264);
            this.lbPic.Name = "lbPic";
            this.lbPic.Size = new System.Drawing.Size(63, 25);
            this.lbPic.TabIndex = 11;
            this.lbPic.Text = "Bild:";
            // 
            // btPic
            // 
            this.btPic.Location = new System.Drawing.Point(754, 267);
            this.btPic.Name = "btPic";
            this.btPic.Size = new System.Drawing.Size(47, 40);
            this.btPic.TabIndex = 12;
            this.btPic.Text = "...";
            this.ttButtons.SetToolTip(this.btPic, "Bild laden");
            this.btPic.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 830);
            this.Controls.Add(this.tabContactInfo);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btNew);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefonbuch";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabContactInfo.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbShowAs.ResumeLayout(false);
            this.gbShowAs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btPreview;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ImageList ilbuttons;
        private System.Windows.Forms.ToolTip ttButtons;
        private System.Windows.Forms.TabControl tabContactInfo;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabNumbers;
        private System.Windows.Forms.TabPage tabAdress;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.TextBox tbVname;
        private System.Windows.Forms.Label lbVname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbShowAs;
        private System.Windows.Forms.ComboBox combobShowAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbContact;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.Label lbPic;

    }
}

