using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PDMSystem
{
    public class DBQueryPDM
    {                    
        public Document[] ResultDocument(OracleCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var list = new List<Document>();
                while (reader.Read())
                {
                    list.Add(new Document
                    {
                        Ident = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        ZIndex = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        ZStatusTxt = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        ZKategorie = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        ProjNr = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        GueBaanArtNr = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        GueAuftragNr = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        GuePoNo = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        TeileNummer = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        Zeichner = reader.IsDBNull(9) ? "" : reader.GetString(9),
                        AnlegeTag = reader.IsDBNull(10) ? "" : reader.GetString(10),
                        Pruefer = reader.IsDBNull(11) ? "" : reader.GetString(11),
                        PruefDatum = reader.IsDBNull(12) ? "" : reader.GetString(12),
                        CdbStatusTxt = reader.IsDBNull(13) ? "" : reader.GetString(13),
                        Benennung = reader.IsDBNull(14) ? "" : reader.GetString(14),
                        Benennung2 = reader.IsDBNull(15) ? "" : reader.GetString(15),
                        EngBenennung = reader.IsDBNull(16) ? "" : reader.GetString(16),
                        FraBenennung = reader.IsDBNull(17) ? "" : reader.GetString(17),
                        PtBenennung = reader.IsDBNull(18) ? "" : reader.GetString(18),
                        GueMaterial = reader.IsDBNull(19) ?"" : reader.GetString(19),
                        GueGroesse = reader.IsDBNull(20) ? "" : reader.GetString(20),
                        StGewicht = reader.IsDBNull(21) ? "" : reader.GetString(21),
                        GueGewichtCad = reader.IsDBNull(22) ? "" : reader.GetString(22),
                        StatusColor = string.Empty
                    });
                }
                list = list.OrderByDescending(x => x.AnlegeTag).ThenBy(x => x.Ident).ThenBy(x => x.ZIndex).ToList();
                if (list.Count > 3000)
                    list.RemoveRange(3000, list.Count-3000);
                list = Document.InsertStatusColor(list.ToArray()).ToList();
                return Document.CorrectZIndex(list.ToArray());
            }
        }
        public PartUsage[] ResultPartUsage(OracleCommand cmd)
        {
            using (var reader = cmd.ExecuteReader())
            {
                var list = new List<PartUsage>();
                while (reader.Read())
                {
                    list.Add(new PartUsage
                    {
                        Ident = reader.IsDBNull(0) ? "" : reader.GetString(0),
                        ZIndex = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        TeileNummer = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Benennung = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Benennung2 = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        ZStatus = reader.IsDBNull(5) ?"":reader.GetString(5)
                    });
                }
                return PartUsage.CorrectZIndex(list.ToArray());
            }
        }
        public Document[] SearchDocument(string db, string erpCode, string ident, string orderNo, string pos, bool onlyCad)
        {
            OracleConnection conn = new OracleConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings[db].ConnectionString;
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = DBStringsPDM.SearchDocument(erpCode, ident, orderNo, pos, onlyCad);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                return ResultDocument(cmd);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public Document[] SearchDocumentByClick(string db, string ident, string zIndex)
        {
            OracleConnection conn = new OracleConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings[db].ConnectionString;
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = DBStringsPDM.SearchDocumentByClick(ident, zIndex);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                return ResultDocument(cmd);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public PartUsage[] SearchPartUsage(string db, string teileNummer)
        {
            OracleConnection conn = new OracleConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings[db].ConnectionString;
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = DBStringsPDM.SearchPartUsage(teileNummer);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                return ResultPartUsage(cmd);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
