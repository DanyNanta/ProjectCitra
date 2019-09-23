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
    public partial class DetectionTepi : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public DetectionTepi()
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

        private void distance(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            int red = Convert.ToInt32(textBox1.Text);
            int green = Convert.ToInt32(textBox2.Text);
            int blue = Convert.ToInt32(textBox3.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    Color wb;
                    int rata = Math.Abs(r - red) + Math.Abs(g - green) + Math.Abs(b - blue);
                    if (rata < 85)
                    {
                        wb = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        wb = Color.FromArgb(0, 0, 0);
                    }
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void static_click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    Color wb;
                    if (((r > Convert.ToInt32(textBox9.Text)) && (r < Convert.ToInt32(textBox6.Text))) && ((g > Convert.ToInt32(textBox8.Text)) && (g < Convert.ToInt32(textBox5.Text))) && ((b > Convert.ToInt32(textBox7.Text)) && (b < Convert.ToInt32(textBox4.Text))))
                    {
                        wb = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        wb = Color.FromArgb(0, 0, 0);
                    }
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void back(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Close();
        }
    }
}
