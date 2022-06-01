using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exam
{
    internal static class ex6
    {
        public static string Go()
        {
            StringBuilder result = new StringBuilder();
            string tempStr;
            char temp;
            string path1 = @"..\in1.txt";
            string path2 = @"..\in2.txt";

            using (StreamReader reader = new StreamReader(path1))
            {
                result.Append( reader.ReadToEnd());
            }
            
            using (StreamReader reader = new StreamReader(path2))
            {
                result.Append(reader.ReadToEnd());
            }
            tempStr= result.ToString();
            result.Clear();
            result.Append(Regex.Replace(tempStr, " ", ""));
            tempStr = result.ToString();

            //      no done!!
            for (int i = 0; i < tempStr.Length; i++)
            {
                temp = result[i];
                for (int j = 0; j < tempStr.Length; j++)
                    if (temp == result[j]) result.Replace(result[j], 'x');
            }

            tempStr = result.ToString();
            result.Clear();
            result.Append(Regex.Replace(tempStr, "x", ""));

            return result.ToString();
        }
    }
}
