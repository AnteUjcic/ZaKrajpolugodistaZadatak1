using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3;
            //12345678
            //Hrvatska ima more
            //1234567
            //Italija je prvak svijeta
            //Hrvatska je prvak svijeta
            s1 = s1.Substring(0, 8);
            s2 =s2.Substring(Math.Max(0,7));
            s3 = s1 + s2;

            Console.Write(s3);
            Console.ReadKey();
        }
    }
}
