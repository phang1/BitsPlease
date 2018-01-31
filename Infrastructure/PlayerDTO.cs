using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    /// <summary>
    /// Player object class populated by calls to the stats.nba.com
    /// </summary>
    public class PlayerDTO
    {
        public int PLAYER_ID { get; set; }

        public int RANK { get; set; }

        public string PLAYER { get; set; }

        public string TEAM { get; set; }

        public int GP { get; set; }

        public float MIN { get; set; }

        public float FGM { get; set; }

        public float FGA { get; set; }

        public float FG_PCT { get; set; }

        public float FG3M { get; set; }

        public float FG3A { get; set; }
        
        public float FG3_PCT { get; set; }

        public float OREB { get; set; }

        public float DREB { get; set; }

        public float REB { get; set; }

        public float AST { get; set; }

        public float STL { get; set; }

        public float BLK { get; set; }

        public float TOV { get; set; }

        public float PF { get; set; }

        public float PTS { get; set; }

        public float EFF { get; set; }

        public float AST_TOV { get; set; }

        public float STL_TOV { get; set; }

    }


}
