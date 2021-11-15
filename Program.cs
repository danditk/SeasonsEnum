using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonsEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            SeasonsEnum season = SeasonsEnum.Jesień;
            Console.WriteLine(season);
            Console.WriteLine(SeasonsEnum.Zima);
            Console.WriteLine((int)season);

            Console.WriteLine((SeasonsEnum)2);
            
            Console.ReadKey();
        }
    }
}
