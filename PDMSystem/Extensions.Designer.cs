namespace PDMSystem
{
    partial class Extensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extensions));
            this.cbJT = new System.Windows.Forms.CheckBox();
            this.cbDWG = new System.Windows.Forms.CheckBox();
            this.cbDXF = new System.Windows.Forms.CheckBox();
            this.cbPDF = new System.Windows.Forms.CheckBox();
            this.cbSEFiles = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExportFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbJT
            // 
            this.cbJT.AutoSize = true;
            this.cbJT.Location = new System.Drawing.Point(74, 148);
            this.cbJT.Name = "cbJT";
            this.cbJT.Size = new System.Drawing.Size(38, 17);
            this.cbJT.TabIndex = 16;
            this.cbJT.Text = "JT";
            this.cbJT.UseVisualStyleBackColor = true;
            // 
            // cbDWG
            // 
            this.cbDWG.AutoSize = true;
            this.cbDWG.Location = new System.Drawing.Point(74, 124);
            this.cbDWG.Name = "cbDWG";
            this.cbDWG.Size = new System.Drawing.Size(53, 17);
            this.cbDWG.TabIndex = 15;
            this.cbDWG.Text = "DWG";
            this.cbDWG.UseVisualStyleBackColor = true;
            // 
            // cbDXF
            // 
            this.cbDXF.AutoSize = true;
            this.cbDXF.Location = new System.Drawing.Point(74, 100);
            this.cbDXF.Name = "cbDXF";
            this.cbDXF.Size = new System.Drawing.Size(47, 17);
            this.cbDXF.TabIndex = 14;
            this.cbDXF.Text = "DXF";
            this.cbDXF.UseVisualStyleBackColor = true;
            // 
            // cbPDF
            // 
            this.cbPDF.AutoSize = true;
            this.cbPDF.Location = new System.Drawing.Point(74, 76);
            this.cbPDF.Name = "cbPDF";
            this.cbPDF.Size = new System.Drawing.Size(47, 17);
            this.cbPDF.TabIndex = 13;
            this.cbPDF.Text = "PDF";
            this.cbPDF.UseVisualStyleBackColor = true;
            // 
            // cbSEFiles
            // 
            this.cbSEFiles.AutoSize = true;
            this.cbSEFiles.Location = new System.Drawing.Point(74, 53);
            this.cbSEFiles.Name = "cbSEFiles";
            this.cbSEFiles.Size = new System.Drawing.Size(98, 17);
            this.cbSEFiles.TabIndex = 12;
            this.cbSEFiles.Text = "Solid Edge files";
            this.cbSEFiles.UseVisualStyleBackColor = true;
            this.cbSEFiles.CheckedChanged += new System.EventHandler(this.cbSEFiles_CheckedChanged);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(74, 29);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(69, 17);
            this.cbAll.TabIndex = 11;
            this.cbAll.Text = "Select all";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(-273, 74);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(202, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnExportFinal
            // 
            this.btnExportFinal.Location = new System.Drawing.Point(74, 193);
            this.btnExportFinal.Name = "btnExportFinal";
            this.btnExportFinal.Size = new System.Drawing.Size(75, 23);
            this.btnExportFinal.TabIndex = 17;
            this.btnExportFinal.Text = "Export files";
            this.btnExportFinal.UseVisualStyleBackColor = true;
            this.btnExportFinal.Click += new System.EventHandler(this.btnExportFinal_Click);
            // 
            // Extensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 235);
            this.Controls.Add(this.btnExportFinal);
            this.Controls.Add(this.cbJT);
            this.Controls.Add(this.cbDWG);
            this.Controls.Add(this.cbDXF);
            this.Controls.Add(this.cbPDF);
            this.Controls.Add(this.cbSEFiles);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extensions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extensions";
            this.Load += new System.EventHandler(this.Extensions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbJT;
        private System.Windows.Forms.CheckBox cbDWG;
        private System.Windows.Forms.CheckBox cbDXF;
        private System.Windows.Forms.CheckBox cbPDF;
        private System.Windows.Forms.CheckBox cbSEFiles;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExportFinal;
    }
}