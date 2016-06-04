using System;
using System.Collections.Generic;

namespace CYK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rule> G = new List<Rule>();

            G.Add(new Rule('S', "AC"));
            G.Add(new Rule('C', "SB"));
            G.Add(new Rule('S', "AB"));
            G.Add(new Rule('A', "a"));
            G.Add(new Rule('B', "b"));

            string word = "aaabbb";

            CYK parser = new CYK(word, G);

            parser.Parse();
            parser.PrintTable();

            string not = "";

            if (!parser.GetResult())
                not = "'t";

            Console.WriteLine("\"{0}\" can" + not + " be produced!", word);
        }
    }
}
