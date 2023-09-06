using System.Text.Json;
using System.Net;
using System.Reflection;
using System.Text;

namespace PDMSystem
{
    class WebCheckOut
    {
        private string GeneratePayLoad(string checkOutFolder, string drawingNo, string zIndex, string extensions)
        {
            Objects obj1 = new Objects
            {
                Obj = new Object[]
                {
                    new Object
                    {
                        Ident = drawingNo,
                        ZIndex = zIndex,
                        OutputFolder = checkOutFolder,
                        Extensions = extensions
                    }
                }
            };

            return JsonSerializer.Serialize(obj1);
        }
        private string CreateAuthorization(string login, string password)
        {
            string authorisation = string.Format("{0}:{1}", login, password);
            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(authorisation));
            return string.Format("{0} {1}", "Basic", encoded);
        }
        public (int, string) SendRequest(string url, string checkOutFolder, string drawingNo, string zIndex, string extensions, string login, string password)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            int statusCode = 0;
            try
            {
                request.ContentType = "application/json";
                request.Method = "GET";

                string payload = GeneratePayLoad(checkOutFolder, drawingNo, zIndex, extensions);

                string header = CreateAuthorization(login, password);

                request.Headers[HttpRequestHeader.Authorization] = header;

                var type = request.GetType();
                var currentMethod = type.GetProperty("CurrentMethod", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(request);

                var methodType = currentMethod.GetType();
                methodType.GetField("ContentBodyNotAllowed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(currentMethod, false);

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(payload);
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                statusCode = (int)response.StatusCode;
                string statusDescription = response.StatusDescription;
                response.Close();
                return (statusCode, statusDescription);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("("))
                {
                    int pFrom = ex.Message.IndexOf("(") + "(".Length;
                    int pTo = ex.Message.LastIndexOf(")");
                    string code = ex.Message.Substring(pFrom, pTo - pFrom);
                    pFrom = ex.Message.IndexOf(")") + ")".Length;
                    string statusText = ex.Message.Substring(pFrom, ex.Message.Length-pFrom);
                    if (Directory.Exists(checkOutFolder))
                    {
                        try
                        {
                            Directory.Delete(checkOutFolder, true);
                        }
                        catch (Exception) { }
                    }
                    return (Convert.ToInt16(code), statusText);
                }
                return (401, "Error. Try again!");
            }
        }
    }
}
