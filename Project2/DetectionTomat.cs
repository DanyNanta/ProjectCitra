using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class DetectionTomat : Form
    {
        private Bitmap objBitmap;
        private Bitmap objBitmap2;
        private Bitmap objBitmap3;
        private Bitmap objBitmap1;
        private float[][] h = new float[4][];
        private float[][] hb = new float[4][];
        private float[] gn = new float[768];
        private Bitmap objBitmap4;

        public DetectionTomat()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = objBitmap2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap3 = new Bitmap(openFileDialog1.FileName);
                pictureBox3.Image = objBitmap3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            h[0] = new float[768];
            int i;
            for (i = 0; i < 768; i++) h[0][i] = 0;
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    h[0][r] = h[0][r] + 1;
                    h[0][256 + g] = h[0][256 + g] + 1;
                    h[0][512 + b] = h[0][512 + b] + 1;
                }

            chart1.Series["Series1"].Points.Clear();
            for (i = 0; i < 768; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[0][i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h[1] = new float[768];
            int i;
            for (i = 0; i < 768; i++) h[1][i] = 0;
            for (int x = 0; x < objBitmap2.Width; x++)
                for (int y = 0; y < objBitmap2.Height; y++)
                {
                    Color w = objBitmap2.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    h[1][r] = h[1][r] + 1;
                    h[1][256 + g] = h[1][256 + g] + 1;
                    h[1][512 + b] = h[1][512 + b] + 1;
                }

            chart2.Series["Series1"].Points.Clear();
            for (i = 0; i < 768; i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, h[1][i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h[2] = new float[768];
            int i;
            for (i = 0; i < 768; i++) h[2][i] = 0;
            for (int x = 0; x < objBitmap3.Width; x++)
                for (int y = 0; y < objBitmap3.Height; y++)
                {
                    Color w = objBitmap3.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    h[2][r] = h[2][r] + 1;
                    h[2][256 + g] = h[2][256 + g] + 1;
                    h[2][512 + b] = h[2][512 + b] + 1;
                }

            chart3.Series["Series1"].Points.Clear();
            for (i = 0; i < 768; i++)
            {
                chart3.Series["Series1"].Points.AddXY(i, h[2][i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            hb[0] = new float[768];
            for (int i = 0; i < 768; i++)
            {
                hb[0][i] = 0;
                hb[0][i] = Math.Abs(h[0][i] - gn[i]);
                chart1.Series["Series1"].Points.AddXY(i, hb[0][i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            hb[1] = new float[768];
            for (int i = 0; i < 768; i++)
            {
                hb[1][i] = 0;
                hb[1][i] = Math.Abs(h[1][i] - gn[i]);
                chart2.Series["Series1"].Points.AddXY(i, hb[1][i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chart3.Series["Series1"].Points.Clear();
            hb[2] = new float[768];
            for (int i = 0; i < 768; i++)
            {
                hb[2][i] = 0;
                hb[2][i] = Math.Abs(h[2][i] - gn[i]);
                chart3.Series["Series1"].Points.AddXY(i, hb[2][i]);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 768; i++)
            {
                gn[i] = h[0][i];
                if (h[1][i] < gn[i]) gn[i] = h[1][i];
                if (h[2][i] < gn[i]) gn[i] = h[2][i];
            }
            for (int i = 0; i < 768; i++)
            {
                chart4.Series["Series1"].Points.AddXY(i, gn[i]);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap4 = new Bitmap(openFileDialog1.FileName);
                pictureBox4.Image = objBitmap4;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            h[3] = new float[768];
            int i;
            for (i = 0; i < 768; i++) h[3][i] = 0;
            for (int x = 0; x < objBitmap4.Width; x++)
                for (int y = 0; y < objBitmap4.Height; y++)
                {
                    Color w = objBitmap4.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    h[3][r] = h[3][r] + 1;
                    h[3][256 + g] = h[3][256 + g] + 1;
                    h[3][512 + b] = h[3][512 + b] + 1;
                }

            chart5.Series["Series1"].Points.Clear();
            for (i = 0; i < 768; i++)
            {
                chart5.Series["Series1"].Points.AddXY(i, h[3][i]);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chart5.Series["Series1"].Points.Clear();
            hb[3] = new float[768];
            for (int i = 0; i < 768; i++)
            {
                hb[3][i] = 0;
                hb[3][i] = Math.Abs(h[3][i] - gn[i]);
                chart5.Series["Series1"].Points.AddXY(i, hb[3][i]);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            float[] d = new float[3];
            float di = 0;
            for (int i = 0; i < 3; i++)
            {
                di = 0;
                d[i] = 0;
                for (int j = 0; j < 768; j++)
                    di = di + Math.Abs(hb[3][j] - hb[i][j]);
                di = di / 768;
                d[i] = di;

            }
            label2.Text = "" + d[0];
            label3.Text = "" + d[1];
            label4.Text = "" + d[2];

            if ((d[0] < d[1]) && (d[0] < d[2]))
            {
                label1.Text = "HIJAU";
            }
            if ((d[1] < d[0]) && (d[1] < d[2]))
            {
                label1.Text = "MERAH";
            }
            if ((d[2] < d[0]) && (d[2] < d[1]))
            {
                label1.Text = "CAMPURAN";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Close();
        }
    }
}
