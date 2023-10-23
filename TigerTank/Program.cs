using MyClassLib.WordOfTanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TigerTank
{
    public class Program
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=c6lgJoH5NMc&ab_channel=JustGamer
        /// 
        /// </summary>
        static void Main(string[] args)
        {
            Tank[] T34Tanks = new Tank[5];

            Tank[] PanteraTanks = new Tank[5];

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                T34Tanks[i] = new Tank("\nT-34 " + (i + 1), rand.Next(0, 101), rand.Next(0, 101), rand.Next(0, 101));

                PanteraTanks[i] = new Tank("\nPantera " + (i + 1), rand.Next(0, 101), rand.Next(0, 101), rand.Next(0, 101));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n{T34Tanks[i]} vs {PanteraTanks[i]}");

                bool T34Wins = T34Tanks[i] ^ PanteraTanks[i];

                Console.WriteLine(T34Wins ? "\nИтог: \tT-34 Пoбедил, ИУУУУУУ. Есть пробитие!" : 
                                            "\nИтог: \tPantera Победил, Мой Ф***р");
            }
            Console.ReadKey();
        }
    }
}
