namespace PDMSystem
{
    public partial class SearchResultView : Form
    {
        string teilenummer = string.Empty;
        string ident = string.Empty;
        string zIndex = string.Empty;
        private Rectangle originalFormSize;
        private Rectangle originalBtnDocData;
        private Rectangle originalBtnSearchAgain;
        private Rectangle originalBtnSearchPartUsage;

        public SearchResultView()
        {
            InitializeComponent();
        }
        private void btnSearchPartUsage_Click(object sender, EventArgs e)
        {
            DBQueryPDM pdmDB = new DBQueryPDM();
            PartUsage[] pu = pdmDB.SearchPartUsage("LiveDB", teilenummer);
            if (pu != null)
            {
                if (pu.Length == 0)
                {
                    MessageBox.Show("No part usage has been found for this document!", "No part usage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    PartUsageForm puf = new PartUsageForm();
                    puf.DataGridView.DataSource = pu;
                    puf.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No part usage has been found for this document!", "No part usage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataGridView DataGridView
        {
            get { return this.dgvSearchResult; }
            set { this.dgvSearchResult = value; }
        }
        private void SearchResultView_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            originalBtnDocData = new Rectangle(btnDocData.Location.X, btnDocData.Location.Y, btnDocData.Width, btnDocData.Height);
            originalBtnSearchAgain = new Rectangle(btnSearchAgain.Location.X, btnSearchAgain.Location.Y, btnSearchAgain.Width, btnSearchAgain.Height);
            originalBtnSearchPartUsage = new Rectangle(btnSearchPartUsage.Location.X, btnSearchPartUsage.Location.Y, btnSearchPartUsage.Width, btnSearchPartUsage.Height);

            DataGridViewColumn ident = dgvSearchResult.Columns[0];          
            DataGridViewColumn zindex = dgvSearchResult.Columns[1];
            DataGridViewColumn zstatus = dgvSearchResult.Columns[2];
            DataGridViewColumn zkategorie = dgvSearchResult.Columns[3];
            DataGridViewColumn projnr = dgvSearchResult.Columns[4];
            DataGridViewColumn baanartnr = dgvSearchResult.Columns[5];
            DataGridViewColumn auftragnr = dgvSearchResult.Columns[6];
            DataGridViewColumn pono = dgvSearchResult.Columns[7];
            DataGridViewColumn itemno = dgvSearchResult.Columns[8];
            DataGridViewColumn zeichner = dgvSearchResult.Columns[9];
            DataGridViewColumn createdon = dgvSearchResult.Columns[10];
            DataGridViewColumn pruefer = dgvSearchResult.Columns[11];
            DataGridViewColumn pruefdatum = dgvSearchResult.Columns[12];
            DataGridViewColumn itemstatus = dgvSearchResult.Columns[13];
            DataGridViewColumn benennung = dgvSearchResult.Columns[14];
            DataGridViewColumn benennung2 = dgvSearchResult.Columns[15];
            DataGridViewColumn engbenennung = dgvSearchResult.Columns[16];
            DataGridViewColumn frabenennung = dgvSearchResult.Columns[17];
            DataGridViewColumn ptbenennung = dgvSearchResult.Columns[18];
            DataGridViewColumn material = dgvSearchResult.Columns[19];
            DataGridViewColumn size = dgvSearchResult.Columns[20];
            DataGridViewColumn weight = dgvSearchResult.Columns[21];
            DataGridViewColumn weightcad = dgvSearchResult.Columns[22];
            DataGridViewColumn statuscolor = dgvSearchResult.Columns[23];

            statuscolor.DisplayIndex = 0;
            ident.DisplayIndex = 1;
            zindex.DisplayIndex = 2;
            zstatus.DisplayIndex = 3;
            benennung.DisplayIndex = 4;
            benennung2.DisplayIndex = 5;
            engbenennung.DisplayIndex = 6;
            frabenennung.DisplayIndex = 7;
            ptbenennung.DisplayIndex = 8;
            zkategorie.DisplayIndex = 9;
            auftragnr.DisplayIndex = 10;
            pono.DisplayIndex = 11;
            projnr.DisplayIndex = 12;
            baanartnr.DisplayIndex = 13;
            itemno.DisplayIndex = 14;
            zeichner.DisplayIndex = 15;
            createdon.DisplayIndex = 16;
            pruefer.DisplayIndex = 17;
            pruefdatum.DisplayIndex = 18;
            itemstatus.DisplayIndex = 19;
            material.DisplayIndex = 20;
            size.DisplayIndex = 21;
            weight.DisplayIndex = 22;
            weightcad.DisplayIndex = 23;

            ident.Width = 100;
            ident.HeaderText = "Drawing number";
            zindex.Width = 40;
            zindex.HeaderText = "Index";
            zstatus.Width = 100;
            zstatus.HeaderText = "Status";
            zkategorie.Width = 200;
            zkategorie.HeaderText = "Categorie";

            projnr.Width = 80;
            projnr.HeaderText = "Project No.";
            baanartnr.Width = 100;
            baanartnr.HeaderText = "ERP Item number";
            auftragnr.Width = 100;
            auftragnr.HeaderText = "Order number";
            pono.Width = 50;
            pono.HeaderText = "Position";

            itemno.Width = 100;
            itemno.HeaderText = "Item number";
            zeichner.Width = 100;
            zeichner.HeaderText = "Created by";
            createdon.Width = 70;
            createdon.HeaderText = "Created on";
            pruefer.Width = 100;
            pruefer.HeaderText = "Released by";

            pruefdatum.Width = 70;
            pruefdatum.HeaderText = "Released on";
            itemstatus.Width = 100;
            itemstatus.HeaderText = "Item status";
            benennung.Width = 200;
            benennung.HeaderText = "PDM Designation";
            benennung2.Width = 200;
            benennung2.HeaderText = "PDM Add. Designation";

            engbenennung.Width = 200;
            engbenennung.HeaderText = "PDM Designation (en)";
            frabenennung.Width = 200;
            frabenennung.HeaderText = "PDM Designation (hu)";
            ptbenennung.Width = 200;
            ptbenennung.HeaderText = "PDM Designation (pt)";
            material.Width = 100;
            material.HeaderText = "Material";

            size.Width = 100;
            size.HeaderText = "Size";
            weight.Width = 50;
            weight.HeaderText = "Weight";
            weightcad.Width = 50;
            weightcad.HeaderText = "Weight";
            statuscolor.Width = 20;
            statuscolor.HeaderText = "";

            dgvSearchResult.CurrentCell.Selected = false;
        }
        private void btnSearchAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvSearchResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selected = dgvSearchResult.SelectedRows[0].DataBoundItem as Document;
                teilenummer =  selected.TeileNummer.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on a cell", "Wrong cell selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var selected = dgvSearchResult.SelectedRows[0].DataBoundItem as Document;
                teilenummer =  selected.TeileNummer.ToString();
                zIndex = selected.ZIndex.ToString();
                ident = selected.Ident.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on a cell", "Wrong cell selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDocData_Click(object sender, EventArgs e)
        {
            DBQueryPDM pdmDB = new DBQueryPDM();
            Document[] docs = pdmDB.SearchDocumentByClick("LiveDB", ident, zIndex);
            if (docs != null)
            {
                if (docs.Length == 0)
                    MessageBox.Show("No document has been found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (docs.Length == 1)
                {
                    MetaData md = new MetaData();
                    md.Ident = docs[0].Ident;
                    md.ZIndex = docs[0].ZIndex;
                    md.StatusTxt = docs[0].ZStatusTxt;
                    md.ZKategorie = docs[0].ZKategorie;
                    md.ProjNr = docs[0].ProjNr;
                    md.GueBaanArtNr = docs[0].GueBaanArtNr;
                    md.OrderNo = docs[0].GueAuftragNr;
                    md.PoNo = docs[0].GuePoNo;
                    md.TeileNummer = docs[0].TeileNummer;
                    md.Zeichner = docs[0].Zeichner;
                    md.AnlegeTag = docs[0].AnlegeTag;
                    md.Pruefer = docs[0].Pruefer;
                    md.PruefDatum = docs[0].PruefDatum;
                    md.CdbStatusTxt = docs[0].CdbStatusTxt;
                    md.Benennung = docs[0].Benennung;
                    md.Benennung2 = docs[0].Benennung2;
                    md.EngBenennung = docs[0].EngBenennung;
                    md.FraBenennung = docs[0].FraBenennung;
                    md.PtBenennung = docs[0].PtBenennung;
                    md.GueMaterial = docs[0].GueMaterial;
                    md.GueGroesse = docs[0].GueGroesse;
                    md.StGewicht = docs[0].StGewicht;
                    md.GueGewichtCad = docs[0].GueGewichtCad;
                    md.ShowDialog();
                }
                else
                {
                    SearchResultView searchResultView = new SearchResultView();
                    searchResultView.DataGridView.DataSource = docs;
                    searchResultView.ShowDialog();
                }
            }
        }
        private void dgvSearchResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 23) // column index for StatusColor
            {
                if (e.Value.Equals("red"))
                {
                    e.CellStyle.BackColor = Color.Crimson;
                    e.CellStyle.ForeColor = Color.Crimson;
                }
                else if (e.Value.Equals("black"))
                {
                    e.CellStyle.BackColor = Color.Black;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (e.Value.Equals("yellow"))
                {
                    e.CellStyle.BackColor = Color.Gold;
                    e.CellStyle.ForeColor = Color.Gold;
                }
                else if (e.Value.Equals("green"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value.Equals("light grey"))
                {
                    e.CellStyle.BackColor = Color.Silver;
                    e.CellStyle.ForeColor = Color.Silver;
                }
                else if (e.Value.Equals("dark grey"))
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.Gray;
                }
            }
        }
        private void ResizeControlBtnDocData(Rectangle r, Control c)
        {
            float xRatio = ((float)this.Width - (float)originalFormSize.Width)/2;
            float yRatio = (float)this.Height - (float)originalFormSize.Height;

            int newX = (int)(r.Location.X + xRatio);
            int newY = (int)(r.Location.Y + yRatio);

            c.Location = new Point(newX, newY);
        }
        private void ResizeControlBtnSearchAgain(Rectangle r, Control c)
        {
            float xRatio = ((float)this.Width/(float)originalFormSize.Width);
            float yRatio = (float)this.Height - (float)originalFormSize.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y + yRatio);

            c.Location = new Point(newX, newY);
        }
        private void ResizeControlBtnSearchPartUsage(Rectangle r, Control c)
        {
            float xRatio = ((float)this.Width/(float)originalFormSize.Width);
            float yRatio = (float)this.Height - (float)originalFormSize.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y + yRatio);

            c.Location = new Point(newX, newY);
        }
        private void SearchResultView_Resize(object sender, EventArgs e)
        {
            ResizeControlBtnDocData(originalBtnDocData, btnDocData);
            ResizeControlBtnSearchAgain(originalBtnSearchAgain, btnSearchAgain);
            ResizeControlBtnSearchPartUsage(originalBtnSearchPartUsage, btnSearchPartUsage);
        }
    }
}
