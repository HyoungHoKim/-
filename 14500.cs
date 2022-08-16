using System;

namespace Program
{
	class Program
	{
        static int[] moveX = {0, 0, 1, -1};
        static int[] moveY = {1, -1, 0, 0};
        static int max = 0;
        static int N = 0;
        static int M = 0;
        static List<List<int>> mat = new List<List<int>>();
        static List<List<int>> visited = new List<List<int>>();

        static void DFS(int x, int y, int tempMax, int depth)
        {
            if (depth == 4)
            {
                if (tempMax > max)
                    max = tempMax;
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                int nextX = x + moveX[i];
                int nextY = y + moveY[i];

                if (nextX >= 0 && nextX < M && nextY >= 0 && nextY < N && visited[nextY][nextX] == 0)
                {
                    visited[nextY][nextX] = 1;
                    DFS(nextX, nextY, tempMax + mat[nextY][nextX], depth + 1);
                    visited[nextY][nextX] = 0;
                }
            } 
        }

        static void Cross(int x, int y)
        {
            for (int i = 0; i < 4; i++)
            {
                int sum = mat[y][x];
                int count = 1;

                int nextX = x + moveX[i];
                int nextY = y + moveY[i];
                for (int j = 0; j < 4; j++)
                {
                    int tempX = x + moveX[j];
                    int tempY = y + moveY[j];

                    if (nextX == tempX && nextY == tempY) continue;

                    if (tempX >= 0 && tempX < M && tempY >= 0 && tempY < N)
                    {
                        sum += mat[tempY][tempX];
                        count++;
                    }
                }

                if (sum > max && count == 4)
                    max = sum;
            }
        }

		static void Main(string[] args)
		{
			string input = Console.ReadLine();
            string[] split = input.Split(' ');
            N = Int32.Parse(split[0]);
            M = Int32.Parse(split[1]);
            
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();
                string[] sline = line.Split(' ');

                List<int> numLine = new List<int>();
                List<int> vLine = new List<int>();
                foreach(string num in sline)
                {
                    numLine.Add(Int32.Parse(num));
                    vLine.Add(0);
                }
                mat.Add(numLine);
                visited.Add(vLine);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Cross(j, i);
                    visited[i][j] = 1;
                    DFS(j, i, mat[i][j], 1);
                    visited[i][j] = 0;
                }
            }

            Console.WriteLine(max);
		}
	}
} 