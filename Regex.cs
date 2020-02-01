using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Regex1
{
    class Program
    {
        static void FirstRegex()
        {
            string text = "thisisme10 hello thisisme10";
            string expr = @"[a-z0-9]{10}";
            MatchCollection mc = Regex.Matches(text, expr);
            foreach(Match m in mc)
            {
                Console.WriteLine("{0}", m);
            }
        }
        static void SecondRegex()
        {
            string text = "This is 3 , this is 5 , this is 7";
            string expr = @"[3 5 7]*";
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine("{0}", m);
            }
        }
        static void ThirdRegex()
        {
            string text = "HELLO,this is me AGAIN";
            string expr = @"[A-Z]{5}";
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine("{0}", m);
            }
        }
        static void ForthRegex()
        {
            string text = "test@abv.bg";
            string expr = @"\w{1,10}@\w{1,10}.\w{2,3}";
            MatchCollection mc = Regex.Matches(text, expr);
            foreach(Match m in mc)
            {
                Console.WriteLine("{0}", m);
            }
        }
        static void Main()
        {
            FirstRegex();
            SecondRegex();
            ThirdRegex();
            ForthRegex();
        }
    }
}
