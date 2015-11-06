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
            this.btPic = new System.Windows.Forms.Button();
            this.tabContactInfo = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBBirthday = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbPic = new System.Windows.Forms.Label();
            this.picbContact = new System.Windows.Forms.PictureBox();
            this.gbShowAs = new System.Windows.Forms.GroupBox();
            this.combobShowAs = new System.Windows.Forms.ComboBox();
            this.lbExample = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.tbVname = new System.Windows.Forms.TextBox();
            this.lbVname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tabNumbers = new System.Windows.Forms.TabPage();
            this.maskBCC4 = new System.Windows.Forms.MaskedTextBox();
            this.maskBCC3 = new System.Windows.Forms.MaskedTextBox();
            this.maskBCC2 = new System.Windows.Forms.MaskedTextBox();
            this.maskBCC1 = new System.Windows.Forms.MaskedTextBox();
            this.combobNr4 = new System.Windows.Forms.ComboBox();
            this.combobNr3 = new System.Windows.Forms.ComboBox();
            this.combobNr2 = new System.Windows.Forms.ComboBox();
            this.combobNr1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSlash = new System.Windows.Forms.Label();
            this.tbNr4 = new System.Windows.Forms.TextBox();
            this.tbNr2 = new System.Windows.Forms.TextBox();
            this.tbNr3 = new System.Windows.Forms.TextBox();
            this.tbNr1 = new System.Windows.Forms.TextBox();
            this.tbNbrVw4 = new System.Windows.Forms.TextBox();
            this.tbNbrVw2 = new System.Windows.Forms.TextBox();
            this.tbNbrVw3 = new System.Windows.Forms.TextBox();
            this.tbNbrVw1 = new System.Windows.Forms.TextBox();
            this.lbNbr4 = new System.Windows.Forms.Label();
            this.lbNbr3 = new System.Windows.Forms.Label();
            this.lbNbr2 = new System.Windows.Forms.Label();
            this.lbNbr1 = new System.Windows.Forms.Label();
            this.tabAdress = new System.Windows.Forms.TabPage();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbHNr = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbZIP = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lbHNr = new System.Windows.Forms.Label();
            this.lbTown = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbZip = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.lbOther = new System.Windows.Forms.Label();
            this.rtbOther = new System.Windows.Forms.RichTextBox();
            this.groubBMail = new System.Windows.Forms.GroupBox();
            this.comboBMail2 = new System.Windows.Forms.ComboBox();
            this.comboBMail1 = new System.Windows.Forms.ComboBox();
            this.tbMail2 = new System.Windows.Forms.TextBox();
            this.tbMail1 = new System.Windows.Forms.TextBox();
            this.lbMail2 = new System.Windows.Forms.Label();
            this.lbMail1 = new System.Windows.Forms.Label();
            this.lbChoice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ausw = new System.Windows.Forms.Label();
            this.tabContactInfo.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbContact)).BeginInit();
            this.gbShowAs.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.tabNumbers.SuspendLayout();
            this.tabAdress.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.groubBMail.SuspendLayout();
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
            this.btPreview.Visible = false;
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
            this.btSave.Visible = false;
            // 
            // ttButtons
            // 
            this.ttButtons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttButtons.ToolTipTitle = "Information";
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
            this.btPic.Click += new System.EventHandler(this.btPic_Click);
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
            this.tabContactInfo.Visible = false;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.DarkRed;
            this.tabGeneral.Controls.Add(this.groupBBirthday);
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
            // groupBBirthday
            // 
            this.groupBBirthday.Controls.Add(this.dateTimePicker1);
            this.groupBBirthday.Location = new System.Drawing.Point(571, 340);
            this.groupBBirthday.Name = "groupBBirthday";
            this.groupBBirthday.Size = new System.Drawing.Size(200, 100);
            this.groupBBirthday.TabIndex = 13;
            this.groupBBirthday.TabStop = false;
            this.groupBBirthday.Text = "Geburtstag";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 31);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 32);
            this.dateTimePicker1.TabIndex = 0;
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
            // gbShowAs
            // 
            this.gbShowAs.Controls.Add(this.combobShowAs);
            this.gbShowAs.Controls.Add(this.lbExample);
            this.gbShowAs.Location = new System.Drawing.Point(17, 408);
            this.gbShowAs.Name = "gbShowAs";
            this.gbShowAs.Size = new System.Drawing.Size(454, 120);
            this.gbShowAs.TabIndex = 9;
            this.gbShowAs.TabStop = false;
            this.gbShowAs.Text = "Anzeigen als";
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
            this.combobShowAs.SelectedIndexChanged += new System.EventHandler(this.combobShowAs_SelectedIndexChanged);
            // 
            // lbExample
            // 
            this.lbExample.AutoSize = true;
            this.lbExample.Location = new System.Drawing.Point(1, 92);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(100, 25);
            this.lbExample.TabIndex = 0;
            this.lbExample.Text = "Beispiel";
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
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(183, 146);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(288, 32);
            this.tbTitle.TabIndex = 7;
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(183, 100);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(288, 32);
            this.tbNickname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tetel";
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
            // tbVname
            // 
            this.tbVname.Location = new System.Drawing.Point(183, 54);
            this.tbVname.Name = "tbVname";
            this.tbVname.Size = new System.Drawing.Size(288, 32);
            this.tbVname.TabIndex = 3;
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 32);
            this.tbName.TabIndex = 1;
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
            // tabNumbers
            // 
            this.tabNumbers.BackColor = System.Drawing.Color.LightCoral;
            this.tabNumbers.Controls.Add(this.ausw);
            this.tabNumbers.Controls.Add(this.button4);
            this.tabNumbers.Controls.Add(this.button3);
            this.tabNumbers.Controls.Add(this.button2);
            this.tabNumbers.Controls.Add(this.button1);
            this.tabNumbers.Controls.Add(this.maskBCC4);
            this.tabNumbers.Controls.Add(this.maskBCC3);
            this.tabNumbers.Controls.Add(this.maskBCC2);
            this.tabNumbers.Controls.Add(this.maskBCC1);
            this.tabNumbers.Controls.Add(this.combobNr4);
            this.tabNumbers.Controls.Add(this.combobNr3);
            this.tabNumbers.Controls.Add(this.combobNr2);
            this.tabNumbers.Controls.Add(this.combobNr1);
            this.tabNumbers.Controls.Add(this.label5);
            this.tabNumbers.Controls.Add(this.label4);
            this.tabNumbers.Controls.Add(this.label3);
            this.tabNumbers.Controls.Add(this.lbSlash);
            this.tabNumbers.Controls.Add(this.tbNr4);
            this.tabNumbers.Controls.Add(this.tbNr2);
            this.tabNumbers.Controls.Add(this.tbNr3);
            this.tabNumbers.Controls.Add(this.tbNr1);
            this.tabNumbers.Controls.Add(this.tbNbrVw4);
            this.tabNumbers.Controls.Add(this.tbNbrVw2);
            this.tabNumbers.Controls.Add(this.tbNbrVw3);
            this.tabNumbers.Controls.Add(this.tbNbrVw1);
            this.tabNumbers.Controls.Add(this.lbNbr4);
            this.tabNumbers.Controls.Add(this.lbNbr3);
            this.tabNumbers.Controls.Add(this.lbNbr2);
            this.tabNumbers.Controls.Add(this.lbNbr1);
            this.tabNumbers.Location = new System.Drawing.Point(4, 34);
            this.tabNumbers.Name = "tabNumbers";
            this.tabNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.tabNumbers.Size = new System.Drawing.Size(843, 722);
            this.tabNumbers.TabIndex = 1;
            this.tabNumbers.Text = "Telefonnummern";
            // 
            // maskBCC4
            // 
            this.maskBCC4.Location = new System.Drawing.Point(103, 276);
            this.maskBCC4.Mask = "+00";
            this.maskBCC4.Name = "maskBCC4";
            this.maskBCC4.Size = new System.Drawing.Size(56, 32);
            this.maskBCC4.TabIndex = 23;
            this.maskBCC4.Text = "49";
            // 
            // maskBCC3
            // 
            this.maskBCC3.Location = new System.Drawing.Point(103, 206);
            this.maskBCC3.Mask = "+00";
            this.maskBCC3.Name = "maskBCC3";
            this.maskBCC3.Size = new System.Drawing.Size(56, 32);
            this.maskBCC3.TabIndex = 22;
            this.maskBCC3.Text = "49";
            // 
            // maskBCC2
            // 
            this.maskBCC2.Location = new System.Drawing.Point(103, 129);
            this.maskBCC2.Mask = "+00";
            this.maskBCC2.Name = "maskBCC2";
            this.maskBCC2.Size = new System.Drawing.Size(56, 32);
            this.maskBCC2.TabIndex = 21;
            this.maskBCC2.Text = "49";
            // 
            // maskBCC1
            // 
            this.maskBCC1.Location = new System.Drawing.Point(103, 66);
            this.maskBCC1.Mask = "+00";
            this.maskBCC1.Name = "maskBCC1";
            this.maskBCC1.Size = new System.Drawing.Size(56, 32);
            this.maskBCC1.TabIndex = 20;
            this.maskBCC1.Text = "49";
            // 
            // combobNr4
            // 
            this.combobNr4.FormattingEnabled = true;
            this.combobNr4.Items.AddRange(new object[] {
            "Handy",
            "Privat",
            "Geschäftlich"});
            this.combobNr4.Location = new System.Drawing.Point(667, 268);
            this.combobNr4.Name = "combobNr4";
            this.combobNr4.Size = new System.Drawing.Size(121, 33);
            this.combobNr4.TabIndex = 19;
            this.combobNr4.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // combobNr3
            // 
            this.combobNr3.FormattingEnabled = true;
            this.combobNr3.Items.AddRange(new object[] {
            "Handy",
            "Privat",
            "Geschäftlich"});
            this.combobNr3.Location = new System.Drawing.Point(667, 205);
            this.combobNr3.Name = "combobNr3";
            this.combobNr3.Size = new System.Drawing.Size(121, 33);
            this.combobNr3.TabIndex = 18;
            this.combobNr3.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // combobNr2
            // 
            this.combobNr2.FormattingEnabled = true;
            this.combobNr2.Items.AddRange(new object[] {
            "Handy",
            "Privat",
            "Geschäftlich"});
            this.combobNr2.Location = new System.Drawing.Point(667, 132);
            this.combobNr2.Name = "combobNr2";
            this.combobNr2.Size = new System.Drawing.Size(121, 33);
            this.combobNr2.TabIndex = 17;
            this.combobNr2.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // combobNr1
            // 
            this.combobNr1.FormattingEnabled = true;
            this.combobNr1.Items.AddRange(new object[] {
            "Handy",
            "Privat",
            "Geschäftlich"});
            this.combobNr1.Location = new System.Drawing.Point(667, 69);
            this.combobNr1.Name = "combobNr1";
            this.combobNr1.Size = new System.Drawing.Size(121, 33);
            this.combobNr1.TabIndex = 16;
            this.combobNr1.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "/";
            // 
            // lbSlash
            // 
            this.lbSlash.AutoSize = true;
            this.lbSlash.Location = new System.Drawing.Point(300, 69);
            this.lbSlash.Name = "lbSlash";
            this.lbSlash.Size = new System.Drawing.Size(26, 25);
            this.lbSlash.TabIndex = 12;
            this.lbSlash.Text = "/";
            // 
            // tbNr4
            // 
            this.tbNr4.Location = new System.Drawing.Point(386, 273);
            this.tbNr4.Name = "tbNr4";
            this.tbNr4.Size = new System.Drawing.Size(211, 32);
            this.tbNr4.TabIndex = 11;
            // 
            // tbNr2
            // 
            this.tbNr2.Location = new System.Drawing.Point(386, 133);
            this.tbNr2.Name = "tbNr2";
            this.tbNr2.Size = new System.Drawing.Size(211, 32);
            this.tbNr2.TabIndex = 10;
            // 
            // tbNr3
            // 
            this.tbNr3.Location = new System.Drawing.Point(386, 203);
            this.tbNr3.Name = "tbNr3";
            this.tbNr3.Size = new System.Drawing.Size(211, 32);
            this.tbNr3.TabIndex = 9;
            // 
            // tbNr1
            // 
            this.tbNr1.Location = new System.Drawing.Point(386, 63);
            this.tbNr1.Name = "tbNr1";
            this.tbNr1.Size = new System.Drawing.Size(211, 32);
            this.tbNr1.TabIndex = 8;
            // 
            // tbNbrVw4
            // 
            this.tbNbrVw4.Location = new System.Drawing.Point(176, 276);
            this.tbNbrVw4.Name = "tbNbrVw4";
            this.tbNbrVw4.Size = new System.Drawing.Size(100, 32);
            this.tbNbrVw4.TabIndex = 7;
            // 
            // tbNbrVw2
            // 
            this.tbNbrVw2.Location = new System.Drawing.Point(176, 136);
            this.tbNbrVw2.Name = "tbNbrVw2";
            this.tbNbrVw2.Size = new System.Drawing.Size(100, 32);
            this.tbNbrVw2.TabIndex = 6;
            // 
            // tbNbrVw3
            // 
            this.tbNbrVw3.Location = new System.Drawing.Point(176, 206);
            this.tbNbrVw3.Name = "tbNbrVw3";
            this.tbNbrVw3.Size = new System.Drawing.Size(100, 32);
            this.tbNbrVw3.TabIndex = 5;
            // 
            // tbNbrVw1
            // 
            this.tbNbrVw1.Location = new System.Drawing.Point(176, 66);
            this.tbNbrVw1.Name = "tbNbrVw1";
            this.tbNbrVw1.Size = new System.Drawing.Size(100, 32);
            this.tbNbrVw1.TabIndex = 4;
            // 
            // lbNbr4
            // 
            this.lbNbr4.AutoSize = true;
            this.lbNbr4.Location = new System.Drawing.Point(20, 276);
            this.lbNbr4.Name = "lbNbr4";
            this.lbNbr4.Size = new System.Drawing.Size(43, 25);
            this.lbNbr4.TabIndex = 3;
            this.lbNbr4.Text = "#4";
            // 
            // lbNbr3
            // 
            this.lbNbr3.AutoSize = true;
            this.lbNbr3.Location = new System.Drawing.Point(20, 206);
            this.lbNbr3.Name = "lbNbr3";
            this.lbNbr3.Size = new System.Drawing.Size(43, 25);
            this.lbNbr3.TabIndex = 2;
            this.lbNbr3.Text = "#3";
            // 
            // lbNbr2
            // 
            this.lbNbr2.AutoSize = true;
            this.lbNbr2.Location = new System.Drawing.Point(20, 136);
            this.lbNbr2.Name = "lbNbr2";
            this.lbNbr2.Size = new System.Drawing.Size(43, 25);
            this.lbNbr2.TabIndex = 1;
            this.lbNbr2.Text = "#2";
            // 
            // lbNbr1
            // 
            this.lbNbr1.AutoSize = true;
            this.lbNbr1.Location = new System.Drawing.Point(20, 66);
            this.lbNbr1.Name = "lbNbr1";
            this.lbNbr1.Size = new System.Drawing.Size(43, 25);
            this.lbNbr1.TabIndex = 0;
            this.lbNbr1.Text = "#1";
            // 
            // tabAdress
            // 
            this.tabAdress.Controls.Add(this.tbTown);
            this.tabAdress.Controls.Add(this.tbHNr);
            this.tabAdress.Controls.Add(this.tbCountry);
            this.tabAdress.Controls.Add(this.tbZIP);
            this.tabAdress.Controls.Add(this.tbStreet);
            this.tabAdress.Controls.Add(this.lbHNr);
            this.tabAdress.Controls.Add(this.lbTown);
            this.tabAdress.Controls.Add(this.lbCountry);
            this.tabAdress.Controls.Add(this.lbZip);
            this.tabAdress.Controls.Add(this.lbStreet);
            this.tabAdress.Location = new System.Drawing.Point(4, 34);
            this.tabAdress.Name = "tabAdress";
            this.tabAdress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdress.Size = new System.Drawing.Size(843, 722);
            this.tabAdress.TabIndex = 2;
            this.tabAdress.Text = "Adresse";
            this.tabAdress.UseVisualStyleBackColor = true;
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(459, 116);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(212, 32);
            this.tbTown.TabIndex = 9;
            // 
            // tbHNr
            // 
            this.tbHNr.Location = new System.Drawing.Point(459, 63);
            this.tbHNr.Name = "tbHNr";
            this.tbHNr.Size = new System.Drawing.Size(212, 32);
            this.tbHNr.TabIndex = 8;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(123, 166);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(212, 32);
            this.tbCountry.TabIndex = 7;
            // 
            // tbZIP
            // 
            this.tbZIP.Location = new System.Drawing.Point(123, 116);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.Size = new System.Drawing.Size(212, 32);
            this.tbZIP.TabIndex = 6;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(123, 66);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(212, 32);
            this.tbStreet.TabIndex = 5;
            // 
            // lbHNr
            // 
            this.lbHNr.AutoSize = true;
            this.lbHNr.Location = new System.Drawing.Point(370, 66);
            this.lbHNr.Name = "lbHNr";
            this.lbHNr.Size = new System.Drawing.Size(39, 25);
            this.lbHNr.TabIndex = 4;
            this.lbHNr.Text = "Nr";
            // 
            // lbTown
            // 
            this.lbTown.AutoSize = true;
            this.lbTown.Location = new System.Drawing.Point(360, 116);
            this.lbTown.Name = "lbTown";
            this.lbTown.Size = new System.Drawing.Size(71, 25);
            this.lbTown.TabIndex = 3;
            this.lbTown.Text = "Stadt";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(20, 166);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(66, 25);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "Land";
            // 
            // lbZip
            // 
            this.lbZip.AutoSize = true;
            this.lbZip.Location = new System.Drawing.Point(20, 116);
            this.lbZip.Name = "lbZip";
            this.lbZip.Size = new System.Drawing.Size(54, 25);
            this.lbZip.TabIndex = 1;
            this.lbZip.Text = "PLZ";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(20, 66);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(85, 25);
            this.lbStreet.TabIndex = 0;
            this.lbStreet.Text = "Straße";
            // 
            // tabOther
            // 
            this.tabOther.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabOther.Controls.Add(this.lbOther);
            this.tabOther.Controls.Add(this.rtbOther);
            this.tabOther.Controls.Add(this.groubBMail);
            this.tabOther.Location = new System.Drawing.Point(4, 34);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(843, 722);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Sonstiges";
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Location = new System.Drawing.Point(15, 248);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(121, 25);
            this.lbOther.TabIndex = 6;
            this.lbOther.Text = "Sonstiges";
            // 
            // rtbOther
            // 
            this.rtbOther.Location = new System.Drawing.Point(20, 287);
            this.rtbOther.Name = "rtbOther";
            this.rtbOther.Size = new System.Drawing.Size(808, 252);
            this.rtbOther.TabIndex = 5;
            this.rtbOther.Text = "";
            // 
            // groubBMail
            // 
            this.groubBMail.Controls.Add(this.comboBMail2);
            this.groubBMail.Controls.Add(this.comboBMail1);
            this.groubBMail.Controls.Add(this.tbMail2);
            this.groubBMail.Controls.Add(this.tbMail1);
            this.groubBMail.Controls.Add(this.lbMail2);
            this.groubBMail.Controls.Add(this.lbMail1);
            this.groubBMail.Location = new System.Drawing.Point(20, 66);
            this.groubBMail.Name = "groubBMail";
            this.groubBMail.Size = new System.Drawing.Size(808, 169);
            this.groubBMail.TabIndex = 0;
            this.groubBMail.TabStop = false;
            this.groubBMail.Text = "E-Mail";
            // 
            // comboBMail2
            // 
            this.comboBMail2.FormattingEnabled = true;
            this.comboBMail2.Items.AddRange(new object[] {
            "Privat",
            "Geschäftlich",
            "Spam"});
            this.comboBMail2.Location = new System.Drawing.Point(635, 95);
            this.comboBMail2.Name = "comboBMail2";
            this.comboBMail2.Size = new System.Drawing.Size(121, 33);
            this.comboBMail2.TabIndex = 4;
            this.comboBMail2.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // comboBMail1
            // 
            this.comboBMail1.FormattingEnabled = true;
            this.comboBMail1.Items.AddRange(new object[] {
            "Privat",
            "Geschäftlich",
            "Spam"});
            this.comboBMail1.Location = new System.Drawing.Point(635, 32);
            this.comboBMail1.Name = "comboBMail1";
            this.comboBMail1.Size = new System.Drawing.Size(121, 33);
            this.comboBMail1.TabIndex = 3;
            this.comboBMail1.SelectedIndexChanged += new System.EventHandler(this.cBoxesChanged);
            // 
            // tbMail2
            // 
            this.tbMail2.Location = new System.Drawing.Point(164, 88);
            this.tbMail2.Name = "tbMail2";
            this.tbMail2.Size = new System.Drawing.Size(425, 32);
            this.tbMail2.TabIndex = 2;
            // 
            // tbMail1
            // 
            this.tbMail1.Location = new System.Drawing.Point(164, 33);
            this.tbMail1.Name = "tbMail1";
            this.tbMail1.Size = new System.Drawing.Size(425, 32);
            this.tbMail1.TabIndex = 1;
            // 
            // lbMail2
            // 
            this.lbMail2.AutoSize = true;
            this.lbMail2.Location = new System.Drawing.Point(20, 95);
            this.lbMail2.Name = "lbMail2";
            this.lbMail2.Size = new System.Drawing.Size(43, 25);
            this.lbMail2.TabIndex = 1;
            this.lbMail2.Text = "#2";
            // 
            // lbMail1
            // 
            this.lbMail1.AutoSize = true;
            this.lbMail1.Location = new System.Drawing.Point(20, 40);
            this.lbMail1.Name = "lbMail1";
            this.lbMail1.Size = new System.Drawing.Size(43, 25);
            this.lbMail1.TabIndex = 0;
            this.lbMail1.Text = "#1";
            // 
            // lbChoice
            // 
            this.lbChoice.AutoSize = true;
            this.lbChoice.Location = new System.Drawing.Point(604, 27);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(96, 25);
            this.lbChoice.TabIndex = 1;
            this.lbChoice.Text = "Wählen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 47);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(794, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 47);
            this.button4.TabIndex = 27;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ausw
            // 
            this.ausw.AutoSize = true;
            this.ausw.Location = new System.Drawing.Point(634, 355);
            this.ausw.Name = "ausw";
            this.ausw.Size = new System.Drawing.Size(80, 25);
            this.ausw.TabIndex = 28;
            this.ausw.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 672);
            this.Controls.Add(this.lbChoice);
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
            this.tabContactInfo.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.groupBBirthday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbContact)).EndInit();
            this.gbShowAs.ResumeLayout(false);
            this.gbShowAs.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.tabNumbers.ResumeLayout(false);
            this.tabNumbers.PerformLayout();
            this.tabAdress.ResumeLayout(false);
            this.tabAdress.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.groubBMail.ResumeLayout(false);
            this.groubBMail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.PictureBox picbContact;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.Label lbPic;
        private System.Windows.Forms.Label lbNbr1;
        private System.Windows.Forms.Label lbNbr4;
        private System.Windows.Forms.Label lbNbr3;
        private System.Windows.Forms.Label lbNbr2;
        private System.Windows.Forms.TextBox tbNbrVw4;
        private System.Windows.Forms.TextBox tbNbrVw2;
        private System.Windows.Forms.TextBox tbNbrVw3;
        private System.Windows.Forms.TextBox tbNbrVw1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSlash;
        private System.Windows.Forms.TextBox tbNr4;
        private System.Windows.Forms.TextBox tbNr2;
        private System.Windows.Forms.TextBox tbNr3;
        private System.Windows.Forms.TextBox tbNr1;
        private System.Windows.Forms.MaskedTextBox maskBCC1;
        private System.Windows.Forms.ComboBox combobNr4;
        private System.Windows.Forms.ComboBox combobNr3;
        private System.Windows.Forms.ComboBox combobNr2;
        private System.Windows.Forms.ComboBox combobNr1;
        private System.Windows.Forms.MaskedTextBox maskBCC4;
        private System.Windows.Forms.MaskedTextBox maskBCC3;
        private System.Windows.Forms.MaskedTextBox maskBCC2;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbHNr;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbZIP;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbHNr;
        private System.Windows.Forms.Label lbTown;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbZip;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.GroupBox groubBMail;
        private System.Windows.Forms.ComboBox comboBMail2;
        private System.Windows.Forms.ComboBox comboBMail1;
        private System.Windows.Forms.TextBox tbMail2;
        private System.Windows.Forms.TextBox tbMail1;
        private System.Windows.Forms.Label lbMail2;
        private System.Windows.Forms.Label lbMail1;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.RichTextBox rtbOther;
        private System.Windows.Forms.GroupBox groupBBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbChoice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ausw;

    }
}

