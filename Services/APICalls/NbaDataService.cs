using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Common;
using System.Net;
using System.IO;

namespace Services
{
    public class NbaDataService
    {
        public string GetAllPlayerData(string Year)
        {
            // http://data.nba.net/10s/prod/v1/2016/players.json
            string apiEndpoint = string.Format("{0}/{1}/{2}/{3}/{4}", ConnectionStrings.BaseApi, ConnectionStrings.ApiVersion, ConnectionStrings.Environment, Year, ConnectionStrings.AllPlayers);
            string apiResponse;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiEndpoint);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                apiResponse = reader.ReadToEnd();
            }

            return "";
        }
    }
}
