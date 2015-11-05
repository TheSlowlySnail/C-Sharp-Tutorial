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
            this.lbVname = new System.Windows.Forms.Label();
            this.tbVname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNbr = new System.Windows.Forms.TextBox();
            this.lbNbr = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.rtbEntries = new System.Windows.Forms.RichTextBox();
            this.btOne = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVname
            // 
            this.lbVname.AutoSize = true;
            this.lbVname.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbVname.Location = new System.Drawing.Point(31, 44);
            this.lbVname.Name = "lbVname";
            this.lbVname.Size = new System.Drawing.Size(120, 25);
            this.lbVname.TabIndex = 0;
            this.lbVname.Text = "Vorname:";
            this.lbVname.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbVname
            // 
            this.tbVname.Location = new System.Drawing.Point(231, 44);
            this.tbVname.Name = "tbVname";
            this.tbVname.Size = new System.Drawing.Size(251, 32);
            this.tbVname.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(231, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 32);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(31, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // tbNbr
            // 
            this.tbNbr.Location = new System.Drawing.Point(231, 144);
            this.tbNbr.Name = "tbNbr";
            this.tbNbr.Size = new System.Drawing.Size(251, 32);
            this.tbNbr.TabIndex = 5;
            this.tbNbr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbNbr
            // 
            this.lbNbr.AutoSize = true;
            this.lbNbr.Location = new System.Drawing.Point(31, 144);
            this.lbNbr.Name = "lbNbr";
            this.lbNbr.Size = new System.Drawing.Size(196, 25);
            this.lbNbr.TabIndex = 4;
            this.lbNbr.Text = "Telefonnummer:";
            this.lbNbr.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(36, 221);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(115, 38);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(367, 221);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(115, 38);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "Löschen";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // rtbEntries
            // 
            this.rtbEntries.Location = new System.Drawing.Point(36, 280);
            this.rtbEntries.Name = "rtbEntries";
            this.rtbEntries.Size = new System.Drawing.Size(446, 103);
            this.rtbEntries.TabIndex = 8;
            this.rtbEntries.Text = "";
            // 
            // btOne
            // 
            this.btOne.Location = new System.Drawing.Point(167, 222);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(44, 37);
            this.btOne.TabIndex = 9;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = true;
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
            // 
            // btTwo
            // 
            this.btTwo.Location = new System.Drawing.Point(217, 221);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(44, 37);
            this.btTwo.TabIndex = 10;
            this.btTwo.Text = "2";
            this.btTwo.UseVisualStyleBackColor = true;
            this.btTwo.Click += new System.EventHandler(this.btTwo_Click);
            // 
            // btThree
            // 
            this.btThree.Location = new System.Drawing.Point(267, 220);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(44, 37);
            this.btThree.TabIndex = 11;
            this.btThree.Text = "3";
            this.btThree.UseVisualStyleBackColor = true;
            this.btThree.Click += new System.EventHandler(this.btThree_Click);
            // 
            // btFour
            // 
            this.btFour.Location = new System.Drawing.Point(317, 222);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(44, 37);
            this.btFour.TabIndex = 12;
            this.btFour.Text = "4";
            this.btFour.UseVisualStyleBackColor = true;
            this.btFour.Click += new System.EventHandler(this.btFour_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 395);
            this.Controls.Add(this.btFour);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.rtbEntries);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNbr);
            this.Controls.Add(this.lbNbr);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbVname);
            this.Controls.Add(this.lbVname);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefonbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVname;
        private System.Windows.Forms.TextBox tbVname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbNbr;
        private System.Windows.Forms.Label lbNbr;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.RichTextBox rtbEntries;
        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button btFour;
    }
}

