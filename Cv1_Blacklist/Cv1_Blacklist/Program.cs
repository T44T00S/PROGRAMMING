using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv1_Blacklist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vypište větu: ");
            string vstup = Console.ReadLine();

            string[] blacklist = new string[] {"ovce", "světlo", "SSPŠ", "Sáblo", "polygon" };

            string output = "";
            string[] split = vstup.Split(' ');

            //foreach (var item in blacklist)
            //{
            //    for (int i = 0; i < split.Length; i++)
            //    {
            //        if (split[i].Contains(blacklist[i]))
            //        {
            //            Console.Write(split[i].Remove(2, 1).Insert(2, "*"));

            //            //output += slovo.Remove(i, 1);
            //            //output += slovo.Insert(i, "*");
            //        }
            //    }
            //}

            foreach (var slovo in split)
            {
                foreach (var slovo2 in blacklist)
                {
                    if (slovo.Contains(slovo2))
                    {
                        output += slovo.Insert(2, "*") + " ";
                    }
                }
            }

            //string result = string.Join(" ", split);

            //Console.WriteLine(string.Join(output, split));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
