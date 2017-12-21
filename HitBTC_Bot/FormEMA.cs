using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitBTC_Bot
{
    public partial class FormEMA : Form
    {
        public FormEMA()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int tf = int.Parse(tbTimeframe.Text);
            double ldc = double.Parse(tbLastdayClose.Text);
            double emaYes = double.Parse(tbEmaYesterday.Text);

           tbCurEMA.Text =  CalulateEMA(tf, ldc, emaYes).ToString();
        }


        private double CalulateEMA(int TimeFrame, double lastDayclose, double emaYesterday)
        {
            // formula:  EMA = Price(t) * k + EMA(y) * (1 – k)
            // t = today, y = yesterday, N = number of days in EMA, k = 2/(N+1)

            //step 1 : Start by calculating k for the given timeframe.
            double k = (double)(decimal.Divide(2, (TimeFrame + 1)));


            //int step 2 : Add the closing prices for the first 22 days together and divide them by 22.
            // This is the SMA caluated. 

            //double SMA = SimpleMovingAverage(22.81, 23.09, 22.91, 23.23, 22.83, 23.05, 23.02, 23.29, 23.41, 23.49);

            // step 3 : start getting the first EMA day by taking the following day’s (day 23) closing price multiplied by k, 
            // then multiply the previous day’s moving average by (1-k) and add the two.

            //return (SMA * k) + (emaYesterday * (1.0 - k));
            return (lastDayclose * k) + (emaYesterday * (1.0 - k));

        }

        private double SimpleMovingAverage(double v1, double v2, double v3, double v4, double v5, double v6, double v7, double v8, double v9, double v10)
        {
            return (v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10) / 10;
        }

        private void FormEMA_Load(object sender, EventArgs e)
        {
            tbEMA_10_1.Text = "23.47";
            tbEMA_10_2.Text = "23.70";
            tbEMA_10_3.Text = "23.86";
            tbEMA_10_4.Text = "23.83";
            tbEMA_10_5.Text = "23.73";
            tbEMA_10_6.Text = "23.69";
            tbEMA_10_7.Text = "23.56";
            tbEMA_10_8.Text = "23.50";
            tbEMA_10_9.Text = "23.42";
            tbEMA_10_10.Text = "23.30";
        }

        private void writeoutlast()
        {


        }
    }
}
