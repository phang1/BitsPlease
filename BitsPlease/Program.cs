using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace BitsPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            NbaDataService nbaDataService = new NbaDataService();
            nbaDataService.GetAllPlayerData("2016");
        }
    }
}
