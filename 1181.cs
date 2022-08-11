// using System;
// using System.Collections.Generic;
// using System.Text.RegularExpressions;

// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string input = Console.ReadLine();
//             int size = Int32.Parse(input);

//             List<string> list = new List<string>();
//             for (int i = 0; i < size; i++)
//             {
//                 string str = Console.ReadLine();
//                 if (Regex.IsMatch(str, "^[a-z]+$") && !list.Exists(x => x == str))
//                     list.Add(str);
//             }

//             list.Sort((a, b) => {
//                 if (a.Length < b.Length)
//                     return -1;
//                 else if (a.Length > b.Length)
//                     return 1;
//                 else
//                     return String.Compare(a, b); 
//             });

//             foreach (string str in list)
//                 Console.WriteLine(str);
//         }
//     }
// }
