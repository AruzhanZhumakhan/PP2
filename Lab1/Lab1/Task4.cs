using System;

namespace Lab1
{
    public class Task4
    {

        private string output = "";

        private void print(string s)
        {
            output += s;
        }
        private void println()
        {
            output += "\n";
        }

        public static string DrawStarTriangle(int n)
        {
            string res = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    res += "[*]";
                }
                res += "\n";
            }
            return res;
        }
    }
}
