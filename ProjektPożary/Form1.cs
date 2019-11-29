using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPożary
{

    public partial class Form1 : Form
    {
        private double mounthSave;
        private double mounthMid;
        private double mounthDanger;

        private double dmcSave;
        private double dmcMid;
        private double dmcDanger;

        private double dcSave;
        private double dcMid;
        private double dcDanger;

        //wyniki
        private List<double> veryDanger = new List<double>();
        private List<double> danger = new List<double>();
        private List<double> mid = new List<double>();
        private List<double> low = new List<double>();
        private List<double> veryLow = new List<double>();
        double veryDangerResult;
        double dangerResult;
        double midResult;
        double lowResult;
        double veryLowResult;


        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            MounthAlocation(MounthBox.Text);
            DmcAlocation(DmcBox.Text);
            DcAlocation(DcBox.Text);

            Rules();

             results();
             Console.WriteLine("veryDanger =" + veryDangerResult + " danger =" + dangerResult + " mid=" + midResult + " low=" + lowResult + " veryLow=" + veryLowResult);
             Console.WriteLine();
        }

        private void results()
        {
            if (veryDangerResult >= dangerResult && veryDangerResult >= midResult && veryDangerResult >= lowResult && veryDangerResult >= veryLowResult)
                LoadResult(veryDangerResult, null,null,null,null);
            // Console.WriteLine("veryDanger =" + veryDangerResult);
            else if (dangerResult >= veryDangerResult && dangerResult >= midResult && dangerResult >= lowResult && dangerResult >= veryLowResult)
                LoadResult(null, dangerResult, null, null, null);
            // Console.WriteLine("danger =" + dangerResult);
            else if (midResult >= dangerResult && midResult >= veryDangerResult && midResult >= lowResult && midResult >= veryLowResult)
                LoadResult(null, null, midResult, null, null);
            // Console.WriteLine("mid =" + midResult);
            else if (lowResult >= dangerResult && lowResult >= midResult && lowResult >= veryDangerResult && lowResult >= veryLowResult)
                LoadResult(null, null, null, lowResult, null);
            //  Console.WriteLine("low =" + lowResult);
            else if (veryLowResult >= dangerResult && veryLowResult >= midResult && veryLowResult >= lowResult && veryLowResult >= veryDangerResult)
                LoadResult(null, null, null, null, veryLowResult);
            //  Console.WriteLine("veryLow =" + veryLowResult);
        }

        private void LoadResult(double? veryDangerR, double? dangerR, double?midR, double? lowR, double? veryLowR)
        {
            var frm = new ResultForm(veryDangerR, dangerR,  midR,  lowR, veryLowR);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void DmcAlocation(string dmcString)
        {
            var dmc = Int32.Parse(dmcString);

            if (dmc <= 15)
            {
                dmcSave = ((-1 / 25.0) * dmc) + 1;
                dmcMid = 0;
                dmcDanger = 0;
            }
            if (dmc > 15 && dmc < 25)
            {
                dmcSave = ((-1 / 25.0) * dmc) + 1;
                dmcMid = 1 - ((25 - dmc) / 10.0);
                dmcDanger = 0;
            }
            if (dmc == 25)
            {
                dmcSave = 0;
                dmcMid = 1;
                dmcDanger = 0;
            }
            if (dmc > 25 && dmc < 35)
            {
                dmcSave = 0;
                dmcMid = (35 - dmc) / 10.0;
                dmcDanger = 1 - ((50 - dmc) / 25.0);
            }
            if (dmc >= 35 && dmc < 50)
            {
                dmcSave = 0;
                dmcMid = 0;
                dmcDanger = 1 - ((50 - dmc) / 25.0);
            }
            if (dmc >= 50)
            {
                dmcSave = 0;
                dmcMid = 0;
                dmcDanger = 1;
            }
        }

        private void DcAlocation(string dcString)
        {
            var dc = Int32.Parse(dcString);

            if (dc <= 100)
            {
                dcSave = ((-1 / 150.0) * dc) + 1;
                dcMid = 0;
                dcDanger = 0;
            }
            if (dc > 100 && dc < 150)
            {
                dcSave = ((-1 / 150.0) * dc) + 1;
                dcMid = 1 - ((150 - dc) / 50.0);
                dcDanger = 0;
            }
            if (dc == 150)
            {
                dcSave = 0;
                dcMid = 1;
                dcDanger = 0;
            }
            if (dc > 150 && dc < 200)
            {
                dcSave = 0;
                dcMid = (200 - dc) / 50.0;
                dcDanger = 1 - ((300 - dc) / 150.0);
            }
            if (dc >= 150 && dc < 300)
            {
                dcSave = 0;
                dcMid = 0;
                dcDanger = 1 - ((300 - dc) / 150.0);
            }
            if (dc >= 300)
            {
                dcSave = 0;
                dcMid = 0;
                dcDanger = 1;
            }
        }

        private void MounthAlocation(string mounth)
        {
            switch (mounth)
            {
                case "Styczeń":
                    {
                        mounthSave = 1;
                        mounthMid = 0.2;
                        mounthDanger = 0;
                        break;
                    }
                case "Luty":
                    {
                        mounthSave = 1;
                        mounthMid = 0.2;
                        mounthDanger = 0;
                        break;
                    }
                case "Marzec":
                    {
                        mounthSave = 0.5;
                        mounthMid = 0.5;
                        mounthDanger = 0;
                        break;
                    }
                case "Kwiecień":
                    {
                        mounthSave = 0.2;
                        mounthMid = 1;
                        mounthDanger = 0;
                        break;
                    }
                case "Maj":
                    {
                        mounthSave = 0;
                        mounthMid = 1;
                        mounthDanger = 0.2;
                        break;
                    }
                case "Czerwiec":
                    {
                        mounthSave = 0;
                        mounthMid = 0.5;
                        mounthDanger = 0.5;
                        break;
                    }
                case "Lipiec":
                    {
                        mounthSave = 0;
                        mounthMid = 0.2;
                        mounthDanger = 1;
                        break;
                    }
                case "Sierpień":
                    {
                        mounthSave = 0;
                        mounthMid = 0.2;
                        mounthDanger = 1;
                        break;
                    }
                case "Wrzesień":
                    {
                        mounthSave = 0;
                        mounthMid = 0.5;
                        mounthDanger = 0.5;
                        break;
                    }
                case "Październik":
                    {
                        mounthSave = 0;
                        mounthMid = 1;
                        mounthDanger = 0.2;
                        break;
                    }
                case "Listopad":
                    {
                        mounthSave = 0.2;
                        mounthMid = 1;
                        mounthDanger = 0;
                        break;
                    }
                case "Grudzień":
                    {
                        mounthSave = 0.5;
                        mounthMid = 0.5;
                        mounthDanger = 0;
                        break;
                    }
            }
        }

        private void Rules()
        {
            //r1 mounthDanger && dmcDanger && dcDanger = BardzoWysokie
            veryDanger.Add(findMin(mounthDanger, dmcDanger, dcDanger));
            veryDanger.Add(findMin(mounthDanger, dmcMid, dcDanger));
            mid.Add(findMin(mounthDanger, dmcSave, dcDanger));

            veryDanger.Add(findMin(mounthDanger, dmcDanger, dcMid));
            danger.Add(findMin(mounthDanger, dmcMid, dcMid));
            low.Add(findMin(mounthDanger, dmcSave, dcMid));

            mid.Add(findMin(mounthDanger, dmcDanger, dcSave));
            low.Add(findMin(mounthDanger, dmcMid, dcSave));
            low.Add(findMin(mounthDanger, dmcSave, dcSave));

            veryDanger.Add(findMin(mounthMid, dmcDanger, dcDanger));
            danger.Add(findMin(mounthMid, dmcMid, dcDanger));
            low.Add(findMin(mounthMid, dmcSave, dcDanger));

            danger.Add(findMin(mounthMid, dmcDanger, dcMid));
            mid.Add(findMin(mounthMid, dmcMid, dcMid));
            low.Add(findMin(mounthMid, dmcSave, dcMid));

            low.Add(findMin(mounthMid, dmcDanger, dcSave));
            low.Add(findMin(mounthMid, dmcMid, dcSave));
            veryLow.Add(findMin(mounthMid, dmcSave, dcSave));

            mid.Add(findMin(mounthSave, dmcDanger, dcDanger));
            low.Add(findMin(mounthSave, dmcMid, dcDanger));
            low.Add(findMin(mounthSave, dmcSave, dcDanger));

            low.Add(findMin(mounthSave, dmcDanger, dcMid));
            low.Add(findMin(mounthSave, dmcMid, dcMid));
            veryLow.Add(findMin(mounthSave, dmcSave, dcMid));

            low.Add(findMin(mounthSave, dmcDanger, dcSave));
            veryLow.Add(findMin(mounthSave, dmcMid, dcSave));
            veryLow.Add(findMin(mounthSave, dmcSave, dcSave));

            veryDangerResult = veryDanger.Max();
            dangerResult = danger.Max();
            midResult = mid.Max();
            lowResult = low.Max();
            veryLowResult = veryLow.Max();
        }

        private double findMin(double a, double b, double c)
        {
            if (a <= b && a <= c)
                return a;
            if (c <= b && c <= a)
                return c;
            if (b <= a && b <= c)
                return b;
            else
            {
                throw new Exception();
            }
        }

        private void implicationMin(List<double> list, double impVar)
        {
            foreach (var tmp in list)
            {
                if (impVar.Equals(default(double)))
                {
                    impVar = tmp;
                }
                else
                {
                    impVar *= tmp;
                }
            }
        }
    }
}
