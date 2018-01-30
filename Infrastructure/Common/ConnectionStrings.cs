using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common
{
    public static class ConnectionStrings
    {
        public static string BaseApi { get { return "https://data.nba.net"; } }
        public static string ApiVersion { get { return "10s"; } }
        public static string Environment { get { return "prod/v1"; } }
        public static string AllPlayers { get { return "players.json"; } }
        public static string Scoreboard { get { return "scoreboard.json"; } }
        public static string TodayStates { get { return "today.json"; } }

    }
}
