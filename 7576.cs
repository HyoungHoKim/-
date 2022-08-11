// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace Program
// {
// 	class Program
// 	{
//         static int[] moveX = {0, 0, -1, 1};
//         static int[] moveY = {1, -1, 0, 0}; 
//         static List<List<int>> box = new List<List<int>>();
//         static List<List<int>> visited = new List<List<int>>();

//         struct Pos
//         {
//             public int x;
//             public int y;

//             public Pos(int x, int y)
//             {
//                 this.x = x;
//                 this.y = y;
//             }
//         }

//         static int BFS(int M, int N)
//         {
//             int day = -1;
//             Queue<Pos> q = new Queue<Pos>();

//             for (int i = 0; i < N; i++)
//             {
//                 for (int j = 0; j < M; j++)
//                 {
//                     if (box[i][j] == 1)
//                     {
//                         q.Enqueue(new Pos(j, i));
//                         visited[i][j] = -1;
//                     }
//                 }
//             }

//             int count = q.Count;
//             while (q.Count > 0)
//             {
//                 Pos curPos = q.Dequeue();
//                 count--;

//                 for (int k = 0; k < 4; k++)
//                 {
//                     int nextX = curPos.x - moveX[k];
//                     int nextY = curPos.y - moveY[k];

//                     if(nextX >= 0 && nextX < M && nextY >= 0 && nextY < N)
//                     {
//                         if (box[nextY][nextX] == 0 && visited[nextY][nextX] != -1)
//                         {
//                             q.Enqueue(new Pos(nextX, nextY));
//                             box[nextY][nextX] = 1;
//                             visited[nextY][nextX] = -1;
//                         }
//                     }
//                 }

//                 if (count == 0)
//                 {
//                     count = q.Count;
//                     day++;
//                 }
//             }

//             return day;
//         }

// 		static void Main(string[] args)
// 		{
// 			string input = Console.ReadLine();
//             string[] MN = input.Split(' ');
//             int M = Int32.Parse(MN[0]);
//             int N = Int32.Parse(MN[1]);

//             for (int i = 0; i < N; i++)
//             {
//                 string line = Console.ReadLine();
//                 string[] numLine = line.Split(' ');
//                 List<int> intLine = new List<int>();

//                 for (int j = 0; j < M; j++)
//                     intLine.Add(Int32.Parse(numLine[j]));
//                 box.Add(intLine);
//                 visited.Add(intLine.ToList());
//             }

//             int day = BFS(M, N);

//             if (visited.Exists(x => x.Exists(s => s == 0)))
//                 day = -1;
            
//             Console.WriteLine(day);
// 		}
// 	}
// } 