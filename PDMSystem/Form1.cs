using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PDMSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbErpCode.TextAlign = HorizontalAlignment.Center;
            tbIdent.TextAlign = HorizontalAlignment.Center;
            tbOrderNo.TextAlign = HorizontalAlignment.Center;
            tbPosition.TextAlign = HorizontalAlignment.Center;
            CheckIfIsOriginalApp();
            CheckAppVersion();
        }
        private void btnSearchDoc_Click(object sender, EventArgs e)
        {
            string ident = CorrectIdent();
            string erpCode = CorrectErpCode();
            string orderNo = CorrectOrderNo();
            string position = CorrectPosition();
            tbIdent.Enabled = false;
            tbErpCode.Enabled = false;
            tbOrderNo.Enabled = false;
            tbPosition.Enabled = false;
            cbOnlyCad.Enabled = false;
            btnSearchDoc.Enabled = false;

            if (ident.Length>0 || erpCode.Length>0 || orderNo.Length>0 || position.Length>0)
            {
                DBQueryPDM pdmDB = new DBQueryPDM();
                Document[] docs = pdmDB.SearchDocument("LiveDB", erpCode, ident, orderNo, position, Global.OnlyCad);
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
                        searchResultView.Text = "Documents ("+docs.Length.ToString()+ " results)";
                        searchResultView.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Please enter a search value!", "No search value", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tbIdent.Enabled = true;
            tbErpCode.Enabled = true;
            tbOrderNo.Enabled = true;
            tbPosition.Enabled = true;
            cbOnlyCad.Enabled = true;
            btnSearchDoc.Enabled = true;
        }
        private string CorrectIdent()
        { 
            if (tbIdent.Text != null)
            {
                if (tbIdent.Text.Length>0)
                {
                    string result = tbIdent.Text;
                    result = result.Replace('*', '%');
                    result = Regex.Replace(result, @"\s+", "");
                    if (result.StartsWith("D") && result.Length>12)
                        result = result.Substring(0, 12);
                    if (result.Length>=4)
                    {
                        if (result.Substring(3, 1).Equals('-') && result.Length>14)
                            result = result.Substring(0, 14);
                    }
                    return result;
                }

            }
            return String.Empty;
        }
        private string CorrectErpCode()
        {
            if (tbErpCode.Text!=null)
            {
                if (tbErpCode.Text.Length>0)
                {
                    string result = tbErpCode.Text;
                    result = result.Replace('*', '%');
                    result = Regex.Replace(result, @"\s+", "");
                    return result;
                }

            }
            return String.Empty;
        }
        private string CorrectOrderNo()
        {
            if (tbOrderNo.Text!=null)
            {
                if (tbOrderNo.Text.Length>0)
                {
                    string result = tbOrderNo.Text;
                    result = result.Replace('*', '%');
                    result = Regex.Replace(result, @"\s+", "");
                    return result;
                }
            }
            return String.Empty;
        }
        private string CorrectPosition()
        {
            if (tbPosition.Text!=null)
            {
                if (tbPosition.Text.Length>0)
                {
                    string result = tbPosition.Text;
                    result = result.Replace('*', '%');
                    result = Regex.Replace(result, @"\s+", "");
                    return result;
                }
            }
            return String.Empty;
        }
        private void tbIdent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchDoc_Click(this, new EventArgs());
            }
        }
        private void tbErpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchDoc_Click(this, new EventArgs());
            }
                
        }
        private void cbOnlyCad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnlyCad.Checked)
                Global.OnlyCad = true;
            else
                Global.OnlyCad = false;
        }
        private void tbOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchDoc_Click(this, new EventArgs());
            }               
        }
        private void tbPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchDoc_Click(this, new EventArgs());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckAppVersion()
        {
            string fullAppPath = Process.GetCurrentProcess().MainModule.FileName;
            DateTime creationDate = File.GetCreationTimeUtc(fullAppPath);
            DateTime creationDateGlobal = File.GetCreationTimeUtc(@$"C:\users\{Environment.UserName}\desktop\PDMSystem.exe");
            if ((creationDateGlobal - creationDate).TotalMilliseconds > 0)
            {
                string suffix = GetFileSuffix();
                string newFile = @"C:\Users\" + Environment.UserName + "\\Desktop\\PdmExportFiles_" + suffix + ".exe";
                File.Copy(@"\\10.1.11.20\global\PDM_Webservices\PDMExportFilesWithGUI\ExportFiles\PDMExportFilesWithoutLogin.exe", newFile);
                MessageBox.Show("A more recent version of this software has been detected." + Environment.NewLine + "It has been copied to:" + Environment.NewLine + Environment.NewLine + newFile + Environment.NewLine + Environment.NewLine + "This version will be automatically deleted in the next seconds.", "!!! Obsolete Version !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelfDelete();
                Environment.Exit(1);
            }
        }

        private void CheckIfIsOriginalApp()
        {
            string fullAppPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            MessageBox.Show(fullAppPath);
            if (fullAppPath.Contains(@"PDM_Webservices\PDMExportFilesWithGUI\ExportFiles\PDMExportFilesWithoutLogin.exe"))
            {
                string suffix = GetFileSuffix();
                string newFile = @"C:\Users\" + Environment.UserName + "\\Desktop\\PdmExportFiles_" + suffix + ".exe";
                File.Copy(@"\\10.1.11.20\global\PDM_Webservices\PDMExportFilesWithGUI\ExportFiles\PdmExportFiles.exe", newFile);
                MessageBox.Show("You're using the original file from Global directory" + Environment.NewLine + "A copy has been created on:" + Environment.NewLine + Environment.NewLine + newFile + Environment.NewLine + Environment.NewLine + "Please use this copy.", "!!! Original File Detection !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private string GetFileSuffix()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            if (month.Length == 1)
                month = "0" + month;
            string day = DateTime.Now.Day.ToString();
            if (day.Length == 1)
                day = "0" + day;
            string hour = DateTime.Now.Hour.ToString();
            if (hour.Length == 1)
                hour = "0" + hour;
            string minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
                minute = "0" + minute;
            string second = DateTime.Now.Second.ToString();
            if (second.Length == 1)
                second = "0" + second;
            return year + month + day + "_" + hour + minute + second;
        }

        private void SelfDelete()
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
        }
    }
}
