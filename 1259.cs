// using System;
// using System.Collections.Generic;

// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<string> list = new List<string>();
//             while (true)
//             {
//                 string str = Console.ReadLine();
//                 if (str == "0") break;

//                 int i = 0;
//                 for (i = 0; i < str.Length/2; i++)
//                 {
//                     if (str[i] != str[str.Length - 1 - i])
//                     {
//                         list.Add("no");
//                         break;
//                     }
//                 }    

//                 if (i == str.Length/2)
//                     list.Add("yes");            
//             }

//             foreach(string str in list)
//                 Console.WriteLine(str);
//         }
//     }
// }
