namespace PDMSystem
{
    public partial class PartUsageForm : Form
    {
        string ident = String.Empty;
        string zIndex = String.Empty;
        private Rectangle originalForm;
        private Rectangle originalBtnReturn;
        private Rectangle originalBtnMetaDataUsage;

        public PartUsageForm()
        {
            InitializeComponent();            
        }
        private void PartUsageForm_Load(object sender, EventArgs e)
        {
            // Positioning of button by form size change
            originalForm = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            originalBtnReturn = new Rectangle(btnReturn.Location.X, btnReturn.Location.Y, (int)btnReturn.Width, (int)btnReturn.Height);
            originalBtnMetaDataUsage = new Rectangle(btnMetaDataUsage.Location.X, btnMetaDataUsage.Location.Y, (int)btnMetaDataUsage.Width, (int)btnMetaDataUsage.Height);

            DataGridViewColumn baugruppe = dgvPartUsage.Columns[0];
            DataGridViewColumn teilenummer = dgvPartUsage.Columns[2];
            DataGridViewColumn index = dgvPartUsage.Columns[1];
            DataGridViewColumn benennung = dgvPartUsage.Columns[3];
            DataGridViewColumn benennung2 = dgvPartUsage.Columns[4];
            DataGridViewColumn status = dgvPartUsage.Columns[5];

            baugruppe.Width = 100;
            baugruppe.HeaderText = "Assembly";
            teilenummer.Width = 100;
            teilenummer.HeaderText = "Single part";
            benennung.Width = 200;
            benennung.HeaderText = "PDM Designation";
            benennung2.Width = 200;
            benennung2.HeaderText = "PDM Add. Designation";
            status.Width = 30;
            status.HeaderText = "";
            index.Width = 50;
            index.HeaderText = "Index";

            status.DisplayIndex = 0;
            baugruppe.DisplayIndex = 1;
            teilenummer.DisplayIndex = 2;
            benennung.DisplayIndex = 3;
            benennung2.DisplayIndex = 4;
            index.DisplayIndex = 5;

            dgvPartUsage.CurrentCell.Selected = false;
        }
        public DataGridView DataGridView
        {
            get { return this.dgvPartUsage; }
            set { this.dgvPartUsage = value; }
        }
        private void dgvPartUsage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPartUsage.Columns)
            {
                dgvPartUsage.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            try
            {
                var selected = dgvPartUsage.SelectedRows[0].DataBoundItem as PartUsage;
                ident =  selected.Ident.ToString();
                zIndex = selected.ZIndex;
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on a cell", "Wrong cell selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMetaDataUsage_Click(object sender, EventArgs e)
        {
            if (ident != String.Empty)
            {
                DBQueryPDM pdmDB = new DBQueryPDM();
                Document[] docs = pdmDB.SearchDocumentByClick("LiveDB", ident, zIndex);
                if (docs != null)
                {
                    if (docs.Length == 1)
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
                        MessageBox.Show("The selected item does not have any attached document.", "Item without documents", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvPartUsage_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var selected = dgvPartUsage.SelectedRows[0].DataBoundItem as PartUsage;
                ident =  selected.Ident.ToString();
                zIndex = selected.ZIndex;
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on a cell", "Wrong cell selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResizeControlBtnReturn(Rectangle r, Control c)
        {
            float xRatio = ((float)this.Width/(float)originalForm.Width);
            float yRatio = (float)this.Height - (float)originalForm.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y + yRatio);

            c.Location = new Point(newX, newY);
        }
        private void ResizeControlBtnMetaDataUsage(Rectangle r, Control c)
        {
            float xRatio = ((float)this.Width/(float)originalForm.Width);
            float yRatio = (float)this.Height - (float)originalForm.Height;

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y + yRatio);

            c.Location = new Point(newX, newY);
        }
        private void PartUsageForm_Resize(object sender, EventArgs e)
        {
            ResizeControlBtnReturn(originalBtnReturn, btnReturn);
            ResizeControlBtnMetaDataUsage(originalBtnMetaDataUsage, btnMetaDataUsage);
        }
        private void dgvPartUsage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5) // column index for StatusColor
            {
                if (e.Value.Equals("0"))
                {
                    e.CellStyle.BackColor = Color.Crimson;
                    e.CellStyle.ForeColor = Color.Crimson;
                }
                else if (e.Value.Equals("170"))
                {
                    e.CellStyle.BackColor = Color.Black;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (e.Value.Equals("100"))
                {
                    e.CellStyle.BackColor = Color.Gold;
                    e.CellStyle.ForeColor = Color.Gold;
                }
                else if (e.Value.Equals("200"))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value.Equals("190"))
                {
                    e.CellStyle.BackColor = Color.Silver;
                    e.CellStyle.ForeColor = Color.Silver;
                }
                else if (e.Value.Equals("180"))
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.Gray;
                }
                else if (e.Value.Equals("300"))
                {
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }
    }
}
