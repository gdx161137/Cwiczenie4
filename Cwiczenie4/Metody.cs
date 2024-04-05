using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium.NET_metody
{
    internal class Metody
    {
        public static string Odwroc(string linliniaTekstu)
        {
            char[] charArray = linliniaTekstu.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
