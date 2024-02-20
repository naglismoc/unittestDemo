using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittestDemo
{
    public class TextFormating
    {
        public static string nameCase(string name)
        {
            if (name.Equals(""))
            {
                return "";
            }
            name = name.Trim().ToLower();
            string[] nameArr = name.Split(" ");
            string result = "";
            foreach (var item in nameArr)
            {
                result += item[0].ToString().ToUpper() + item.Substring(1) + " ";
            }
            return result.Trim();
        }
    }
}
