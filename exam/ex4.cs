using System;
using System.Text;

namespace exam
{
    internal static class ex4
    {


        public static string PrintTriangle(int start)
        {
            StringBuilder a = new StringBuilder();
            for (int i = 1; start > 0; start -= 2, i++)
            {
                a.Append(new String('*', start));
                a.Append('\n');
                a.Append(new String(' ', i));
            }

            return a.ToString();
        }
    }
}
