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
        string filename;
        string readfile;
        string algorithm;
        string selectedA = "";
        string selectedB = "";
        Graph g1 = new Graph();
        public Form1()
        {
            InitializeComponent();
            comboBox_chooseAccount.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox_exploreFriends.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioButton_BFS.Checked == false && radioButton_DFS.Checked == false)
            {
                MessageBox.Show("Algoritma belum dipilih!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (selectedA == "" || selectedB == "")
                {
                    MessageBox.Show("Choose account atau Explore Friend with belum dipilih!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String hasil = ExploreFriends(selectedA, selectedB, g1, algorithm);
                    hasil += "\nFriend Recommendation\n";
                    hasil += FriendRecommendation(g1, selectedA, algorithm);
                    richTextBoxHasil.Text = hasil;
                    g1.visualizedGraph(selectedA, selectedB, algorithm);
                }
            }

        }

        private void radioButton_DFS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_DFS.Checked)
            {
                algorithm = "DFS";
            }
        }
        private void radioButton_BFS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_BFS.Checked)
            {
                algorithm = "BFS";
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            g1 = new Graph();
            openFileDialog1.Filter = "Plain text (*.txt) | *.txt";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                readfile = File.ReadAllText(filename);
                richTxtBoxFilename.Text = filename;
                richTxtBoxGraph.Text = readfile;

                TxtToGraph(filename, g1);
                string b = g1.PrintGraph();
                b += algorithm;
                richTxtBoxGraph.Text = b;
                comboBox_exploreFriends.Items.Clear();
                comboBox_chooseAccount.Items.Clear();
                foreach (string node in g1.nodes)
                {
                    comboBox_exploreFriends.Items.Add(node);
                    comboBox_chooseAccount.Items.Add(node);


                }
            }
        }

        private void richTxtBoxGraph_TextChanged(object sender, EventArgs e)
        {
            string b = g1.PrintGraph();
            b += algorithm;
            richTxtBoxGraph.Text = b;
        }

        private void comboBox_chooseAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedA = this.comboBox_chooseAccount.GetItemText(this.comboBox_chooseAccount.SelectedItem);
        }

        private void comboBox_exploreFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedB = comboBox_exploreFriends.GetItemText(comboBox_exploreFriends.SelectedItem);
        }

        static void TxtToGraph(string filepath, Graph g)
        {
            StreamReader sr = new StreamReader(filepath);
            string line = sr.ReadLine();
            int i = 0;
            while (line != null)
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

        static String FriendRecommendation(Graph g, string account, string algoritma)
        {
            String stringResult = "";
            Dictionary<string, ArrayList> result = g.GetMutualFriend(account, algoritma);
            result = result.OrderBy(entry => -1 * entry.Value.Count).ToDictionary(entry => entry.Key, entry => entry.Value);

            foreach (KeyValuePair<string, ArrayList> pair in result)
            {
                if (pair.Value.Count != 0)
                {
                    stringResult += (pair.Key);
                    stringResult += ("\n");

                    stringResult += (pair.Value.Count);
                    stringResult += (" Mutual Friends : ");


                    foreach (string n in pair.Value)
                    {
                        stringResult += (n);
                        stringResult += (" ");
                    }

                    stringResult += ("\n\n");
                }

            }

            return stringResult;
        }

        static String ExploreFriends(string friendA, string friendB, Graph g, string algorithm)
        {
            String hasil = "";
            hasil += ("Nama akun: " + friendA + " dan " + friendB + "\n");
            if (algorithm == "BFS")
            {
                hasil += ("Explore Friend with BFS\n");
                Dictionary<string, int> distance = new Dictionary<string, int>();
                Dictionary<string, string> predPath = new Dictionary<string, string>();

                //Tidak ketemu friendB
                if (!g.BFS2(friendA, friendB, ref distance, ref predPath))
                {
                    hasil += ("Tidak ada jalur koneksi yang tersedia.\nAnda harus memulai koneksi baru itu sendiri.");
                    return hasil;
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
                hasil += "\n";
                hasil += distance[friendB] - 1 + "th-degree connection\n";
                for (int i = path.Count - 1; i >= 0; i--)
                {
                    hasil += path[i];
                    if (i != 0)
                    {
                        hasil += ("->");
                    }
                }
                hasil += "\n";
                return hasil;

            }
            else if (algorithm == "DFS")
            {
                List<string> pathRet = new List<string>();
                hasil += ("Explore Friend with DFS\n");
                hasil += g.DFSIterativeString(friendA, friendB, ref pathRet);
                hasil += "\n";
                return hasil;

            }
            else
            {
                hasil += ("False");
                return hasil;
            }
        }
    }
}
