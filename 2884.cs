// using System;

// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string input = Console.ReadLine();
//             string[] num = input.Split(' ');
            
//             int min = Int32.Parse(num[1]) - 45;
//             int hour = Int32.Parse(num[0]);
//             if (min < 0)
//             {
//                 hour = hour == 0 ? 23 : hour - 1;
//                 min += 60;
//             }

//             Console.WriteLine(hour + " " + min);
//         }
//     }
// }
