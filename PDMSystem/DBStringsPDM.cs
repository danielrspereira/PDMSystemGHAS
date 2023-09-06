using System.Collections.Generic;
using System.Text;

namespace PDMSystem
{
    public class DBStringsPDM
    {
        public static string SearchDocument(string erpCode, string ident, string orderNo, string pos, bool onlyCad)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT z.ident, z.z_index, z.z_status_txt, z.z_kategorie, z.projnr, ts.gue_baanartnr, z.gue_auftragnr, z.gue_pono, z.teilenummer, z.zeichner, z.anlegetag, z.pruefer, z.pruef_datum, ");
            sb.Append("ts.cdb_status_txt, ts.benennung, ts.benennung2, ts.eng_benennung, ts.fra_benennung, ts.pt_benennung, ts.gue_material, ts.gue_groesse, ts.st_gewicht, z.gue_gewicht_cad ");
            sb.Append("FROM CDBPROD.zeichnung z LEFT JOIN CDBPROD.teile_stamm ts ON z.teilenummer = ts.teilenummer ");           
            sb.Append(FilterDocumentSearch(erpCode, ident, orderNo, pos, onlyCad));
            sb.Append("ORDER BY z.anlegetag DESC ");
            return sb.ToString();
        }
        public static string SearchDocumentByClick(string ident, string zIndex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT z.ident, z.z_index, z.z_status_txt, z.z_kategorie, z.projnr, ts.gue_baanartnr, z.gue_auftragnr, z.gue_pono, z.teilenummer, z.zeichner, z.anlegetag, z.pruefer, z.pruef_datum, ");
            sb.Append("ts.cdb_status_txt, ts.benennung, ts.benennung2, ts.eng_benennung, ts.fra_benennung, ts.pt_benennung, ts.gue_material, ts.gue_groesse, ts.st_gewicht, z.gue_gewicht_cad ");
            sb.Append("FROM CDBPROD.zeichnung z LEFT JOIN CDBPROD.teile_stamm ts ON z.teilenummer = ts.teilenummer ");
            sb.Append("WHERE z.ident like '" + ident + "' ");
            if (zIndex == string.Empty)
                sb.Append("AND (z.z_index like '"+zIndex+"' or z.z_index like '\u0001') ");
            else
                sb.Append("AND z.z_index like '"+zIndex+"' ");
            sb.Append("ORDER BY z.anlegetag DESC ");
            return sb.ToString();
        }
        public static string SearchPartUsage (string teileNummer)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT z.ident, z.z_index, et.teilenummer, ts.benennung, ts.benennung2, z.z_status ");
            sb.Append("FROM cdbprod.einzelteile et LEFT JOIN cdbprod.zeichnung z on et.baugruppe = z.teilenummer  ");
            sb.Append("LEFT JOIN cdbprod.teile_stamm ts ON z.teilenummer = ts.teilenummer ");
            sb.Append("WHERE et.teilenummer like '"+teileNummer+"' AND z.ident IS NOT NULL ");
            sb.Append("ORDER BY z.ident, z.z_index");
            return sb.ToString();
        }
        public static string FilterDocumentSearch(string erpCode, string ident, string orderNo, string pos, bool onlyCad)
        {
            List<string> list = new List<string>();
            if (erpCode != string.Empty)
                list.Add("ts.gue_baanartnr like '"+erpCode+"' ");
            if (ident != string.Empty)
                list.Add("z.ident like '"+ident+"' ");
            if (orderNo != string.Empty)
                list.Add("z.gue_auftragnr like '"+orderNo+"' ");
            if (pos != string.Empty)
                list.Add("z.gue_pono like '"+pos+"' ");

            if (list.Count>1)
            {
                for (int i = 0; i < list.Count-1; i++)
                    list[i] = list[i]+" AND ";
            }

            string concat = string.Empty;
            foreach (var item in list)
            {
                concat = concat + item;
            }

            if (onlyCad)
                concat = concat + " AND z.erzeug_system like 'Solid%' ";

            return "WHERE " + concat;

        }
    }
}
