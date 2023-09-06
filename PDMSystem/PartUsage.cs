using System.Reflection;

namespace PDMSystem
{
    public class PartUsage
    {
        public string Ident { get; set; }
        public string ZIndex { get; set; }
        public string TeileNummer { get; set; }
        public string Benennung { get; set; }
        public string Benennung2 { get; set; }
        public string ZStatus { get; set; }
        public static PartUsage[] CorrectZIndex(PartUsage[] pus)
        {
            List<PartUsage> result = new List<PartUsage>();
            foreach (var pu in pus)
            {
                foreach (PropertyInfo prop in pu.GetType().GetProperties())
                {
                    string value = prop.GetValue(pu, null).ToString();
                    if (value.Equals("\u0001"))
                        prop.SetValue(pu, string.Empty);
                }
                result.Add(pu);
            }
            return result.ToArray();
        }
    }
}
