using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Msagl;

namespace gui_stima_2
{
    public partial class Form1 : Form
    {
        Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        Microsoft.Msagl.Drawing.Graph graf;

        public Form1()
        {
            gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            graf = new Microsoft.Msagl.Drawing.Graph("Graph");

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel_home.Visible = false;
            panel_file.Visible = true;
            panel_hasil.Visible = false;
        }

        private void panel_msagl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_file.Visible = false;
            panel_hasil.Visible = false;
        }

        private void next_to_hasil_Click(object sender, EventArgs e)
        {
            panel_home.Visible = false;
            panel_file.Visible = false;
            panel_hasil.Visible = true;

            City.importCity(label9.Text);
            CityLogistic.ImportLogistic(label8.Text);
            foreach (KeyValuePair<String,List<String>> a in CityLogistic.cityEdge)
            {
                Console.WriteLine(a.Key);
                foreach(String b in a.Value)
                {
                    Console.WriteLine("-" + b);
                    graf.AddEdge(a.Key, b);
                }
            }
            gViewer.Graph = graf;
            this.panel_msagl.Controls.Add(gViewer);
        }

        private void home_2_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_file.Visible = false;
            panel_hasil.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label8.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label9.Text = openFileDialog2.FileName;
            }
        }

        private void button_simulate_Click(object sender, EventArgs e)
        {
            CityLogistic.BFS(comboBox1.SelectedIndex);
            foreach(String a in CityLogistic.infected)
            {
                graf.FindNode(a).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            }
            this.Invoke((MethodInvoker)delegate
            {

                Microsoft.Msagl.Drawing.Graph tmp = gViewer.Graph;
                gViewer.Graph = null;
                gViewer.Graph = tmp; // workarround to force updating
            });
        }
    }
}
