using System;
using System.Collections;
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

        static void FriendRecommendation(Graph g, string account, string algoritma)
        {
            Dictionary<string, ArrayList> result = g.GetMutualFriend(account, algoritma);
            result = result.OrderBy(entry => -1 * entry.Value.Count).ToDictionary(entry => entry.Key, entry => entry.Value);

            foreach (KeyValuePair<string, ArrayList> pair in result)
            {

                Console.Write(pair.Key);
                Console.Write("\n");

                Console.Write(pair.Value.Count);
                Console.Write(" Mutual Friends ");

                if (pair.Value.Count != 0)
                {
                    Console.Write(": ");
                }


                foreach (string n in pair.Value)
                {
                    Console.Write(n);
                    Console.Write(" ");
                }

                Console.WriteLine("\n");

            }
        }

        static void ExploreFriends(string friendA, string friendB, Graph g, string algorithm)
        {
            Console.WriteLine("\nNama akun: " + friendA + " dan " + friendB);
            if (algorithm == "BFS")
            {
                Console.WriteLine("Explore Friend with BFS");
                Dictionary<string, int> distance = new Dictionary<string, int>();
                Dictionary<string, string> predPath = new Dictionary<string, string>();

                //Tidak ketemu friendB
                if (!g.BFS2(friendA, friendB, ref distance, ref predPath))
                {
                    Console.WriteLine("Tidak ada jalur koneksi yang tersedia.\nAnda harus memulai koneksi baru itu sendiri.");
                    return;
                }

                //Ketemu friendB

                List<string> path = new List<string>();
                string before = friendB;
                path.Add(before);

                //Me
                while (predPath[before] != null)
                {
                    path.Add(predPath[before]);
                    before = predPath[before];
                }
                Console.WriteLine();
                Console.WriteLine(distance[friendB] - 1 + "th-degree connection");
                for (int i = path.Count - 1; i >= 0; i--)
                {
                    Console.Write(path[i]);
                    if (i != 0)
                    {
                        Console.Write("->");
                    }
                }
                Console.WriteLine();

            }
            else if (algorithm == "DFS")
            {
                Console.WriteLine("\nExplore Friend with DFS");
                g.DFSIterative(friendA, friendB);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("False");
            }


        }

        private void radioButton_DFS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
