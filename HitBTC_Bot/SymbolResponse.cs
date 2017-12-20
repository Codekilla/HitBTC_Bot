using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitBTC_Bot
{
    class SymbolResponse
    {
        public string id { get; set; }
        public string baseCurrency { get; set; }
        public string quoteCurrency { get; set; }
        public string quantityIncrement { get; set; }
        public string tickSize { get; set; }
        public string takeLiquidityRate { get; set; }
        public string provideLiquidityRate { get; set; }
        public string feeCurrency { get; set; }

    }
}
