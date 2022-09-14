using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Peaklass
    {
        public static Random rnd = new Random();
       

        
        static string getName()
        {
            string[] names = { "asd", "fgh", "hjk", "klö", "zxc", "vbn", "nm,", "qwe", "rty", "uio", "püõ" };
            return names[rnd.Next(names.Length)];
        }


    }
}
