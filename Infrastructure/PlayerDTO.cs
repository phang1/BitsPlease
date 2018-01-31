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

        public int MIN { get; set; }

        public int FGM { get; set; }

        public int FGA { get; set; }

        public float FG_PCT { get; set; }

        public int FG3M { get; set; }

        public int FG3A { get; set; }
        
        public float FG3_PCT { get; set; }

        public int OREB { get; set; }

        public int DREB { get; set; }

        public int REB { get; set; }

        public int AST { get; set; }

        public int STL { get; set; }

        public int BLK { get; set; }

        public int TOV { get; set; }

        public int PF { get; set; }

        public int PTS { get; set; }

        public int EFF { get; set; }

        public float AST_TOV { get; set; }

        public float STL_TOV { get; set; }

    }


}
