namespace PDMSystem
{
    partial class SearchResultView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultView));
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.btnSearchPartUsage = new System.Windows.Forms.Button();
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.btnDocData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(12, 12);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowHeadersVisible = false;
            this.dgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.Size = new System.Drawing.Size(783, 430);
            this.dgvSearchResult.TabIndex = 0;
            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellContentClick);
            this.dgvSearchResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSearchResult_CellFormatting);
            this.dgvSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSearchResult_MouseClick);
            // 
            // btnSearchPartUsage
            // 
            this.btnSearchPartUsage.Location = new System.Drawing.Point(607, 460);
            this.btnSearchPartUsage.Name = "btnSearchPartUsage";
            this.btnSearchPartUsage.Size = new System.Drawing.Size(132, 23);
            this.btnSearchPartUsage.TabIndex = 1;
            this.btnSearchPartUsage.Text = "Get part usage";
            this.btnSearchPartUsage.UseVisualStyleBackColor = true;
            this.btnSearchPartUsage.Click += new System.EventHandler(this.btnSearchPartUsage_Click);
            // 
            // btnSearchAgain
            // 
            this.btnSearchAgain.Location = new System.Drawing.Point(86, 460);
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.Size = new System.Drawing.Size(105, 23);
            this.btnSearchAgain.TabIndex = 2;
            this.btnSearchAgain.Text = "Search again";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // btnDocData
            // 
            this.btnDocData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDocData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDocData.Location = new System.Drawing.Point(320, 460);
            this.btnDocData.Name = "btnDocData";
            this.btnDocData.Size = new System.Drawing.Size(146, 23);
            this.btnDocData.TabIndex = 3;
            this.btnDocData.Text = "Show document data";
            this.btnDocData.UseVisualStyleBackColor = true;
            this.btnDocData.Click += new System.EventHandler(this.btnDocData_Click);
            // 
            // SearchResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 495);
            this.Controls.Add(this.btnDocData);
            this.Controls.Add(this.btnSearchAgain);
            this.Controls.Add(this.btnSearchPartUsage);
            this.Controls.Add(this.dgvSearchResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchResultView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Result";
            this.Load += new System.EventHandler(this.SearchResultView_Load);
            this.Resize += new System.EventHandler(this.SearchResultView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button btnSearchPartUsage;
        private System.Windows.Forms.Button btnSearchAgain;
        private System.Windows.Forms.Button btnDocData;
    }
}