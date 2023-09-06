namespace PDMSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDocNo = new System.Windows.Forms.Label();
            this.tbIdent = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnErpCode = new System.Windows.Forms.Label();
            this.tbErpCode = new System.Windows.Forms.TextBox();
            this.btnSearchDoc = new System.Windows.Forms.Button();
            this.cbOnlyCad = new System.Windows.Forms.CheckBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDocNo
            // 
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Location = new System.Drawing.Point(55, 99);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(97, 13);
            this.lblDocNo.TabIndex = 0;
            this.lblDocNo.Text = "Document number:";
            // 
            // tbIdent
            // 
            this.tbIdent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIdent.Location = new System.Drawing.Point(158, 96);
            this.tbIdent.Name = "tbIdent";
            this.tbIdent.Size = new System.Drawing.Size(100, 20);
            this.tbIdent.TabIndex = 1;
            this.tbIdent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdent_KeyDown);
            // 
            // lblLogo
            // 
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.Location = new System.Drawing.Point(7, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(404, 63);
            this.lblLogo.TabIndex = 10;
            // 
            // btnErpCode
            // 
            this.btnErpCode.AutoSize = true;
            this.btnErpCode.Location = new System.Drawing.Point(56, 138);
            this.btnErpCode.Name = "btnErpCode";
            this.btnErpCode.Size = new System.Drawing.Size(59, 13);
            this.btnErpCode.TabIndex = 11;
            this.btnErpCode.Text = "ERP code:";
            // 
            // tbErpCode
            // 
            this.tbErpCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbErpCode.Location = new System.Drawing.Point(158, 135);
            this.tbErpCode.Name = "tbErpCode";
            this.tbErpCode.Size = new System.Drawing.Size(100, 20);
            this.tbErpCode.TabIndex = 12;
            this.tbErpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbErpCode_KeyDown);
            // 
            // btnSearchDoc
            // 
            this.btnSearchDoc.Location = new System.Drawing.Point(292, 96);
            this.btnSearchDoc.Name = "btnSearchDoc";
            this.btnSearchDoc.Size = new System.Drawing.Size(75, 59);
            this.btnSearchDoc.TabIndex = 13;
            this.btnSearchDoc.Text = "Search document";
            this.btnSearchDoc.UseVisualStyleBackColor = true;
            this.btnSearchDoc.Click += new System.EventHandler(this.btnSearchDoc_Click);
            // 
            // cbOnlyCad
            // 
            this.cbOnlyCad.AutoSize = true;
            this.cbOnlyCad.Location = new System.Drawing.Point(58, 255);
            this.cbOnlyCad.Name = "cbOnlyCad";
            this.cbOnlyCad.Size = new System.Drawing.Size(127, 17);
            this.cbOnlyCad.TabIndex = 14;
            this.cbOnlyCad.Text = "Only CAD documents";
            this.cbOnlyCad.UseVisualStyleBackColor = true;
            this.cbOnlyCad.CheckedChanged += new System.EventHandler(this.cbOnlyCad_CheckedChanged);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(58, 175);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(74, 13);
            this.lblOrderNo.TabIndex = 15;
            this.lblOrderNo.Text = "Order number:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOrderNo.Location = new System.Drawing.Point(158, 172);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(100, 20);
            this.tbOrderNo.TabIndex = 16;
            this.tbOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOrderNo_KeyDown);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(58, 216);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position:";
            // 
            // tbPosition
            // 
            this.tbPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPosition.Location = new System.Drawing.Point(158, 213);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(100, 20);
            this.tbPosition.TabIndex = 18;
            this.tbPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPosition_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.cbOnlyCad);
            this.Controls.Add(this.btnSearchDoc);
            this.Controls.Add(this.tbErpCode);
            this.Controls.Add(this.btnErpCode);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.tbIdent);
            this.Controls.Add(this.lblDocNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export files from PDM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocNo;
        private System.Windows.Forms.TextBox tbIdent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label btnErpCode;
        private System.Windows.Forms.TextBox tbErpCode;
        private System.Windows.Forms.Button btnSearchDoc;
        private System.Windows.Forms.CheckBox cbOnlyCad;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbPosition;
    }
}

