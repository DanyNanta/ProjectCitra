namespace Project2
{
    partial class ColorDetection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.LayerCr = new System.Windows.Forms.Button();
            this.LayerCb = new System.Windows.Forms.Button();
            this.LayerY = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LayerV = new System.Windows.Forms.Button();
            this.LayerS = new System.Windows.Forms.Button();
            this.LayerH = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LayerCr);
            this.panel4.Controls.Add(this.LayerCb);
            this.panel4.Controls.Add(this.LayerY);
            this.panel4.Location = new System.Drawing.Point(12, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 315);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // LayerCr
            // 
            this.LayerCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerCr.Location = new System.Drawing.Point(15, 109);
            this.LayerCr.Name = "LayerCr";
            this.LayerCr.Size = new System.Drawing.Size(116, 33);
            this.LayerCr.TabIndex = 6;
            this.LayerCr.Text = "Layer Cr";
            this.LayerCr.UseVisualStyleBackColor = true;
            this.LayerCr.Click += new System.EventHandler(this.LayerCr_Click);
            // 
            // LayerCb
            // 
            this.LayerCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerCb.Location = new System.Drawing.Point(15, 58);
            this.LayerCb.Name = "LayerCb";
            this.LayerCb.Size = new System.Drawing.Size(116, 33);
            this.LayerCb.TabIndex = 5;
            this.LayerCb.Text = "Layer Cb";
            this.LayerCb.UseVisualStyleBackColor = true;
            this.LayerCb.Click += new System.EventHandler(this.LayerCb_Click);
            // 
            // LayerY
            // 
            this.LayerY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerY.Location = new System.Drawing.Point(15, 6);
            this.LayerY.Name = "LayerY";
            this.LayerY.Size = new System.Drawing.Size(116, 33);
            this.LayerY.TabIndex = 4;
            this.LayerY.Text = "Layer Y";
            this.LayerY.UseVisualStyleBackColor = true;
            this.LayerY.Click += new System.EventHandler(this.LayerY_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 140);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "project";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 56);
            this.label6.TabIndex = 16;
            this.label6.Text = "Citra";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(177, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 427);
            this.panel1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(505, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 33);
            this.button5.TabIndex = 14;
            this.button5.Text = "Menu Utama";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.back);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(261, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "Layer YCbCr";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(139, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Layer HSV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(17, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Layer RGB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(327, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Blue);
            this.panel3.Controls.Add(this.Green);
            this.panel3.Controls.Add(this.Red);
            this.panel3.Location = new System.Drawing.Point(12, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 315);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // Blue
            // 
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(15, 58);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(116, 33);
            this.Blue.TabIndex = 7;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Green
            // 
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.Location = new System.Drawing.Point(15, 109);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(116, 33);
            this.Green.TabIndex = 6;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Red
            // 
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(15, 6);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(116, 33);
            this.Red.TabIndex = 4;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LayerV);
            this.panel7.Controls.Add(this.LayerS);
            this.panel7.Controls.Add(this.LayerH);
            this.panel7.Location = new System.Drawing.Point(12, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 315);
            this.panel7.TabIndex = 11;
            this.panel7.Visible = false;
            // 
            // LayerV
            // 
            this.LayerV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerV.Location = new System.Drawing.Point(15, 109);
            this.LayerV.Name = "LayerV";
            this.LayerV.Size = new System.Drawing.Size(116, 33);
            this.LayerV.TabIndex = 6;
            this.LayerV.Text = "Layer V";
            this.LayerV.UseVisualStyleBackColor = true;
            this.LayerV.Click += new System.EventHandler(this.LayerV_Click);
            // 
            // LayerS
            // 
            this.LayerS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerS.Location = new System.Drawing.Point(15, 58);
            this.LayerS.Name = "LayerS";
            this.LayerS.Size = new System.Drawing.Size(116, 33);
            this.LayerS.TabIndex = 5;
            this.LayerS.Text = "Layer S";
            this.LayerS.UseVisualStyleBackColor = true;
            this.LayerS.Click += new System.EventHandler(this.LayerS_Click);
            // 
            // LayerH
            // 
            this.LayerH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerH.Location = new System.Drawing.Point(15, 6);
            this.LayerH.Name = "LayerH";
            this.LayerH.Size = new System.Drawing.Size(116, 33);
            this.LayerH.TabIndex = 4;
            this.LayerH.Text = "Layer H";
            this.LayerH.UseVisualStyleBackColor = true;
            this.LayerH.Click += new System.EventHandler(this.LayerH_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ColorDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Name = "ColorDetection";
            this.Text = "ColorDetection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorDetection_FormClosing);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button LayerCr;
        private System.Windows.Forms.Button LayerCb;
        private System.Windows.Forms.Button LayerY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button LayerV;
        private System.Windows.Forms.Button LayerS;
        private System.Windows.Forms.Button LayerH;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}