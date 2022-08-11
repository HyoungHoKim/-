// using System;
// using System.Collections.Generic;

// namespace Program
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			int n = Int32.Parse(Console.ReadLine());

//             List<string> result = new List<string>();
//             for (int i = 0; i < n; i++)
//             {
//                 string command = Console.ReadLine();
//                 int len = Int32.Parse(Console.ReadLine());
//                 string temp = Console.ReadLine();
                
//                 temp = temp.Substring(1, temp.Length - 2);
//                 string[] elements = temp.Split(',');

//                 List<int> arr = new List<int>();
//                 if (len > 0)
//                 {
//                     for (int j = 0; j < elements.Length; j++)
//                         arr.Add(Int32.Parse(elements[j]));
//                 }

//                 int dCount = command.Count(x => x == 'D');
//                 if (dCount > arr.Count)
//                 {
//                     result.Add("error");
//                     continue;
//                 }

//                 bool flag = false;
//                 for (int j = 0; j < command.Length; j++)
//                 {
//                     if (command[j] == 'R')
//                         flag = !flag;
//                     else
//                     {
//                         if (!flag)
//                             arr.RemoveAt(0);
//                         else
//                             arr.RemoveAt(arr.Count - 1);
//                     }
//                 }

//                 if (flag)
//                     arr.Reverse();
//                 result.Add("[" + String.Join(",", arr) + "]");
//             }

//             foreach (string str in result)
//                 Console.WriteLine(str);
// 		}
// 	}
// } 