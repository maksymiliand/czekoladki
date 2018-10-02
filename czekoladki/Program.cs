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
            inicjujstan(czekodzem);

            wyswietlstan(czekodzem);

            for (int c = 0;c<czekodzem.GetLength(0) * czekodzem.GetLength(1);c++)
            {

                Console.WriteLine("ktora czekoladka z czekodzemu jest odpowiednia by ją zjesc zdecyduj sam [wiersze]");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("ktora czekoladka z czekodzemu jest odpowiednia by ją zjesc zdecyduj sam [kolumny]");
                int b = int.Parse(Console.ReadLine());
                
                
                if (czekodzem[a,b] == true)
                {
                    czekodzem[a,b] = false;
                }
                else
                {
                    Console.WriteLine("NIE OSZUKUJ TO GLUPIE!!!!");
                    c--;
                }
                

                wyswietlstan(czekodzem);
            }

            Console.ReadKey();
            
        }
        static void wyswietlstan(bool[,] czekodzem)
        {
            for (int i = 0; i<czekodzem.GetLength(0); i++)
            {
                for (int j = 0;j<czekodzem.GetLength(1);j++)
                {
                   if (czekodzem[i,j] == true)
                   {
                       Console.Write("|  ");
                   }     
                   else
                   {
                       Console.Write("| X");
                   } 
                }
                Console.WriteLine("|");
            }
        }
        static void inicjujstan(bool[,] czekodzem)
        {
            for (int i = 0; i<czekodzem.GetLength(0); i++)
            {
                for (int j = 0;j<czekodzem.GetLength(1);j++)
                {
                   czekodzem[i,j] = true;
                }
            }
        }
    }
}
