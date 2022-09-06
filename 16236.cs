// using System;
// using System.Linq;
// using System.Collections.Generic;

// namespace Program
// {
// 	class Program
// 	{
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

//         static List<List<int>> map = new List<List<int>>();
//         static List<int> numList = new List<int>();
//         static int size = 2;
//         static Pos babyPos = new Pos();
//         static int move = 0;
//         static int eat = 0;
//         static int[] moveX = {0, -1, 0, 1};
//         static int[] moveY = {1, 0, -1, 0};

//         static int BFS(int n, List<List<bool>> visited)
//         {
//             Queue<(Pos, int)> q = new Queue<(Pos, int)>();
//             Queue<(Pos, int)> minQ = new Queue<(Pos, int)>();
//             q.Enqueue((babyPos, 0));
//             visited[babyPos.y][babyPos.x] = true;

//             while (q.Count > 0)
//             {
//                 //Console.WriteLine("size : " + size + ", min : " + numList[0]);
//                 (Pos, int) curPos = q.Dequeue();
//                 int curX = curPos.Item1.x;
//                 int curY = curPos.Item1.y;

//                 for (int i = 0; i < 4; i++)
//                 {
//                     int nextX = curX + moveX[i];
//                     int nextY = curY + moveY[i];

//                     if (nextX >= 0 && nextX < n && nextY >= 0 && nextY < n)
//                     {
//                         int value = map[nextY][nextX];
//                         if (value <= size && visited[nextY][nextX] == false)
//                         {
//                             if (value > 0 && value < size)
//                             {
//                                 if (minQ.Count == 0)
//                                     minQ.Enqueue((new Pos(nextX, nextY), curPos.Item2 + 1));
//                                 else
//                                 {
//                                     if (minQ.Peek().Item2 == curPos.Item2 + 1 
//                                         && !(minQ.Peek().Item1.x == nextX && minQ.Peek().Item1.y == nextY))
//                                         minQ.Enqueue((new Pos(nextX, nextY), curPos.Item2 + 1));
//                                 }
//                             }

//                             if (minQ.Count == 0)
//                                 q.Enqueue((new Pos(nextX, nextY), curPos.Item2 + 1));
//                             else if (curPos.Item2 < minQ.Peek().Item2)
//                                 q.Enqueue((new Pos(nextX, nextY), curPos.Item2 + 1));
//                             visited[nextY][nextX] = true;
//                         }
//                     }
//                 }
//             }

//             if (minQ.Count == 0)
//                 return -1;
//             else
//             {
//                 (Pos, int) minH = (new Pos(21, 21), 21 * 21);
//                 List<(Pos, int)> qList = new List<(Pos, int)>();
//                 while (minQ.Count > 0)
//                 {
//                     (Pos, int) temp = minQ.Dequeue();
//                     qList.Add(temp);
//                     if (minH.Item1.y > temp.Item1.y)
//                         minH = temp;
//                 }

//                 (Pos, int) minW = minH;
//                 foreach ((Pos, int) temp in qList)
//                 {
//                     if (minH.Item1.y == temp.Item1.y)
//                     {
//                         if (minH.Item1.x > temp.Item1.x)
//                             minW = minH;
//                     }
//                 }
                
//                 numList.Remove(map[minW.Item1.y][minW.Item1.x]);
//                 map[minW.Item1.y][minW.Item1.x] = 0;
//                 babyPos.x = minW.Item1.x;
//                 babyPos.y = minW.Item1.y;
//                 eat++;
//                 if (eat == size)
//                 {
//                     size++;
//                     eat = 0;
//                 }
                
//                 return minW.Item2;
//             }
//         }

// 		static void Main(string[] args)
// 		{
//             int n = Int32.Parse(Console.ReadLine());

//             for (int i = 0; i < n; i++)
//             {
//                 string line = Console.ReadLine();
//                 string[] nums = line.Split(' ');

//                 List<int> nLine = new List<int>();
//                 for(int j = 0; j < n; j++)
//                 {
//                     int temp = Int32.Parse(nums[j]);
//                     if (temp > 0 && temp < 7)
//                         numList.Add(temp);
                    
//                     if (temp == 9)
//                     {
//                         babyPos.x = j;
//                         babyPos.y = i;
//                         nLine.Add(0);
//                     }
//                     else
//                         nLine.Add(Int32.Parse(nums[j]));
//                 }
//                 map.Add(nLine);
//             }
//             numList.Sort();
            
//             while (numList.Count > 0)
//             {
//                 if (size <= numList[0])
//                     break;

//                 List<List<bool>> visited = new List<List<bool>>(); 
//                 for (int i = 0; i < n; i++)
//                 {
//                     List<bool> line = new List<bool>();
//                     for (int j = 0; j < n; j++)
//                         line.Add(false);
//                     visited.Add(line);
//                 }

//                 int moveCnt = BFS(n, visited);
//                 if (moveCnt == -1)
//                     break;
//                 move += moveCnt;
//             }

//             Console.WriteLine(move);
// 		}
// 	}
// } 
