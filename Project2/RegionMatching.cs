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
    public partial class RegionMatching : Form
    {
        Bitmap objBitmap1;
        int[,] matriks = new int[1000, 1000];
        int[] reg = new int[9];
        int[] jarak = new int[30];
        int i, j, p, x, y;
        char kode;
        char[] hurup = { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'D', 'E', 'E', 'E', 'F', 'F', 'F', 'G', 'G', 'G', 'H', 'H', 'H', 'I', 'I', 'I', 'J', 'J', 'J' };
        //matriks acuan hasil region splitting citra huruf A s/d J, masing-masing 3 huruf
        int[,] acuan = { {11,474,0,281,346,0,411,360,200},
                                   {5,563,16,263,72,262,397,290,350},
                                   {0,538,67,83,450,481,327,31,135},
                                   {417,422,0,443,544,265,368,202,425},
                                   {414,317,170,357,504,353,422,256,439},
                                   {385,356,0,365,599,111,353,130,454},
                                   {304,288,112,296,0,0,362,175,368},
                                   {193,299,158,308,0,0,333,248,267},
                                   {234,299,49,288,0,0,329,275,164},
                                   {431,312,129,279,0,291,398,301,147},
                                   {442,273,286,288,0,288,474,290,311},
                                   {432,300,153,285,0,300,410,279,251},
                                   {453,288,288,448,288,159,438,290,199},
                                   {503,288,163,491,288,181,497,288,218},
                                   {436,288,174,415,288,126,378,288,273},
                                   {408,288,225,449,288,178,264,0,0},
                                   {438,288,181,426,288,127,288,0,0},
                                   {446,276,282,442,285,116,288,0,0},
                                   {276,289,226,369,188,193,417,219,301},
                                   {248,303,127,492,301,252,320,286,293},
                                   {324,288,161,446,289,352,327,289,360},
                                   {289,0,294,449,286,494,249,0,260},
                                   {271,0,271,445,285,438,240,0,288},
                                   {291,0,271,429,288,407,283,0,295},
                                   {8,452,0,0,288,0,5,431,0},
                                   {8,485,55,0,288,0,46,491,4},
                                   {0,449,44,0,272,0,0,389,125},
                                   {0,263,281,0,0,288,0,291,163},
                                   {0,354,58,0,79,181,71,336,89},
                                   {0,384,108,0,0,291,203,267,115}};

        

        public RegionMatching()
        {
            InitializeComponent();
            this.CenterToParent();
            label1.Text = "";
            //cetak matriks acuan citra huruf
            for (i = 0; i < 30; i++)
                for (j = 0; j < 9; j++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[j, i].Value = acuan[i, j].ToString();
                }
        }

        private void back(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            for (x = 0; x < objBitmap1.Width; x++)
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
                    matriks[x, y] = c;
                }

            //membagi memjadi 9 region (3 x 3),counting jumlah pixel hitam per region
            int count = 0; int bb = 0; int ba = 33;
            for (i = 0; i < 3; i++)
            {
                int kb = 0; int ka = 33; int sum = 0;
                for (j = 0; j < 3; j++)
                {
                    for (x = bb; x < ba; x++)
                        for (y = kb; y < ka; y++)
                            sum = sum + matriks[y, x];
                    reg[count] = sum;
                    kb = ka + 1;
                    ka = ka + 33;
                    count = count + 1;
                    sum = 0;
                }
                bb = ba + 1;
                ba = ba + 33;
            }

            //cetak vektor region dari citra huruf baru(1 x 9)
            for (i = 0; i < 9; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3[0, i].Value = reg[i].ToString();
            }

            for (i = 0; i < 30; i++)
            {
                jarak[i] = 0;
                for (j = 0; j < 9; j++)
                    jarak[i] = jarak[i] + ((reg[j] - acuan[i, j]) * (reg[j] - acuan[i, j]));
            }
            int minim = jarak[0];
            for (i = 1; i < 30; i++)
            {
                if (jarak[i] < minim)
                    minim = jarak[i];
            }

            //cetak jarak citra huruf baru dengan vektor acuan
            for (i = 0; i < 30; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2[0, i].Value = jarak[i].ToString();
            }

            for (i = 0; i < 30; i++)
            {
                if (jarak[i] == minim)
                {
                    p = i;
                    break;
                }
            }
            char kar = 'A';
            textBox1.Text = p.ToString();
            label1.Text = hurup[p].ToString();
        }

        private void pertama(object sender, EventArgs e)
        {
            
        }
    }
}
