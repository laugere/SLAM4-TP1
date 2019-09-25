using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP1_Martin_laugere
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteCourant compte1 = new CompteCourant("Pierre", 3000, "euros", "012aze", 1000);
            CompteCourant compte2 = new CompteCourant("Marie", 500, "euros", "981wxc", 100);

            Console.ReadKey(true);
        }
    }
}
