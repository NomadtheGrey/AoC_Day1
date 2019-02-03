using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day1
{
    class Program
    {
        static List<int> FrequencyList = new List<int>();
        static void Main(string[] args)
        {
            int sum = File.ReadAllLines(@"C:\Projects\Advent_of_Code\Day_1\AoC_Day1\PuzzleInput.txt").Sum(x=>Convert.ToInt32(x));
            
            Console.WriteLine("Total: {0}",sum);
            Console.ReadKey();
        }
    }
}
