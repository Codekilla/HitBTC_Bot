using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBTC_Bot
{
    class CoinInfoResponse
    {
        public string symbol { get; set; }
        public string ask { get; set; }
        public string bid { get; set; }
        public string last { get; set; }
        public string low { get; set; }
        public string high { get; set; }
        public string open { get; set; }
        public string volume { get; set; }
        public string volumeQuoute { get; set; }
        public string timestamp { get; set; }

    }
}
