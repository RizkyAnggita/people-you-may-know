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

namespace bacefook
{
    public partial class Form1 : Form
    {
        string fullName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            fullName = "RIZKY";
            //            MessageBox.Show("Hey" + fullName + "!", "Submit botton clicked!", 
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Hey " + fullName + "!\n Are you above 18?", "Age",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Well just close the app");
                this.Close();
            }
        }

        private void labelGraphInput_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Plain text (*.txt) | *.txt";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string readfile = File.ReadAllText(filename);
                richTxtBoxFilename.Text = filename;
                richTxtBoxGraph.Text = readfile;

                Graph g1 = new Graph();
                TxtToGraph(filename, g1);
                string b = g1.PrintGraph();
                richTxtBoxGraph.Text = b;
                g1.visualizedGraph();
            }    
        }
        static void TxtToGraph(string filepath, Graph g)
        {
            StreamReader sr = new StreamReader(filepath);
            string line = sr.ReadLine();
            int i = 0;
            while(line!=null)
            {
                if (i != 0)
                {
                    string[] temp = line.Split(null);
                    g.AddEdge(temp[0], temp[1]);
                    //g.AddEdge(temp[1], temp[0]);

                }
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
        }
    }
}
