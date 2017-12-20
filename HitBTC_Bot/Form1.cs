using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBTC_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Test_two_Click(object sender, EventArgs e)
        {

            //Most successful bot strategy I had after all that time was the simplest: EMA crossover. Made a killing.Just need to leave it alone and not meddle.

            //15 min ticks, 20 short average 42 long.Those super secret parameters are on the house.You can tip me out later;)

            var url = "https://api.hitbtc.com/api/2/public/symbol";

            var syncClient = new WebClient();

            var testInfo = syncClient.DownloadString(url);

            var result = JsonConvert.DeserializeObject<List<SymbolResponse>>(testInfo);

            dataGridView1.DataSource = result;
            

        }

        private void btnGetSymbolnfo_Click(object sender, EventArgs e)
        {
            var url = string.Format("https://api.hitbtc.com/api/2/public/symbol/{0}", tbSymbolInfo.Text);

            using (var syncClient = new WebClient())
            {
                var testInfo = syncClient.DownloadString(url);

                List<SymbolResponse> LSR = new List<SymbolResponse>();

                var result = JsonConvert.DeserializeObject<SymbolResponse>(testInfo);

                LSR.Add(result);

                dataGridView2.DataSource = LSR;


            }


            var url2 = string.Format("https://api.hitbtc.com/api/2/public/ticker/{0}", tbSymbolInfo.Text);

            using (var syncClient = new WebClient())
            {
                var testInfo = syncClient.DownloadString(url2);

                List<CoinInfoResponse> CIR = new List<CoinInfoResponse>();

                var result = JsonConvert.DeserializeObject<CoinInfoResponse>(testInfo);

                tbHighPrice.Text = result.high.ToString();

                CIR.Add(result);

                dgvCoinInfo.DataSource = CIR;


            }

            

        }
    }
}
