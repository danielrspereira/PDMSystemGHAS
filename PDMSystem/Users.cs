using System.Collections.Generic;

namespace PDMSystem
{
    public class Users
    {
        public static string[] GetAllUsers()
        {
            List<string> users = new List<string>();
            // Engineering Solutions
            users.Add("dpereira");
            users.Add("mlewin");
            users.Add("hconrad");
            users.Add("mmientus");
            users.Add("danie");

            // Arbeitsvorbereitung Tata
            users.Add("ianita");
            users.Add("iraica");
            users.Add("rpredesc");
            users.Add("spopovic");
            users.Add("mtudorac");
            users.Add("randrei");
            users.Add("gherascu");
            users.Add("gmanea");
            users.Add("smorar");

            return users.ToArray();
        }
    }
}
