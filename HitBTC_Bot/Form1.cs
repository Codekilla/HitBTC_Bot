using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        Timer MyTimer;

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



        private double CalulateEMA(int TimeFrame , double lastDayclose, double emaYesterday)
        {
            // formula:  EMA = Price(t) * k + EMA(y) * (1 – k)
            // t = today, y = yesterday, N = number of days in EMA, k = 2/(N+1)

            //step 1 : Start by calculating k for the given timeframe.
            double k = (double)(decimal.Divide(2, (TimeFrame + 1)));


            //int step 2 : Add the closing prices for the first 22 days together and divide them by 22.
            // This is the SMA caluated. 
            double SMA = SimpleMovingAverage(22.81, 23.09, 22.91, 23.23, 22.83, 23.05, 23.02, 23.29, 23.41, 23.49);

            // step 3 : start getting the first EMA day by taking the following day’s (day 23) closing price multiplied by k, 
            // then multiply the previous day’s moving average by (1-k) and add the two.

            return (SMA * k) + (emaYesterday * (1.0 - k));

        }

        private double SimpleMovingAverage(double v1, double v2, double v3, double v4, double v5, double v6, double v7, double v8, double v9, double v10)
        {
            return (v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10) / 10;
        }

        private void btnCalcEMA_Click(object sender, EventArgs e)
        {
            //double dCatch = CalulateEMA(10, 23.49, 23.15);

            //MessageBox.Show(dCatch.ToString());
            FormEMA fEMA = new FormEMA();
            fEMA.Show();

        }

        private void writeoutlast(decimal value)
        {
            string sinFromEmaLog = "";

            sinFromEmaLog = File.ReadAllText(@"C:\temp\EMALog_json.txt");

            var list = JsonConvert.DeserializeObject<List<EMAValue_Json>>(sinFromEmaLog);


            EMAValue_Json itemToAdd = new EMAValue_Json();
            itemToAdd.NumVal = value.ToString();


            list.Add(itemToAdd);

            string convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);


            File.WriteAllText(@"C:\temp\EMALog_json.txt", convertedJson);
        }

        private void writeone()
        {
            EMAValue_Json sb = new EMAValue_Json();
            sb.NumVal = "500";

            List<EMAValue_Json> list = new List<EMAValue_Json>();
            list.Add(sb);

            string convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.AppendAllText(@"C:\temp\EMALog_json.txt", convertedJson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeoutlast(1);
        }


        // Run Button
        private void button3_Click(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (30000); 
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            decimal dValToWrite = 0;

            var url2 = string.Format("https://api.hitbtc.com/api/2/public/ticker/{0}", tbSymbolInfo.Text);

            using (var syncClient = new WebClient())
            {
                var testInfo = syncClient.DownloadString(url2);

                var result = JsonConvert.DeserializeObject<CoinInfoResponse>(testInfo);

                dValToWrite = decimal.Parse(result.last);

            }

            writeoutlast(dValToWrite);

            
           
        }

        private void btnGetLastTen_Click(object sender, EventArgs e)
        {
            string sinFromEmaLog = "";

            sinFromEmaLog = File.ReadAllText(@"C:\temp\EMALog_json.txt");

            var list = JsonConvert.DeserializeObject<List<EMAValue_Json>>(sinFromEmaLog);

            var list2 = list.GetRange((list.Count - 5), 4);

            foreach (EMAValue_Json ema in list2)
            {
                MessageBox.Show(ema.NumVal.ToString());
            }
        }
    }
}
