namespace gui_stima_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_home = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_hasil = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.Button();
            this.button_simulate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_msagl = new System.Windows.Forms.Panel();
            this.panel_file = new System.Windows.Forms.Panel();
            this.home_2 = new System.Windows.Forms.Button();
            this.next_to_hasil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_hasil.SuspendLayout();
            this.panel_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.Black;
            this.panel_home.Controls.Add(this.label2);
            this.panel_home.Controls.Add(this.start);
            this.panel_home.Controls.Add(this.label4);
            this.panel_home.Controls.Add(this.label3);
            this.panel_home.Controls.Add(this.pictureBox1);
            this.panel_home.Controls.Add(this.label1);
            this.panel_home.Location = new System.Drawing.Point(12, 12);
            this.panel_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1005, 743);
            this.panel_home.TabIndex = 4;
            this.panel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(349, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "M. Rahadian A. P. W. / 13518011";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(440, 677);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(140, 39);
            this.start.TabIndex = 5;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(349, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "David Gozaly / 13518118";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(349, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rakha Fadhilah / 13518097";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(277, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corona Simulator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel_hasil
            // 
            this.panel_hasil.BackColor = System.Drawing.Color.Black;
            this.panel_hasil.Controls.Add(this.home_button);
            this.panel_hasil.Controls.Add(this.button_simulate);
            this.panel_hasil.Controls.Add(this.comboBox1);
            this.panel_hasil.Controls.Add(this.label5);
            this.panel_hasil.Controls.Add(this.panel_msagl);
            this.panel_hasil.Location = new System.Drawing.Point(12, 12);
            this.panel_hasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_hasil.Name = "panel_hasil";
            this.panel_hasil.Size = new System.Drawing.Size(1005, 743);
            this.panel_hasil.TabIndex = 5;
            this.panel_hasil.Visible = false;
            // 
            // home_button
            // 
            this.home_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Location = new System.Drawing.Point(911, 694);
            this.home_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(80, 31);
            this.home_button.TabIndex = 4;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_simulate
            // 
            this.button_simulate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simulate.Location = new System.Drawing.Point(581, 75);
            this.button_simulate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_simulate.Name = "button_simulate";
            this.button_simulate.Size = new System.Drawing.Size(137, 39);
            this.button_simulate.TabIndex = 3;
            this.button_simulate.Text = "Simulate";
            this.button_simulate.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(432, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(271, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jumlah hari :";
            // 
            // panel_msagl
            // 
            this.panel_msagl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_msagl.Location = new System.Drawing.Point(107, 142);
            this.panel_msagl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_msagl.Name = "panel_msagl";
            this.panel_msagl.Size = new System.Drawing.Size(789, 444);
            this.panel_msagl.TabIndex = 0;
            this.panel_msagl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_msagl_Paint);
            // 
            // panel_file
            // 
            this.panel_file.BackColor = System.Drawing.Color.Black;
            this.panel_file.Controls.Add(this.home_2);
            this.panel_file.Controls.Add(this.next_to_hasil);
            this.panel_file.Controls.Add(this.label9);
            this.panel_file.Controls.Add(this.label8);
            this.panel_file.Controls.Add(this.label7);
            this.panel_file.Controls.Add(this.label6);
            this.panel_file.Controls.Add(this.button4);
            this.panel_file.Controls.Add(this.button3);
            this.panel_file.Location = new System.Drawing.Point(12, 12);
            this.panel_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_file.Name = "panel_file";
            this.panel_file.Size = new System.Drawing.Size(1005, 743);
            this.panel_file.TabIndex = 6;
            this.panel_file.Visible = false;
            // 
            // home_2
            // 
            this.home_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_2.Location = new System.Drawing.Point(791, 677);
            this.home_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home_2.Name = "home_2";
            this.home_2.Size = new System.Drawing.Size(97, 48);
            this.home_2.TabIndex = 14;
            this.home_2.Text = "Home";
            this.home_2.UseVisualStyleBackColor = true;
            this.home_2.Click += new System.EventHandler(this.home_2_Click);
            // 
            // next_to_hasil
            // 
            this.next_to_hasil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_to_hasil.Location = new System.Drawing.Point(893, 677);
            this.next_to_hasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next_to_hasil.Name = "next_to_hasil";
            this.next_to_hasil.Size = new System.Drawing.Size(97, 48);
            this.next_to_hasil.TabIndex = 13;
            this.next_to_hasil.Text = "Next";
            this.next_to_hasil.UseVisualStyleBackColor = true;
            this.next_to_hasil.Click += new System.EventHandler(this.next_to_hasil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(407, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "(file populasi yang dipilih)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(407, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "(file peta yang dipilih)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(203, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pilih file populasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(247, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pilih file peta";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 750);
            this.Controls.Add(this.panel_file);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_hasil);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_hasil.ResumeLayout(false);
            this.panel_hasil.PerformLayout();
            this.panel_file.ResumeLayout(false);
            this.panel_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel_hasil;
        private System.Windows.Forms.Panel panel_msagl;
        private System.Windows.Forms.Button button_simulate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel panel_file;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button home_2;
        private System.Windows.Forms.Button next_to_hasil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

