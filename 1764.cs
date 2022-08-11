// using System;
// using System.Collections.Generic;

// namespace Program
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
//             string input = Console.ReadLine();
//             string[] nm = input.Split(' ');

//             Dictionary<string, int> person = new Dictionary<string, int>();
//             for (int i = 0; i < Int32.Parse(nm[0]); i++)
//             {
//                 string notHear = Console.ReadLine();
//                 person[notHear] = 0;
//             }

//             List<string> result = new List<string>();
//             for (int i = 0; i < Int32.Parse(nm[1]); i++)
//             {
//                 string notSee = Console.ReadLine();
                
//                 // if (person.ContainsKey(notSee))
//                     result.Add(notSee);
//             }
            
//             result.Sort();

//             Console.WriteLine(result.Count);
//             foreach (string str in result)
//                 Console.WriteLine(str);
// 		}
// 	}
// } 