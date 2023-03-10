using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = " ";
            while (str[0] != '0')
            {
                Console.WriteLine("Input Email\"s");
                str = Console.ReadLine();
                Regex regex = new Regex(@"\b(?:[\w]{1,20}@)+(?:[\w]{1,20}\.[\w]{2,20})\b");
                MatchCollection m = regex.Matches(str);
                Console.WriteLine("Count: {0}", m.Count);
                for (int i = 0; i < m.Count; i++)
                {
                    Console.WriteLine(m[i].Value);
                }
            }
            str = " ";
            while (str[0] != '0')
            {
                Console.WriteLine("Input data(HH:MM:SS)\"s");
                str = Console.ReadLine();
                Regex regex = new Regex(@"\b([0,1][0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])\b");
                MatchCollection m = regex.Matches(str);
                Console.WriteLine("Count: {0}", m.Count);
                for (int i = 0; i < m.Count; i++)
                {
                    Console.WriteLine(m[i].Value);
                }
            }
        }
    }
}
