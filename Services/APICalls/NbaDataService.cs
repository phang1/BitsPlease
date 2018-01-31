using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Infrastructure.Common;
using System.Web.Script.Serialization;

namespace Services
{
    public class NbaDataService
    {
        public string GetAllPlayerData(string Year)
        {
            // http://data.nba.net/10s/prod/v1/2016/players.json
            // string apiEndpoint = string.Format("{0}/{1}/{2}/{3}/{4}", ConnectionStrings.BaseApi, ConnectionStrings.ApiVersion, ConnectionStrings.Environment, Year, ConnectionStrings.AllPlayers);
            string apiEndpoint = "http://stats.nba.com/stats/leagueLeaders?LeagueID=00&PerMode=PerGame&Scope=S&Season=2017-18&SeasonType=Regular+Season&StatCategory=PTS";
            string apiResponse;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiEndpoint);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                apiResponse = reader.ReadToEnd();
            }

            string resultSet = BaseLeagueLeaders.GetResultSet(apiResponse);
            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic players = js.Deserialize<dynamic>(resultSet);
            var test = players["rowSet"];
            List<PlayerDTO> playas = new List<PlayerDTO>();
            foreach(var stat in test)
            {
                playas.Add(new PlayerDTO
                {
                    PLAYER_ID = stat[0],
                    RANK = stat[1],
                    PLAYER =stat[2],
                    TEAM = stat[3],
                    GP = stat[4],
                    MIN = (float)stat[5],
                    FGM = (float)stat[6],
                    FGA = (float)stat[7],
                    FG_PCT = (float)stat[8],
                    FG3M = (float)stat[9],
                    FG3A = (float)stat[10],
                    FG3_PCT = (float)stat[11],
                    OREB = (float)stat[15],
                    DREB = (float)stat[16],
                    REB = (float)stat[17],
                    AST = (float)stat[18],
                    STL = (float)stat[19],
                    BLK = (float)stat[20],
                    TOV = (float)stat[21],
                    PTS = (float)stat[22],
                    EFF = (float)stat[23]
                });
            }

            return "";
        }
        public string GetJsonArray(string jsonString)
        {
            object test = JsonConvert.DeserializeObject<object>(jsonString);

            return "";
        }
        
    }

    public class BaseLeagueLeaders
    {
        string resource;
        string parameters;
        string resultSet;

        public static string GetResultSet(string completeString)
        {
            int startIndex = completeString.IndexOf("rowSet");
            string test = "{\"" + completeString.Substring(startIndex, completeString.Length - startIndex - 2) + "}";
            return test;
        }
    }

}
