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
            this.btOpen = new System.Windows.Forms.Button();
            this.btPreview = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ilbuttons = new System.Windows.Forms.ImageList(this.components);
            this.ttButtons = new System.Windows.Forms.ToolTip(this.components);
            this.tabContactInfo = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabNumbers = new System.Windows.Forms.TabPage();
            this.tabAdress = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.tabContactInfo.SuspendLayout();
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
            // ilbuttons
            // 
            this.ilbuttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilbuttons.ImageStream")));
            this.ilbuttons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilbuttons.Images.SetKeyName(0, "1446763737_add-80px.png");
            this.ilbuttons.Images.SetKeyName(1, "1446763763_eye_preview_see_seen_view.png");
            this.ilbuttons.Images.SetKeyName(2, "1446763779_Download_save_down.png");
            this.ilbuttons.Images.SetKeyName(3, "1446763800_opened_folder.png");
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
            this.tabContactInfo.Size = new System.Drawing.Size(851, 474);
            this.tabContactInfo.TabIndex = 4;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.DarkRed;
            this.tabGeneral.Location = new System.Drawing.Point(4, 34);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(843, 436);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 567);
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

    }
}

