using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Countries
{
    class JsonParser
    {
        public List<Country> GetCoiuntries(string url) => JsonConvert.DeserializeObject<List<Country>>((new WebClient()).DownloadString(url));
    }
}
