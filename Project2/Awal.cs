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
    public partial class Awal : Form
    {
        

        public Awal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDetection cd = new ColorDetection();
            cd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetectionTepi button2 = new DetectionTepi();
            button2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetectionTomat button3 = new DetectionTomat();
            button3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegionMatching button4 = new RegionMatching();
            button4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TemplateMatching button5 = new TemplateMatching();
            button5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Awal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
