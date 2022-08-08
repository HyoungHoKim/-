// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace 백준문제풀이
// {
//     class Program
//     {
//         static StringBuilder result = new StringBuilder();
        
//         static void Main(string[] args)
//         {
//             int n = Int32.Parse(Console.ReadLine());
    
//             Dictionary<string, int> dic = new Dictionary<string, int>();
//             Dictionary<string, int> zeroDic = new Dictionary<string, int>();
//             Dictionary<string, int> AllDic = new Dictionary<string, int>();
//             for (int i = 1; i <= 20; i++)
//             {
//                 dic[i.ToString()] = 0;
//                 zeroDic[i.ToString()] = 0;
//                 AllDic[i.ToString()] = 1;
//             }

//             for (int i = 0; i < n; i++)
//             {
//                 string input = Console.ReadLine();
//                 string[] commandLine = input.Split(' ');
//                 if (commandLine[0] == "add")
//                     dic[commandLine[1]]++;
//                 else if (commandLine[0] == "check")
//                 {
//                     if (dic[commandLine[1]] > 0)
//                         result.Append("1\n");
//                     else
//                         result.Append("0\n");
//                 }
//                 else if (commandLine[0] == "remove")
//                 {
//                     if (dic[commandLine[1]] > 0)
//                         dic[commandLine[1]]--;
//                 }
//                 else if (commandLine[0] == "toggle")
//                 {
//                     if (dic[commandLine[1]] > 0)
//                         dic[commandLine[1]]--;
//                     else
//                         dic[commandLine[1]]++;
//                 }
//                 else if (commandLine[0] == "all")
//                 {
//                     dic = AllDic;
//                 }
//                 else
//                 {
//                     dic = zeroDic;
//                 }
//             }

//             Console.Write(result);
//         }
//     }
// }
