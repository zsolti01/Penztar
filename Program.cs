using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penztar
{
    internal class Program
    {
        public static int[] tm = new int[6] {500, 1000, 2000, 5000, 10000, 20000};
        public static int[] money = new int[6];

        public static void beker()
        {
            for (int i = 0; i < tm.Length; i++)
            {
                Console.Write($"Kérem {i+1}. bankjegy értékét: ");
                money[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            beker();
        }
    }
}
