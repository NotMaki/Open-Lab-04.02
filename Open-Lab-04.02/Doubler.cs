using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string dchar = "";
            foreach (char c in original)
            {dchar = dchar+c+c;}
            return  dchar;
        }
    }
}
