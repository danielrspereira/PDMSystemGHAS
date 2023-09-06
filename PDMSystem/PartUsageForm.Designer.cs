namespace PDMSystem
{
    partial class PartUsageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartUsageForm));
            this.dgvPartUsage = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMetaDataUsage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartUsage
            // 
            this.dgvPartUsage.AllowUserToAddRows = false;
            this.dgvPartUsage.AllowUserToDeleteRows = false;
            this.dgvPartUsage.AllowUserToOrderColumns = true;
            this.dgvPartUsage.AllowUserToResizeRows = false;
            this.dgvPartUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPartUsage.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPartUsage.Location = new System.Drawing.Point(12, 12);
            this.dgvPartUsage.Name = "dgvPartUsage";
            this.dgvPartUsage.RowHeadersVisible = false;
            this.dgvPartUsage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPartUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartUsage.Size = new System.Drawing.Size(604, 300);
            this.dgvPartUsage.TabIndex = 0;
            this.dgvPartUsage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartUsage_CellContentClick);
            this.dgvPartUsage.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPartUsage_CellFormatting);
            this.dgvPartUsage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartUsage_CellMouseClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(145, 335);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMetaDataUsage
            // 
            this.btnMetaDataUsage.Location = new System.Drawing.Point(337, 335);
            this.btnMetaDataUsage.Name = "btnMetaDataUsage";
            this.btnMetaDataUsage.Size = new System.Drawing.Size(150, 23);
            this.btnMetaDataUsage.TabIndex = 3;
            this.btnMetaDataUsage.Text = "Open document mask";
            this.btnMetaDataUsage.UseVisualStyleBackColor = true;
            this.btnMetaDataUsage.Click += new System.EventHandler(this.btnMetaDataUsage_Click);
            // 
            // PartUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 370);
            this.Controls.Add(this.btnMetaDataUsage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvPartUsage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartUsageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartUsageForm";
            this.Load += new System.EventHandler(this.PartUsageForm_Load);
            this.Resize += new System.EventHandler(this.PartUsageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartUsage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartUsage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMetaDataUsage;
    }
}