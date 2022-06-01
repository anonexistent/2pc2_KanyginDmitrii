using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exam
{
    internal static class ex5
    {
        public static string Go()
        {
            string path = @"..\input.txt";
            StringBuilder str = new StringBuilder();
            var simnbols = "@g&";
            Regex rx = new Regex(simnbols); 
            using (StreamReader reader = new StreamReader(path))
            {
                str.Append(reader.ReadToEnd());
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == simnbols[0] || str[i] == simnbols[1] || str[i] == simnbols[2]) str.Remove(i, 1);
            }
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(str);
            }
            return str.ToString();
            //ok
        }        
    }
}
