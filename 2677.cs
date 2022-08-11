// using System;
// using System.Collections.Generic;

// namespace Program
// {
// 	class Program
// 	{
//         static void DFS(int x, int y, ref char[,] mat, ref int count)
//         {
//             int n = mat.GetLength(0);
//             int[] moveX = new int[] {0, 0, 1, -1};
//             int[] moveY = new int[] {1, -1, 0, 0};

//             for (int i = 0; i < 4; i++)
//             {
//                 int nextX = x + moveX[i];
//                 int nextY = y + moveY[i];
//                 if (nextX >= 0 && nextX < n && nextY >= 0 && nextY < n)
//                 {
//                     if (mat[nextY, nextX] == '1')
//                     {
//                         count++;
//                         mat[nextY, nextX] = '0';
//                         DFS(nextX, nextY, ref mat, ref count);
//                     }
//                 }
//             }
//         }

// 		static void Main(string[] args)
// 		{
// 			string input = Console.ReadLine();
//             int n = Int32.Parse(input);

//             char[,] mat = new char[n, n];        
//             for (int i = 0; i < n; i++)
//             {
//                 string line = Console.ReadLine();
//                 for (int j = 0; j < line.Length; j++)
//                     mat[i, j] = line[j];
//             }

//             int count = 0;
//             List<int> result = new List<int>();
//             for (int i = 0; i < n; i++)
//             {
//                 for(int j = 0; j < n; j++)
//                 {
//                     if (mat[j, i] == '0') continue;

//                     mat[j, i] = '0';
//                     count = 1;
//                     DFS(i, j, ref mat, ref count);
//                     if (count != 0)
//                         result.Add(count);
//                 }
//             }

//             Console.WriteLine(result.Count);
//             result.Sort();
//             foreach(int i in result)
//                 Console.WriteLine(i);
// 		}
// 	}
// } 