using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektPożary
{
    public partial class ResultForm : Form
    {
        private Graphics g;
        private double value= 0;

        public ResultForm(double? veryDanger, double? danger, double? mid, double? low, double? veryLow)
        {
            InitializeComponent();

            Pen pen = new Pen(Color.Black, 3);
            Pen marker;

            pictureBox1.Image = new Bitmap(500, 500);
            g = Graphics.FromImage(pictureBox1.Image);
            var font = new Font("TimeNewRoman", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            var Resultfont = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);

            if (veryDanger != null)
            {
            marker = new Pen(Color.Red, 60);
                value = veryDanger.Value;
                g.DrawString("Bardzo Niebezpiecznie", Resultfont, Brushes.Red, new Point(100, 460));
            }

            else if (danger != null)
            {
                marker = new Pen(Color.Orange, 60);
                value = danger.Value;
                g.DrawString("Niebezpiecznie", Resultfont, Brushes.Orange, new Point(100, 460));
            }

            else if (mid != null)
            {
                marker = new Pen(Color.Yellow, 60);
                value = mid.Value;
                g.DrawString("Umiarkowanie", Resultfont, Brushes.Yellow, new Point(100, 460));
            }

            else if (low != null)
            {
                marker = new Pen(Color.Green, 60);
                value = low.Value;
                g.DrawString("Bezpiecznie", Resultfont, Brushes.Green, new Point(100, 460));
            }

            else if (veryLow != null)
            {
                marker = new Pen(Color.LightBlue, 60);
                value = veryLow.Value;
                g.DrawString("Bardzo Bezpiecznie", Resultfont, Brushes.LightBlue, new Point(100, 460));
            }
            else
            {
                marker = new Pen(Color.White, 15);
            }

            g.DrawLine(pen, 40,20, 40, 420);

            g.DrawLine(pen, 40, 420, 300, 420); //0%
            g.DrawString("0%", font, Brushes.Black, new Point(300,420));
            g.DrawLine(pen, 40, 320, 300, 320); // 25%
            g.DrawString("25%", font, Brushes.Black, new Point(300, 320));
            g.DrawLine(pen, 40, 220, 300, 220); // 50%
            g.DrawString("50%", font, Brushes.Black, new Point(300, 220));
            g.DrawLine(pen, 40, 120, 300, 120); //75%
            g.DrawString("75%", font, Brushes.Black, new Point(300, 120));
            g.DrawLine(pen, 40, 20, 300, 20); // 100%
            g.DrawString("100%", font, Brushes.Black, new Point(300, 20));

            g.DrawLine(marker, 180, (400-((float)value *400))+20, 180, 420);

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
