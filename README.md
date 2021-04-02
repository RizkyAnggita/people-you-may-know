# IF2211 - Algorithm Strategy: <br> Application of the BFS and DFS Algorithms in the People You May Know Facebook Social Network Feature

## Description
A simple Windows Form Application with C# that can model some of the features of People You May Know in social media networks (Social Network). By utilizing the Breadth First Search (BFS) and Depth First Search (DFS) algorithms, you can browse social networks on your Facebook account to get friend recommendations such as the People You May Know feature. In addition to getting friend recommendations, you can also view Friend Recommendations so that two accounts that are not friends and do not have mutual friends at all can get acquainted through certain channels.
The application will also visualize the graph and the path between two accounts using MSAGL .NET library

## Overview of DFS and BFS
Traversal Graf, BFS, DFS <br>
Graph is a representation of a problem, while graph traversal is a search for a solution to the problem. Graph traversal algorithm is visiting vertices in a systematic way. Graph traversal algorithms are divided into two types:
 
Breadth First Search (BFS) <br>
Breadth First Search is a search that is done in a wide range. Suppose the traversal starts from vertex v, then the BFS algorithm is as follows:
Visit vertex v.
Visit all neighboring vertices with vertex v first.
Visit the vertices that have not been visited and are neighboring with the previously visited nodes, and so on. <br>

Depth First Search (DFS) <br>
Depth First Search is an in-depth search. Suppose the traversal starts from vertex v, then the DFS algorithm is as follows:
Visit vertex v.
Visit vertex w which is adjacent to vertex v.
Repeat DFS starting from vertex w.
When reaching vertex u such that all neighboring nodes have been visited, the search is backtracked to the last previously visited node and has unvisited vertex w.
The search ends when no more unvisited nodes can be reached from the previously visited nodes. <br>

## Requirements
The application runs on Windows, just run bacefook.exe in the bin folder <br>
If you want to make changes / editing code, use Visual Studio

## How to use
Simply run bacefook.exe in the bin folder

## About the Creator

<ul>
<li> Leonardus Brandon Luwianto (13519102)
<li> Nathaniel Jason (13519108)
<li> Rizky Anggita Syarbaini Siregar (13519132)

Institut Teknologi Bandung <br>
2021
</ul>
