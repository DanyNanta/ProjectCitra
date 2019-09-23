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
    public partial class ColorDetection : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public ColorDetection()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void Load(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap;
            }
        }
        private Bitmap layerRGB(Bitmap obj, String layer)
        {
            Color wb;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    if (layer.Equals("red"))
                    {
                        int r = w.R;
                        wb = Color.FromArgb(r, 0, 0);
                        obj.SetPixel(x, y, wb);
                    }
                    else if (layer.Equals("green"))
                    {
                        int g = w.G;
                        wb = Color.FromArgb(0, g, 0);
                        obj.SetPixel(x, y, wb);
                    }
                    else if (layer.Equals("blue"))
                    {
                        int b = w.B;
                        wb = Color.FromArgb(0, 0, b);
                        obj.SetPixel(x, y, wb);
                    }
                }
            return obj;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerRGB(objBitmap1, "red");
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerRGB(objBitmap1, "blue");
        }

        private void Green_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerRGB(objBitmap1, "green");
        }

        private void back(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == true)
            {
                panel7.Visible = false;
            }
            else
            {
                panel7.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private Bitmap layerHSV(Bitmap obj, char layer)
        {
            Color c, newc;
            double hue, saturation, value;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    c = objBitmap.GetPixel(x, y);
                    int max = Math.Max(c.R, Math.Max(c.G, c.B));
                    int min = Math.Min(c.R, Math.Min(c.G, c.B));

                    hue = c.GetHue();
                    saturation = (max == 0) ? 0 : 1d - (1d * min / max);
                    value = max / 255d;
                    if (layer == 'h')
                    {
                        saturation = 0.75;
                        value = 0.75;
                    }
                    else if (layer == 's')
                    {
                        hue = 0.75 * 360;
                        value = 0.75;
                    }
                    else if (layer == 'v')
                    {
                        hue = 0.75 * 360;
                        saturation = 0.75;
                    }

                    int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
                    double f = hue / 60 - Math.Floor(hue / 60);
                    value = value * 255;
                    int v = Convert.ToInt32(value);
                    int p = Convert.ToInt32(value * (1 - saturation));
                    int q = Convert.ToInt32(value * (1 - f * saturation));
                    int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));
                    if (hi == 0)
                        newc = Color.FromArgb(255, v, t, p);
                    else if (hi == 1)
                        newc = Color.FromArgb(255, q, v, p);
                    else if (hi == 2)
                        newc = Color.FromArgb(255, p, v, t);
                    else if (hi == 3)
                        newc = Color.FromArgb(255, p, q, v);
                    else if (hi == 4)
                        newc = Color.FromArgb(255, t, p, v);
                    else
                        newc = Color.FromArgb(255, v, p, q);
                    obj.SetPixel(x, y, newc);
                }
            return obj;
        }

        private void LayerH_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerHSV(objBitmap1, 'h');
        }

        private void LayerS_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerHSV(objBitmap1, 's');
        }

        private void LayerV_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerHSV(objBitmap1, 'v');
        }

        private Bitmap layerYeCbCr(Bitmap obj, String layer)
        {
            Color c, newc;
            double ye, cb, cr;
            float r, g, b;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    c = objBitmap.GetPixel(x, y);
                    ye = 0.2989d * c.R + 0.5866d * c.G + 0.1145d * c.B;
                    cb = -0.1688d * c.R - 0.3312d * c.G + 0.5000d * c.B;
                    cr = 0.5000d * c.R - 0.4184d * c.G - 0.0816d * c.B;
                    if (layer == "ye")
                    {
                        cb = 0;
                        cr = 0;
                    }
                    else if (layer == "cb")
                    {
                        ye = 0;
                        cr = 0;
                    }
                    else if (layer == "cr")
                    {
                        ye = 0;
                        cb = 0;
                    }

                    r = Math.Max(0.0f, Math.Min(1.0f, (float)(ye
                    + 0.0000 * cb + 1.4022 * cr)));
                    g = Math.Max(0.0f, Math.Min(1.0f, (float)(ye
                    - 0.3456 * cb - 0.7145 * cr)));
                    b = Math.Max(0.0f, Math.Min(1.0f, (float)(ye
                    + 1.7710 * cb + 0.0000 * cr)));
                    newc = Color.FromArgb((byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
                    obj.SetPixel(x, y, newc);
                }
            return obj;
        }

        private void LayerY_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerYeCbCr(objBitmap1, "ye");
        }

        private void LayerCb_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerYeCbCr(objBitmap1, "cb");
        }

        private void LayerCr_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            pictureBox2.Image = layerYeCbCr(objBitmap1, "cr");
        }

        private void ColorDetection_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
