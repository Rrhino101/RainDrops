using System;

namespace PlingPlangPlong
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RainDrops(5));
        }

        public static string RainDrops(int rainDrop)
        {
            string rainDropSound = null;

            if (rainDrop % 3 == 0)
            {
                rainDropSound += "Pling";
            }
            if (rainDrop % 5 == 0)
            {
                rainDropSound += "Plang";
            }
            if (rainDrop % 7 == 0)
            {
                rainDropSound += "Plong";
            }

            return rainDropSound == null ? rainDrop.ToString() : rainDropSound;
        }
    }
}
