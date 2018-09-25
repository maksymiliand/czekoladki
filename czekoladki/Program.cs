using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace czekoladki
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] czekodzem = new bool[5,5];

            for (int i = 0; i<czekodzem.GetLength(0); i++)
            {
                for (int j = 0;j<czekodzem.GetLength(1);j++)
                {
                   Console.WriteLine("tblica to " + czekodzem[j,i]); 
                }
            }
            Console.ReadKey();
            
        }
    }
}
