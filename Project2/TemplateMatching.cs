using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class TemplateMatching : Form
    {
        Bitmap objBitmap1;

        int[] pektor = new int[10000];

        int[] jar = new int[10];

        int i, j, k, p, x, y, h;

        private void back(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManualTemplate button1 = new ManualTemplate();
            button1.Show();
            this.Close();
        }

        char[] hurup = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        Bitmap[] data = new Bitmap[36];

        //matriks acuan citra huruf A s/d J, per huruf dalam satu vektor

        int[][] acuan = new int[10][];
        
        public TemplateMatching()
        {
            int i = 0;
            InitializeComponent();
            foreach (String image in Directory.GetFiles(@"D:\Data Kuliah\SMT 4\Pencitraan\100x100"))
            {
                data[i] = new Bitmap(Image.FromFile(image));
                h = 0;
                acuan[i] = new int[data[i].Width * data[i].Height];
                for (x = 0; x < data[i].Width; x++)
                {
                    for (y = 0; y < data[i].Height; y++)
                    {
                        Color w = data[i].GetPixel(x, y);
                        int wr = w.R;
                        int wg = w.G;
                        int wb = w.B;
                        int c = (int)((wr + wg + wb) / 3);

                        if (c > 127)
                            c = 0;
                        else
                            c = 255;

                        c = (int)c / 255;
                        acuan[i][h] = c;
                        h = h + 1;
                    }
                }
                i++;
            }
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            this.CenterToParent();
        }

        private void Load(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();

            if (d == DialogResult.OK)

            {

                objBitmap1 = new Bitmap(openFileDialog1.FileName);

                pictureBox1.Image = objBitmap1;

            }
        }

        private void Recognisi(object sender, EventArgs e)
        {
            h = 0;
            for (x = 0; x < objBitmap1.Width; x++)
            {
                for (y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int wr = w.R;
                    int wg = w.G;
                    int wb = w.B;
                    int c = (int)((wr + wg + wb) / 3);

                    if (c > 127)
                        c = 0;
                    else
                        c = 255;

                    c = (int)c / 255;
                    pektor[h] = c;
                    h = h + 1;
                }
            }

            //cetak matriks citra huruf baru(100 x 100)

            for (j = 0; j < 10; j++)
            {
                jar[j] = 0;
                for (k = 0; k < 10000; k++)
                    jar[j] = jar[j] + Math.Abs(acuan[j][k] - pektor[k]);
            }

            //cetak jarak citra huruf baru dengan vektor acuan

            int minim = jar[0];
            for (i = 1; i < 10; i++)
            {
                if (jar[i] < minim)
                    minim = jar[i];
            }

            for (i = 0; i < 10; i++)
            {
                if (jar[i] == minim)
                {
                    p = i;
                    break;
                }
            }

            label2.Text = p.ToString();
            label3.Text = hurup[p].ToString();

            label2.Visible = true;
            label3.Visible = true;
            label1.Visible = true;
        }
    }
}
