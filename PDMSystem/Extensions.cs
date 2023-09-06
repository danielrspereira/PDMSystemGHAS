using System.Diagnostics;

namespace PDMSystem
{
    public partial class Extensions : Form
    {
        public Extensions()
        {
            InitializeComponent();
        }
        private void btnExportFinal_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection openForms = Application.OpenForms;
            List<Form> forms = new List<Form>();
            foreach (Form form in openForms)
            {
                if (form.Name=="MetaData")
                    forms.Add(form);
            }

            Form f = forms[forms.Count-1];
            string ident = ((MetaData)f).Ident;
            string zIndex = ((MetaData)f).ZIndex;

            WebCheckOut web = new WebCheckOut();
            string uri = "http://deffbswap12.europe.guentner-corp.com:7488/exportfiles";

            DateTime foo = DateTime.Now;
            string unixTimeStamp = ((DateTimeOffset)foo).ToUnixTimeSeconds().ToString();
            string extensions = GetExtensions();
            if (extensions.Length>0)
            {               
                string outputFolder = CreateOutputFolder(ident);
                (int statusCode, string statusText) = web.SendRequest(uri, outputFolder, ident, zIndex, extensions, "caddok", "Pdm2Erp!");

                if (statusCode == 200)
                    Process.Start(outputFolder);                   
                else
                    MessageBox.Show(statusText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearAll()
        {
            cbAll.Checked = false;
            cbDWG.Checked = false;
            cbDXF.Checked = false;
            cbDWG.Checked = false;
            cbJT.Checked = false;
            cbPDF.Checked = false;
            cbSEFiles.Checked = false;
        }
        public string GetExtensions()
        {
            string extensions = String.Empty;
            if (cbSEFiles.Checked)
                extensions = extensions + ",SolidEdge:asm,SolidEdge:draft,SolidEdge:part,SolidEdge:psm";
            if (cbDWG.Checked)
                extensions = extensions + ",dwg";
            if (cbDXF.Checked)
                extensions = extensions + ",dxf";
            if (cbJT.Checked)
                extensions = extensions + ",jt";
            if (cbPDF.Checked)
                extensions = extensions + ",acrobat";
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
            string user = Environment.UserName;
            string unixTimeStamp = ((DateTimeOffset)foo).ToUnixTimeSeconds().ToString();
            string outputFolder = "\\\\10.1.11.20\\global\\PDM_Webservices\\PDMExportFilesWithGUI\\"+user+"_"+ident+"_"+unixTimeStamp+"\\";

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
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
            {
                cbDWG.Checked = true;
                cbDXF.Checked = true;
                cbDWG.Checked = true;
                cbJT.Checked = true;
                cbPDF.Checked = true;
                cbSEFiles.Checked = true;
            }
            else
            {
                cbDWG.Checked = false;
                cbDXF.Checked = false;
                cbDWG.Checked = false;
                cbJT.Checked = false;
                cbPDF.Checked = false;
                cbSEFiles.Checked = false;
            }
        }
        private void cbSEFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSEFiles.Checked)
            {
                cbDWG.Checked = true;
                cbDXF.Checked = true;
                cbDWG.Checked = true;
                cbJT.Checked = true;
                cbPDF.Checked = true;
                cbAll.Checked = true;
            }
            else
            {
                cbDWG.Checked = false;
                cbDXF.Checked = false;
                cbDWG.Checked = false;
                cbJT.Checked = false;
                cbPDF.Checked = false;
                cbAll.Checked= false;
            }
        }
        private void Extensions_Load(object sender, EventArgs e)
        {

        }
    }
}
