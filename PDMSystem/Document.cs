using System.Reflection;
using System.Text.RegularExpressions;

namespace PDMSystem
{
    public class Document
    {
        public string Ident { get; set; }
        public string ZIndex { get; set; }
        public string ZStatusTxt { get; set; }
        public string ZKategorie { get; set; }
        public string ProjNr { get; set; }
        public string GueBaanArtNr { get; set; }
        public string GueAuftragNr { get; set; }
        public string GuePoNo { get; set; }
        public string TeileNummer { get; set; }
        public string Zeichner { get; set; }
        public string AnlegeTag { get; set; }
        public string Pruefer { get; set; }
        public string PruefDatum { get; set; }
        public string CdbStatusTxt { get; set; }
        public string Benennung { get; set; }
        public string Benennung2 { get; set; }
        public string EngBenennung { get; set; }
        public string FraBenennung { get; set; }
        public string PtBenennung { get; set; }
        public string GueMaterial { get; set; }
        public string GueGroesse { get; set; }
        public string StGewicht { get; set; }
        public string GueGewichtCad { get; set; }
        public string StatusColor { get; set; }
        public static Document[] CorrectZIndex(Document[] docs)
        {
            List<Document> result = new List<Document>();
            foreach (var doc in docs)
            {
                foreach (PropertyInfo prop in doc.GetType().GetProperties())
                {
                    string value = prop.GetValue(doc, null).ToString();
                    if (value.Equals("\u0001"))
                    {
                        prop.SetValue(doc,String.Empty);
                    }
                }
                result.Add(doc);
            }
            return result.ToArray();
        }
        public static Document[] InsertStatusColor(Document[] docs)
        {
            List<Document> result = new List<Document>();
            foreach (var doc in docs)
            {
                string status = Regex.Replace(doc.ZStatusTxt, @"\s+", "");
                status = status.ToLower();
                switch (status)
                {
                    case "blocked":
                        doc.StatusColor = "black";
                        break;
                    case "draft":
                        doc.StatusColor = "red";
                        break;
                    case "freigegeben":
                        doc.StatusColor = "green";
                        break;
                    case "inarbeit":
                        doc.StatusColor = "red";
                        break;
                    case "inänderung":
                        doc.StatusColor = "light grey";
                        break;
                    case "konstfreigabe":
                        doc.StatusColor = "green";
                        break;
                    case "konst-freigabe":
                        doc.StatusColor = "green";
                        break;
                    case "konst.freugabe":
                        doc.StatusColor = "green";
                        break;
                    case "konst.freogabe":
                        doc.StatusColor = "green";
                        break;
                    case "konst.freigabe":
                        doc.StatusColor = "green";
                        break;
                    case "obsolete":
                        doc.StatusColor = "dark grey";
                        break;
                    case "released":
                        doc.StatusColor = "green";
                        break;
                    case "review":
                        doc.StatusColor = "yellow";
                        break;
                    case "revision":
                        doc.StatusColor = "light grey";
                        break;
                    case "gesperrt":
                        doc.StatusColor = "black";
                        break;
                    case "inprüfung":
                        doc.StatusColor = "yellow";
                        break;
                    case "inungültig":
                        doc.StatusColor = "black";
                        break;
                    case "ungültig":
                        doc.StatusColor = "black";
                        break;
                    case "umgültig":
                        doc.StatusColor = "black";
                        break;
                    default:
                        break;
                }
                result.Add(doc);
            }
            return result.ToArray();
        }
    }
}