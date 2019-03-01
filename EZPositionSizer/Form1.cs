using RestSharp;
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

namespace EZPositionSizer
{
    public partial class Form1 : Form
    {
        RestClient client;
        double rewardMultiplier = 1.5;

        public Form1()
        {
            InitializeComponent();
            client = new RestClient("https://api.exchangeratesapi.io");
        }

        private void ValidateAndCalculate()
        {
            if (!String.IsNullOrEmpty(tb_stopLoss.Text) && !String.IsNullOrEmpty(tb_accBalance.Text))
            {
                double stopDistance, accBalance = 0;
                bool two = double.TryParse(tb_stopLoss.Text, out stopDistance);
                bool three = double.TryParse(tb_accBalance.Text, out accBalance);

                if (two && three)
                {
                    GetResult(accBalance, stopDistance);
                }
                
            }
        }

        private void GetResult(double accBalance, double stopDistance)
        {
            RestRequest req = new RestRequest("/latest");
            CurrencyRates rates = client.Execute<CurrencyRates>(req).Data;

            double eur = rates.rates.USD;

            double size = Math.Round((((accBalance * .01) / stopDistance) / 10) * eur, 2);
            lb_size.Text = Math.Round((((accBalance * .01) / stopDistance) / 10) * eur, 3).ToString();
            lb_size.Visible = true;
            tb_positionSize.Text = size.ToString();

            //double curPriceLeft = Math.Floor(Convert.ToDouble(tb_curPrice.Text));
            //double curPriceDecimal = Convert.ToDouble(tb_curPrice.Text) - Math.Truncate(1.0);// = (Convert.ToDouble(tb_curPrice.Text) + (stopDistance * 1.5)).ToString();


            double takeProfitDiff = stopDistance * rewardMultiplier;
            tb_takeProfitDiff.Text = takeProfitDiff.ToString();
            //double takeProfit = Convert.ToDouble(curPriceLeft.ToString() + "." + curPriceDecimal + (stopDistance * 1.5));
        }


        private void btn_calc_Click(object sender, EventArgs e)
        {
            ValidateAndCalculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_accBalance.Focus();
        }

        private void tb_stopLoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_calc.PerformClick();
            }
        }

        private void tb_curPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_calc.PerformClick();
            }
        }

        private void tb_accBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_calc.PerformClick();            }
        }

        private void tb_positionSize_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tb_positionSize.Text);
                lb_status.Text = "Position Size copied.";
            }
            catch { }
            
        }

        private void tb_takeProfit_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lb_status.Text = "Take Profit (Buy) copied.";
            }
            catch { }
        }

        private void tb_takeProfitSell_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                lb_status.Text = "Take Profit (Sell) copied.";
            }
            catch { }
        }

        private void tb_takeProfitDiff_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tb_takeProfitDiff.Text);
                lb_status.Text = "Take Profit (Pip) copied.";
            }
            catch { }
        }

        private void tb_rrr_Scroll(object sender, EventArgs e)
        {
            double rrr = tb_rrr.Value / 100.0;
            rewardMultiplier = rrr;
            string label = string.Format("1:{0:0.0}R", rrr);
            lb_rrr.Text = label;
        }
    }
}
