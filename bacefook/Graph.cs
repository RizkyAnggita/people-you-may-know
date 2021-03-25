using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace bacefook
{
    public class Graph
    {
        //Attribute
        private ArrayList nodes;
        private Dictionary<string, ArrayList> adj;

        //Method
        public Graph() //ctor
        {
            this.nodes = new ArrayList();
            this.adj = new Dictionary<string, ArrayList>();
        }

        public void AddNode(string nodeA)
        {
            this.nodes.Add(nodeA);
            this.adj.Add(nodeA, new ArrayList());
        }

        public void AddEdge(string nodeA, string nodeB)
        {
            if (!nodes.Contains(nodeA))
            {
                AddNode(nodeA);
            }
            if (!nodes.Contains(nodeB))
            {
                AddNode(nodeB);
            }
            this.adj[nodeA].Add(nodeB);
            this.adj[nodeB].Add(nodeA);
            this.adj[nodeA].Sort();
            this.adj[nodeB].Sort();

        }

        public int CountDegree(string nodeA)
        {
            return this.adj[nodeA].Count;
        }

        public void DelNode(string nodeA)
        {

            foreach (KeyValuePair<string, ArrayList> node in this.adj)
            {
                node.Value.Remove(nodeA);
            }
            this.adj.Remove(nodeA);
            this.nodes.Remove(nodeA);
        }

        public String PrintGraph()
        {
            String graph="";
            //Console.WriteLine("Graph");
            foreach (KeyValuePair<string, ArrayList> node in this.adj)
            {
                graph += node.Key + ": ";
                foreach (string adjnode in node.Value)
                {
                    graph += adjnode + " ";
                }
                graph += "\n";
            }
            return graph;
        }

        public void BFS(string startNode, string finalNode)
        {
            if (!this.nodes.Contains(startNode))
            {
                Console.WriteLine("Start Node tidak dapat ditemukan!");
                return;
            }

            Queue<string> livingNode = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            foreach (string node in this.nodes)
            {
                visited[node] = false;

            }

            Console.Write("BFS : " + startNode + " ");
            visited[startNode] = true;
            livingNode.Enqueue(startNode);

            while (livingNode.Count != 0)
            {
                string temp = livingNode.Dequeue();
                foreach (string adjnode in this.adj[temp])
                {
                    if (!visited[adjnode])
                    {
                        Console.Write(adjnode + " ");
                        livingNode.Enqueue(adjnode);
                        visited[adjnode] = true;
                    }
                }
            }

        }

        public bool BFS2(string startNode, string finalNode, ref Dictionary<string, int> distance, ref Dictionary<string, string> predPath)
        {

            if (!this.nodes.Contains(startNode))
            {
                Console.WriteLine("Start Node tidak dapat ditemukan!");
                return false;
            }

            Queue<string> livingNode = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            foreach (string node in this.nodes)
            {
                visited[node] = false;
                distance[node] = 999;     //set to infinity
                predPath[node] = null;
            }

            visited[startNode] = true;
            distance[startNode] = 0;
            livingNode.Enqueue(startNode);

            while (livingNode.Count != 0)
            {
                string temp = livingNode.Dequeue();
                foreach (string adjnode in this.adj[temp])
                {
                    if (!visited[adjnode])
                    {
                        livingNode.Enqueue(adjnode);
                        visited[adjnode] = true;
                        distance[adjnode] = distance[temp] + 1;
                        predPath[adjnode] = temp;

                        if (adjnode == finalNode)
                        {
                            return true;
                        }
                    }
                }
            }
            Console.WriteLine("\nFinal node tidak dapat ditemukan!");
            return false;
        }

        public void DFS(string startNode, string finalNode)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (string node in this.nodes)
            {
                visited[node] = false;

            }
            Console.Write("\nDFS: ");
            DFSRecursive(startNode, finalNode, ref visited);

            void DFSRecursive(string startNode, string finalNode, ref Dictionary<string, bool> visited)
            {
                visited[startNode] = true;
                Console.Write(startNode + " ");

                foreach (string adjnode in this.adj[startNode])
                {
                    if (!visited[adjnode])
                    {
                        //if (adjnode == finalNode)
                        //{
                        //    return;
                        //}
                        DFSRecursive(adjnode, finalNode, ref visited);
                    }
                }
            }

        }


        public void DFSIterative(string startNode, string FinalNode)
        {
            Stack<string> s = new Stack<string>();
            Stack<string> path = new Stack<string>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Dictionary<string, ArrayList> adjtemp = new Dictionary<string, ArrayList>();
            Dictionary<string, int> distance = new Dictionary<string, int>();
            bool found = false;
            string trash;
            int i;
            string v;

            bool IsAllNodeVisited(Dictionary<string, bool> visited)
            {
                foreach (bool visit in visited.Values)
                {
                    if (visit == false)
                    {
                        return false;
                    }
                }
                return true;
            }

            foreach (string node in this.nodes)
            {
                visited[node] = false;
                distance[node] = 1000;
            }

            s.Push(startNode);
            visited[startNode] = true;
            distance[startNode] = 0;

            while (s.Count != 0 && !IsAllNodeVisited(visited))
            {
                v = s.Pop();
                visited[v] = true;
                i = 0;

                //Untuk mengatur urutan stack yang dipush (yang lebih besar dipush lebih awal)
                adjtemp[v] = this.adj[v];
                adjtemp[v].Reverse();

                int min = distance[v];

                //Untuk menghitung shortest path tiap node dari startNode
                foreach (string adjnode in this.adj[v])
                {

                    if (distance[adjnode] < min)
                    {
                        min = distance[adjnode] + 1;
                    }
                }
                distance[v] = min;

                //Ketemu finalNode
                if (v == FinalNode)
                {
                    s.Push(v);
                    path.Push(v);
                    found = true;
                    this.adj[v].Reverse();
                    break;
                }

                //Untuk setiap node yang bertetangga, jika belum dikunjungi, maka kunjungi 
                foreach (string adjnode in adjtemp[v])
                {
                    if (!visited[adjnode])
                    {
                        if (!s.Contains(adjnode))
                        {
                            distance[adjnode] = distance[v] + 1;
                        }
                        s.Push(adjnode);
                        i++;
                    }
                }

                //Jika i=0, maka node v tidak memiliki tetangga yang belum dikunjungi
                //sehingga tidak ada yg dipush, berarti mentok -> backtrack
                if (i == 0)
                {
                    if (path.Contains(v))
                    //Jika terdapat v pada path, maka v harus dipop karena bukan solusi
                    {
                        trash = path.Pop();
                    }
                    else
                    {
                        //Jika tidak terdapat v pada path, maka kunjungi kembali node yang dikunjungi sebelum v
                        //yaitu top pada stack path
                        s.Push(path.Peek());
                    }
                }
                else
                {
                    if (!path.Contains(v))
                    {
                        //Push node v ke path (stack of solusi)
                        path.Push(v);

                    }
                }
                //Reverse kembali urutan node
                this.adj[v].Reverse();
            }

            if (!found)
            {
                Console.WriteLine("Tidak ada jalur koneksi yang tersedia.\nAnda harus memulai koneksi baru itu sendiri.");
            }
            else
            {
                Console.WriteLine(distance[FinalNode] - 1 + "th-degree connection");
                ArrayList pathList = new ArrayList();
                foreach (string node in path)
                {
                    //Console.Write(node + " ");
                    pathList.Add(node);
                }
                for (i = pathList.Count - 1; i >= 0; i--)
                {
                    Console.Write(pathList[i]);
                    if (i != 0)
                    {
                        Console.Write("->");
                    }
                }

            }

            Console.WriteLine();
            //Untuk mencetak jarak sebuah node dari titik asal
            //foreach (KeyValuePair<string, int> dist in distance)
            //{
            //    Console.WriteLine(dist.Key + ":" + dist.Value);
            //}

        }

        public void visualizedGraph()
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content
            foreach (string node in this.nodes)
            {
                foreach (string adjnode in this.adj[node])
                {
                    graph.AddEdge(node, adjnode);
                }
            }
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }

        public Dictionary<string, ArrayList> GetMutualFriend(string startNode, string algoritma)
        {
            Dictionary<string, ArrayList> mutualFriendResult = new Dictionary<string, ArrayList>();


            Dictionary<string, ArrayList> nodesDepth1;

            if (Equals(algoritma, "bfs"))
            {
                nodesDepth1 = BFSFindNodeWithDepth(1);
            }
            else
            {
                nodesDepth1 = DFSFindNodeWithDepth(1);
            }

            foreach (string node in nodes)
            {
                if (!Equals(startNode, node) && !nodesDepth1[startNode].Contains(node))
                {
                    ArrayList mutualFriendsTemp = new ArrayList();
                    foreach (string n in nodesDepth1[node])
                    {
                        if (nodesDepth1[startNode].Contains(n))
                        {
                            mutualFriendsTemp.Add(n);
                        }
                    }

                    mutualFriendResult.Add(node, mutualFriendsTemp);
                }
            }

            return mutualFriendResult;
        }

        public Dictionary<string, ArrayList> BFSFindNodeWithDepth(int depth)
        {
            Dictionary<string, ArrayList> result = new Dictionary<string, ArrayList>();

            foreach (string node in nodes)
            {
                ArrayList adjNodeArray = new ArrayList();

                foreach (string n in nodes)
                {
                    Dictionary<string, int> distance = new Dictionary<string, int>();
                    Dictionary<string, string> predPath = new Dictionary<string, string>();

                    BFS2(node, n, ref distance, ref predPath);

                    int distanceTemp = distance[n];

                    if (distanceTemp == depth)
                    {
                        adjNodeArray.Add(n);
                    }
                }

                result.Add(node, adjNodeArray);
            }

            return result;
        }

        public Dictionary<string, ArrayList> DFSFindNodeWithDepth(int depth)
        {
            Dictionary<string, ArrayList> result = new Dictionary<string, ArrayList>();

            foreach (string node in nodes)
            {
                ArrayList adjNodeArray = new ArrayList();

                foreach (string n in nodes)
                {
                    int distanceTemp = DFSFindDepth(node, n);

                    if (distanceTemp == depth)
                    {
                        adjNodeArray.Add(n);
                    }
                }

                result.Add(node, adjNodeArray);
            }

            return result;
        }

        public int DFSFindDepth(string startNode, string FinalNode)
        {
            Stack<string> s = new Stack<string>();
            Stack<string> path = new Stack<string>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Dictionary<string, ArrayList> adjtemp = new Dictionary<string, ArrayList>();
            Dictionary<string, int> distance = new Dictionary<string, int>();
            bool found = false;
            string trash;
            int i;
            string v;

            bool IsAllNodeVisited(Dictionary<string, bool> visitedParam)
            {
                foreach (bool visit in visitedParam.Values)
                {
                    if (visit == false)
                    {
                        return false;
                    }
                }
                return true;
            }

            foreach (string node in nodes)
            {
                visited[node] = false;
                distance[node] = 1000;
            }

            s.Push(startNode);
            visited[startNode] = true;
            distance[startNode] = 0;

            while (s.Count != 0 && !IsAllNodeVisited(visited))
            {
                v = s.Pop();
                visited[v] = true;
                i = 0;

                //Untuk mengatur urutan stack yang dipush (yang lebih besar dipush lebih awal)
                adjtemp[v] = adj[v];
                adjtemp[v].Reverse();

                int min = distance[v];

                //Untuk menghitung shortest path tiap node dari startNode
                foreach (string adjnode in adj[v])
                {

                    if (distance[adjnode] < min)
                    {
                        min = distance[adjnode] + 1;
                    }
                }
                distance[v] = min;

                //Ketemu finalNode
                if (v == FinalNode)
                {
                    s.Push(v);
                    path.Push(v);
                    found = true;
                    adj[v].Reverse();
                    break;
                }

                //Untuk setiap node yang bertetangga, jika belum dikunjungi, maka kunjungi 
                foreach (string adjnode in adjtemp[v])
                {
                    if (!visited[adjnode])
                    {
                        if (!s.Contains(adjnode))
                        {
                            distance[adjnode] = distance[v] + 1;
                        }
                        s.Push(adjnode);
                        i++;
                    }
                }

                //Jika i=0, maka node v tidak memiliki tetangga yang belum dikunjungi
                //sehingga tidak ada yg dipush, berarti mentok -> backtrack
                if (i == 0)
                {
                    if (path.Contains(v))
                    //Jika terdapat v pada path, maka v harus dipop karena bukan solusi
                    {
                        trash = path.Pop();
                    }
                    else
                    {
                        //Jika tidak terdapat v pada path, maka kunjungi kembali node yang dikunjungi sebelum v
                        //yaitu top pada stack path
                        s.Push(path.Peek());
                    }
                }
                else
                {
                    if (!path.Contains(v))
                    {
                        //Push node v ke path (stack of solusi)
                        path.Push(v);

                    }
                }
                //Reverse kembali urutan node
                adj[v].Reverse();
            }

            return distance[FinalNode];
        }

        ~Graph()
        {
            //Destructor
        }
    }
}