using System;
using System.Collections.Generic;
using System.Text;

namespace repeatStringChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a simple phrase to have each character doubled: ");
            string txt = Console.ReadLine();
            Program program = new Program();
            program.DoubleChar4(txt);
        }

        public void DoubleChar(string txt)
        {
            string finaltxt = "";
            for (int i = 0; i < txt.Length; i++)
            {
                finaltxt = finaltxt + txt[i] + txt[i];
            }
            Console.WriteLine("Your phrase: " + finaltxt);
        }

        public void DoubleChar2(string txt)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < txt.Length; i++)
            {
                charList.Add(txt[i]);
                charList.Add(txt[i]);
            }
            string str = new string(charList.ToArray());
            Console.WriteLine(str);
        }

        public void DoubleChar3(string txt)
        {
            StringBuilder strList = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
            {
                strList.Append(txt[i]);
                strList.Append(txt[i]);
            }
            Console.WriteLine(strList.ToString());
        }

        public void DoubleChar4(string txt)
        {
            StringBuilder strList = new StringBuilder();
            for (int i = 0; i < txt.Length; i++)
            {
                string str = new string(txt[i], 2);
                strList.Append(str);
            }
            Console.WriteLine(strList.ToString());
        }

    }
}
