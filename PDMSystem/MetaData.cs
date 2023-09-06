namespace PDMSystem
{
    public partial class MetaData : Form
    {
        public string Ident
        {
            get
            {
                return this.tbIdent.Text;
            }
            set
            {
                this.tbIdent.Text = value;
            }
        }
        public string ZIndex
        {
            get
            {
                return this.tbZIndex.Text;
            }
            set
            {
                this.tbZIndex.Text = value;
            }
        }
        public string StatusTxt
        {
            get
            {
                return this.tbStatusTxt.Text;
            }
            set
            {
                this.tbStatusTxt.Text = value;
            }
        }
        public string ZKategorie
        {
            get
            {
                return this.tbZKategorie.Text;
            }
            set
            {
                this.tbZKategorie.Text = value;
            }
        }
        public string ProjNr
        {
            get
            {
                return this.tbProjNr.Text;
            }
            set
            {
                this.tbProjNr.Text = value;
            }
        }
        public string GueBaanArtNr
        {
            get
            {
                return this.tbGueBaanArtNo.Text;
            }
            set
            {
                this.tbGueBaanArtNo.Text = value;
            }
        }
        public string OrderNo
        {
            get
            {
                return this.tbOrderNo.Text;
            }
            set
            {
                this.tbOrderNo.Text = value;
            }
        }
        public string PoNo
        {
            get
            {
                return this.tbPoNo.Text;
            }
            set
            {
                this.tbPoNo.Text = value;
            }
        }
        public string TeileNummer
        {
            get
            {
                return this.tbTeileNummer.Text;
            }
            set
            {
                this.tbTeileNummer.Text = value;
            }
        }
        public string Zeichner
        {
            get
            {
                return this.tbZeichner.Text;
            }
            set
            {
                this.tbZeichner.Text = value;
            }
        }
        public string AnlegeTag
        {
            get
            {
                return this.tbAnlegeTag.Text;
            }
            set
            {
                this.tbAnlegeTag.Text = value;
            }
        }
        public string Pruefer
        {
            get
            {
                return this.tbPruefer.Text;
            }
            set
            {
                this.tbPruefer.Text = value;
            }
        }
        public string PruefDatum
        {
            get
            {
                return this.tbPruefDatum.Text;
            }
            set
            {
                this.tbPruefDatum.Text = value;
            }
        }
        public string CdbStatusTxt
        {
            get
            {
                return this.tbItemStatus.Text;
            }
            set
            {
                this.tbItemStatus.Text = value;
            }
        }
        public string Benennung
        {
            get
            {
                return this.tbBenennung.Text;
            }
            set
            {
                this.tbBenennung.Text = value;
            }
        }
        public string Benennung2
        {
            get
            {
                return this.tbBenennung2.Text;
            }
            set
            {
                this.tbBenennung2.Text = value;
            }
        }
        public string EngBenennung
        {
            get
            {
                return this.tbEngBenennung.Text;
            }
            set
            {
                this.tbEngBenennung.Text = value;
            }
        }
        public string FraBenennung
        {
            get
            {
                return this.tbFraBenennung.Text;
            }
            set
            {
                this.tbFraBenennung.Text = value;
            }
        }
        public string PtBenennung
        {
            get
            {
                return this.tbPtBenennung.Text;
            }
            set
            {
                this.tbPtBenennung.Text = value;
            }
        }
        public string GueMaterial
        {
            get
            {
                return this.tbMaterial.Text;
            }
            set
            {
                this.tbMaterial.Text = value;
            }
        }
        public string GueGroesse
        {
            get
            {
                return this.tbGueGroesse.Text;
            }
            set
            {
                this.tbGueGroesse.Text = value;
            }
        }
        public string StGewicht
        {
            get
            {
                return this.tbStGewicht.Text;
            }
            set
            {
                this.tbStGewicht.Text = value;
            }
        }
        public string GueGewichtCad
        {
            get
            {
                return this.tbGueGewichtCad.Text;
            }
            set
            {
                this.tbGueGewichtCad.Text = value;
            }
        }

        public MetaData()
        {
            InitializeComponent();
        }
        private void btnExportFiles_Click(object sender, EventArgs e)
        {
            Extensions ext = new Extensions();
            ext.ShowDialog();
        }
        public string GetExtensions()
        {
            string extensions = String.Empty;
            //if (cbSEFiles.Checked)
            //    extensions = extensions + ",SolidEdge:asm,SolidEdge:draft,SolidEdge:par,SolidEdge:psm";
            //if (cbDWG.Checked)
            //    extensions = extensions + ",dwg";
            //if (cbDXF.Checked)
            //    extensions = extensions + ",dxf";
            //if (cbJT.Checked)
            //    extensions = extensions + ",jt";
            //if (cbPDF.Checked)
            //    extensions = extensions + ",acrobat";
            if (extensions != String.Empty)
                return extensions.Substring(1, extensions.Length-1);
            else
            {
                MessageBox.Show("Please select the file extension(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return String.Empty;
            }
        }
        public string CreateOutputFolder(string ident)
        {
            DateTime foo = DateTime.Now;
            string unixTimeStamp = ((DateTimeOffset)foo).ToUnixTimeSeconds().ToString();
            string outputFolder = "\\\\10.1.11.20\\global\\CAD_Angebot\\ExportFiles\\"+ident+"_"+unixTimeStamp+"\\";

            try
            {
                Directory.CreateDirectory(outputFolder);
                return outputFolder;
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
        private void btnPartUsage_Click(object sender, EventArgs e)
        {
            DBQueryPDM pdmDB = new DBQueryPDM();
            PartUsage[] pu = pdmDB.SearchPartUsage("LiveDB", tbTeileNummer.Text);
            if (pu != null)
            {
                if (pu.Length == 0)
                    MessageBox.Show("No part usage has been found for this document!", "No part usage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    PartUsageForm puf = new PartUsageForm();
                    puf.DataGridView.DataSource = pu;
                    for (int i = 0; i < puf.DataGridView.Columns.Count; i++)
                    {
                        //puf.DataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    puf.ShowDialog();
                }
            }
            else
                MessageBox.Show("No part usage has been found for this document!", "No part usage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
